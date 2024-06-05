using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Webmaster442.LibItunesXmlDb;

namespace AppelSync.Modelos
{

    public class TrackViewElement
    {
        public Track Cancion { get; set; }
        public string Nombre { get; set; }
        public Boolean Active { get; set; }

        private long _PesoBytes { get; set; }

        public long PesoBytes { get {
                if (Active)
                {
                    return _PesoBytes;
                }
                return 0; 
            } }
        public delegate void FeedFromTrack(string feed);
        public event FeedFromTrack OnFeed;

        public TrackViewElement(Track track) 
        {
            Cancion = track;
            Nombre = track.Name;
            Active = true;
            _PesoBytes = CalcularPeso();
        }

        private long CalcularPeso()
        {
            FileInfo file = new FileInfo(Cancion.FilePath);

            return file.Length;
        }

        public void SyncroTo(string path)
        {
            string CopyName = "/" + Cancion.Name + "-" + Cancion.TrackId;
            try {
                FileInfo me = new FileInfo(Cancion.FilePath);

                if (!File.Exists(path + CopyName + me.Extension)) 
                { 
                    sendEvent("Copiando " + Cancion.Name);
                    me.CopyTo(path + CopyName + me.Extension);
                }
            }
            catch
            {
                OnFeed("Error Copiando la Cancion " + CopyName  );
                MessageBox.Show("Error Copiando la Cancion " + CopyName+"\nCompruebe el nombre de la misma", "Error Copiando Cancion");
            }
        }
        public int GetSongDuration()
        {
            int SongDuretion = 0;
            try
            {
                string[] partial = Cancion.PlayingTime.ToString().Split(':');
                for (int i = 0; i < partial.Length; i++)
                {
                    //Por si dura dias.....  
                    if (i == 1 && partial.Length > 3)
                    {
                        SongDuretion *= 24;
                    }
                    else
                    {
                        SongDuretion *= 60;
                    }

                    SongDuretion += int.Parse(partial[i]);
                }
            }
            catch (Exception e)
            {
                SongDuretion = -1;
            }
            return SongDuretion;
        }

        private void sendEvent(string Text)
        {
            OnFeed?.Invoke(Text);
        }
    }
}
