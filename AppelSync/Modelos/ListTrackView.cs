using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AppelSync.Modelos
{
    /// <summary>
    /// Clase para Contener las listas de Musica junto con una marca si queremos sincronizarlas o no
    /// por defecto todas las listas empezan activas
    /// </summary>
    public class ListTrackView
    {
        public string Name { set; get; }
        public bool Active { set; get; }

        public long PesoLista { get 
            {
                long peso= 0;
                foreach(TrackViewElement cancion in ListaCanciones)
                {
                    peso += cancion.PesoBytes;
                }
                return peso;
            } }
        public delegate void FeedFromList(string feed);
        public event FeedFromList OnFeed;

        public List<TrackViewElement> ListaCanciones { set; get; }

        public ListTrackView(string name)
        {
            Name = name;
            Active = true;
            ListaCanciones = new List<TrackViewElement>();
        }

        public void SyncroTo(string path)
        {
            foreach(TrackViewElement tve in ListaCanciones)
            {
                tve.SyncroTo(path);
            }
        }

        public StringBuilder CreateRepList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#EXTM3U");

            foreach(TrackViewElement tve in ListaCanciones)
            {
                if(tve.Active)
                {               
                    string[] filepath = tve.Cancion.FilePath.Split('.');// Para extraer el tipo del archivo

                    sb.AppendLine("#EXTINF:"+ tve.GetSongDuration() + " ,"+ tve.Cancion.Name);
                    sb.Append(".\\Music\\").Append(tve.Cancion.Name).Append("-").Append(tve.Cancion.TrackId).Append(".").AppendLine(filepath[filepath.Length-1]);
                }

            }
            return sb;
        }  

        public void WriteRepList(string path)
        {
            using (StreamWriter file = new StreamWriter(path + "/" + Name + ".M3U"))
            {
                file.WriteLine(CreateRepList().ToString());
            }
        }
    }
}
