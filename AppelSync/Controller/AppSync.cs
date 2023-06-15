using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Webmaster442.LibItunesXmlDb;
using AppelSync.Modelos;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace AppelSync.Controller
{
    public class AppSync
    {
        public string AppelXMLRoute { get; set; }
        public string BaseSyncroRoute { get; set; }

        private ITunesXmlDb Libreria;
        private List<FileInfo> ExternalFiles;

        public Dictionary<string,ListTrackView> Biblioteca { get; }
        public List<ListTrackView> Listas { get; }
        
        public delegate void SyncroFeedContext(string feed);
        public event SyncroFeedContext OnSyncroFeed;

        public AppSync(string path) {
            this.AppelXMLRoute = path;
            this.Libreria = new ITunesXmlDb(path, new ITunesXmlDbOptions());
            Biblioteca= new Dictionary<string, ListTrackView>();
            Listas = new List<ListTrackView>(); 
            GenerarBiblioteca();
        }


        /// <summary>
        /// Esta funcion genera todas los recursos necesarios para gestionar la libreria de canciones.
        /// 
        /// </summary>
        private void GenerarBiblioteca()
        {
            string[] listaBanArray = { "Biblioteca","Descargado","Música","Películas","Programas de TV", "Podcasts","Audiolibros","Genius" };
            List<string> listaBan = listaBanArray.ToList();
            
           
            foreach (string list in Libreria.Playlists)
            {
                // Filtramos lista de Canciones
                if (!listaBan.Contains(list))
                {
                    ListTrackView newlista = new ListTrackView(list);
                    newlista.OnFeed += SyncroFeedFromElement;
                    
                    Listas.Add(newlista);
                    Biblioteca.Add(list,newlista);

                    foreach (Track cancion in Libreria.ReadPlaylist(list))
                    {
                        try
                        {
                            TrackViewElement newCancion = new TrackViewElement(cancion);
                            newlista.ListaCanciones.Add(newCancion);
                            newCancion.OnFeed += SyncroFeedFromElement;
                        }catch(Exception ex)
                        {
                            MessageBox.Show("Error al intentar acceder a la cancion " + cancion.Name + ", error I/O \nCompruebe que la canción todavia esta en su equipo, y/o que el nombre no tenga caracteres extraños.\n"+ex.Message, "ERROR");
                        }
                        
                    }
                }
            }       
        }

        public void SyncroFiles()
        {
            try
            {
                PrepareExternalDirectory();
                GetFilesExternalDirectory();
                RemoveOldRepList();
                DeleteNotSyncroTracks();
                SyncroList();
                SaveSelection();

                OnSyncroFeed("Sincronizacion Finalizada");
                MessageBox.Show("Sincronizacion Finalizada", "AppSyncro");
            }catch(Exception e)
            {
                MessageBox.Show(e.Message,"Error");
            }
        }


        /// <summary>
        /// Prepara la unidad seleccionada creando los directorios que se necesitaran para la syncro si no estubieran ya creados.
        /// </summary>
        private void PrepareExternalDirectory()
        {
            if (!Directory.Exists(BaseSyncroRoute + "SyncroApp") && Directory.Exists(BaseSyncroRoute)){
                DirectoryInfo di = Directory.CreateDirectory(BaseSyncroRoute + "SyncroApp");
            }
            if(!Directory.Exists(BaseSyncroRoute + "SyncroApp/Music"))
            {
                DirectoryInfo di = Directory.CreateDirectory(BaseSyncroRoute + "SyncroApp/Music");
            }
        }

        /// <summary>
        /// Genera la Lista de Archivos Existentes en La Carpeta /Music
        /// </summary>
        private void GetFilesExternalDirectory()
        {
            DirectoryInfo di = new DirectoryInfo(BaseSyncroRoute + "SyncroApp/Music");
            FileInfo[] ListFiles = di.GetFiles("*.*");
            ExternalFiles = ListFiles.ToList();

        }
        /// <summary>
        /// Remueve la Listas de Reproduccion que estan en la carpeta raiz
        /// </summary>
        private void RemoveOldRepList()
        {
            DirectoryInfo di = new DirectoryInfo(BaseSyncroRoute + "SyncroApp");
            FileInfo[] OldRepList = di.GetFiles("*.M3U");
            foreach (FileInfo OldRep in OldRepList)
            {
                OldRep.Delete();
            }
        }
        /// <summary>
        /// Recorre las Listas y hace que se ejecuten los comandos de sincronizacion y creacion de listas de reproduccion
        /// </summary>
        private void SyncroList()
        {
            foreach(ListTrackView ltv in Listas)
            {
                if(ltv.Active)
                {
                    ltv.SyncroTo(BaseSyncroRoute + "SyncroApp/Music");
                    ltv.WriteRepList(BaseSyncroRoute+"SyncroApp/");
                }
            }
        }
        /// <summary>
        /// Funcion para propagar los eventos que vienen de las Listas de Canciones(ListTrackView) y de las Canciones(TrackViewElement) 
        /// </summary>
        /// <param name="feed"></param>
        private void SyncroFeedFromElement(string feed)
        {
            OnSyncroFeed?.Invoke(feed);
        }
        
        /// <summary>
        /// Funcion para obtener el espacio en disco total que se requiere para sincronizar las listas (Se contempla las canciones repetidas
        /// entre todas las listas). Se usa Linq para agrupar las canciones repetidas.
        /// </summary>
        /// <returns>Peso total en Bytes</returns>
        public long GetPesoTotal()
        {
            IEnumerable<TrackViewElement> union = new List<TrackViewElement>();
            foreach (ListTrackView ltv in Listas)
            {
                if (ltv.Active)
                {
                    union = union.Union(ltv.ListaCanciones);
                }
            }

            var ListSyncroTracks =
                from TrackViewElement in union.Where(TrackViewElement => TrackViewElement.Active == true)
                let pathName = TrackViewElement.Cancion.TrackId + "-" + TrackViewElement.Cancion.Name
                group new
                {
                    TrackViewElement.PesoBytes
                }
                by pathName into SingleTrack
                orderby SingleTrack.Key
                select SingleTrack;

            long Peso = 0;

            foreach (var Sl in ListSyncroTracks)
            {
                Peso += Sl.First().PesoBytes;
            }

            return Peso;
        }

        /// <summary>
        /// Funcion para borrar las canciones que no son requeridas por el nuevo conjunto de Listas de Reproduccion
        /// </summary>
        private void DeleteNotSyncroTracks()
        {
            IEnumerable<TrackViewElement> union = new List<TrackViewElement>();
            foreach(ListTrackView ltv in Listas)
            {
                if (ltv.Active)
                {
                    union = union.Union(ltv.ListaCanciones);
                }
            }

            var ListSyncroTracks =
                from TrackViewElement in union.Where(TrackViewElement => TrackViewElement.Active==true)
                let pathName = TrackViewElement.Cancion.TrackId +"-"+ TrackViewElement.Cancion.Name
                group new
                {
                TrackViewElement
                }
                by pathName into SingleTrack
                orderby SingleTrack.Key
                select SingleTrack;
            
            foreach(FileInfo fi in ExternalFiles)
            {
                try
                {
                    //Removemos la extension del nombre
                    List<string> name = fi.Name.Split('.').ToList();
                    name.RemoveAt(name.Count-1);
                    ListSyncroTracks.First(El => El.Key == String.Join(".", name));                
                }
                catch
                {
                    fi.Delete();
                }
                
            }
        }

        private void SaveSelection()
        {
            JObject save = new JObject();
            JObject songsExcluidas = new JObject();
            JArray listasExcluidas = new JArray();
            foreach(var ltv in Listas)
            {
                JArray newLista = new JArray();
                if (!ltv.Active)
                {
                    listasExcluidas.Add(ltv.Name);
                }
                
                foreach(var song in ltv.ListaCanciones)
                {
                    if (!song.Active)
                    {
                        JObject newSong = new JObject();
                        newSong.Add("TrackId", song.Cancion.TrackId);
                        newSong.Add("Name", song.Cancion.Name);
                        newLista.Add(newSong);
                    }
                }
                songsExcluidas.Add(ltv.Name, newLista);
               
            }
            save.Add("ListasExcluidas", listasExcluidas);
            save.Add("CancionesExcluidas", songsExcluidas);

            using (StreamWriter file = new StreamWriter(GetSavePath()))
            {
                file.WriteLine(save.ToString());
            }
        }

        public void LoadLastSelection()
        {
            try
            {
                JObject listaExcluidas= null;

                string savepath = GetSavePath();

                if (File.Exists(savepath))
                {
                    using (StreamReader file = File.OpenText(savepath))
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        listaExcluidas = (JObject)JToken.ReadFrom(reader);
                    }

                    foreach (var Jpar in listaExcluidas)
                    {
                        switch (Jpar.Key)
                        {
                            case "ListasExcluidas":
                                foreach (string item in Jpar.Value)
                                {
                                    if (Biblioteca.TryGetValue(item, out ListTrackView listUnselected))
                                    {
                                        listUnselected.Active = false;
                                    }
                                }
                                break;
                            case "CancionesExcluidas":
                                foreach (var item in (JObject)Jpar.Value)
                                {
                                    UnSelectSongsfromLists(item.Key, item.Value);
                                    Console.WriteLine("hi");
                                }
                                break;
                        }
                    }
                    OnSyncroFeed("Antigua Seleccion Cargada con Exito.");
                }
            }catch (Exception ex)
            {
               
                OnSyncroFeed("Error al intentar cargar la antigua selección.\n"+ex.Message);
            }
        }

        private void UnSelectSongsfromLists(string listaname,JToken list) 
        {
            foreach (var item in list) {
                if (Biblioteca.TryGetValue(listaname, out ListTrackView listToUnselect))
                {
                    JArray lista = list as JArray;
                    foreach (var song in lista) 
                    {
                        JObject newitem = song as JObject;
                        try
                        {
                            string trackid = (string)newitem["TrackId"];
                            string nombre = (string)newitem["Name"];
                            TrackViewElement trv = listToUnselect.ListaCanciones.First(current => trackid == "" + current.Cancion.TrackId && nombre == current.Cancion.Name);
                            trv.Active = false;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }

        }

        private string GetSavePath()
        {
            List<string> savepathList = AppelXMLRoute.Split('\\').ToList();
            savepathList.RemoveAt(savepathList.Count - 1);
            string savepath = String.Join("\\", savepathList.ToArray()) + "\\SaveSelection.old";
            return savepath;
        }

    }
}
