using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webmaster442.LibItunesXmlDb;
using AppelSync.Modelos;
using AppelSync.Controller;
using System.IO;
using System.Xml.Linq;
using System.Threading;
using AppelSync.Help;

namespace AppelSync
{
    public partial class Interface : Form
    {
        private AppSync AppSync;
        private ListTrackView ListaActiva;

        public Interface()
        {
            InitializeComponent();
            if(Screen.PrimaryScreen.Bounds.Height <1800)
            {
                HelpBTTN.IconSize = 20;
                HelpBTTN.Padding = new Padding(2, 0, 2, 0);
                itunesButton.IconSize = 20;
                itunesButton.Padding = new Padding(0, 0, 2, 0);
                DestinoButton.IconSize = 20;
                DestinoButton.Padding = new Padding(0, 0, 0, 0);
                SyncroButton.IconSize = 20;
                SyncroButton.Padding = new Padding(0, 0, 0, 0);
            }
            TablaListas.RowHeadersWidth = 30;
            TablaListas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CancionesTabla.RowHeadersWidth = 30;
            CancionesTabla.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private AppSync AsignXMLiTunes(string path)
        {
            AppSync = new AppSync(path);
            AppSync.OnSyncroFeed += SyncroFeedBack;

            TablaListas.DataSource = AppSync.Listas;

            TablaListas.CellStateChanged += TablaListas_CellStateChanged;

            AppSync.LoadLastSelection();
            
            return AppSync;
        }

        private void RefreshInterface()
        {
            bool xmlon = File.Exists(AppSync.AppelXMLRoute);
            bool syncroon = Directory.Exists(AppSync.BaseSyncroRoute);
            if (xmlon){
                PathitunesXML.Text = AppSync.AppelXMLRoute.Replace('/', '\\');
                PathitunesXML.ForeColor = Color.Black;
            }
            else
            {
                PathitunesXML.Text = "Se Necesita tener acceso a la libreria XML de iTunes.";
                PathitunesXML.ForeColor = Color.Red;
            }

            if (syncroon)
            {
                pathSyncro.Text = (AppSync.BaseSyncroRoute+"SyncroApp").Replace('/','\\');
                pathSyncro.ForeColor = Color.Black;
            }
            else
            {
                pathSyncro.Text = "Se Necesita configurar el dispositivo donde conectar.";
                pathSyncro.ForeColor = Color.Red;
            }

            SyncroButton.Enabled = xmlon && syncroon;
        }

        private void TablaListas_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            ActualizarPesoLista();
        }

        /// <summary>
        /// Gestion del Evento al Pulsar sobre una Lista para Cargarla en el Visor de Canciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ActualizarPesoLista()
        {
            if (ListaActiva != null)
            {
                PesoLista.Text = "Total: " + (ListaActiva.PesoLista / (1024 * 1024)).ToString() + " MB";
            }
            
            if (AppSync != null)
            {            
                PesoListas.Text = "Total: " + (AppSync.GetPesoTotal() / (1024 * 1024)).ToString() + " MB";
            }
        }

        private void SyncroAction(object sender, EventArgs e)
        {
            Thread T = new Thread(() => { AppSync.SyncroFiles(); });
            T.Start();
        }

        private void SyncroFeedBack(string e)
        {
            Invoke( new MethodInvoker(() =>
            {
               SyncroFeed.Text= e;
            }));
        }

        private void DestinoButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if(diag.ShowDialog() == DialogResult.OK)
            {
                AppSync.BaseSyncroRoute = diag.SelectedPath.Replace('/', '\\');
                if(AppSync.BaseSyncroRoute.Substring(AppSync.BaseSyncroRoute.Length-1) != "\\")
                {
                    AppSync.BaseSyncroRoute += "\\";
                }

            }
            TablaListas.Refresh();
            RefreshInterface();
        }

        private void TablaListas_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < AppSync.Listas.Count)
            {
                String name = AppSync.Listas[e.RowIndex].Name;
                ListaActiva = AppSync.Biblioteca[name];
                CancionesTabla.DataSource = ListaActiva.ListaCanciones;
                TablaListas.CommitEdit(DataGridViewDataErrorContexts.Commit);
                CancionesLabel.Text = "Canciones - " + ListaActiva.Name;
            }

            if(e.ColumnIndex == 1)
            {
                AppSync.Listas[e.RowIndex].Active = !AppSync.Listas[e.RowIndex].Active;
            }
            ActualizarPesoLista();
        }

        private void CancionesTabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ListaActiva != null && e.ColumnIndex==1)
            {
                ListaActiva.ListaCanciones[e.RowIndex].Active = !ListaActiva.ListaCanciones[e.RowIndex].Active;
                ActualizarPesoLista();
            }
        }

        private void helpXMLButton_Click(object sender, EventArgs e)
        {
            Form help = new iTunesXMLHelp();
            help.Show();
        }

        private void pathXMLButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "xml files (*.xml)|*.xml";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        AppSync newAppSync = AsignXMLiTunes(openFileDialog.FileName);
                        AppSync=newAppSync;
                    }catch (Exception ex) {
                        MessageBox.Show(ex.ToString(), "Error");
                    }
                    
                }
            }

        }

        private void FirstChargeXML(object sender, EventArgs e)
        {

            if (File.Exists(ITunesXmlDb.UserItunesDbPath))
            {
                try
                {
                    AsignXMLiTunes(ITunesXmlDb.UserItunesDbPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                HelpBTTN.Visible = true;
            }

            RefreshInterface();

        }
    }


}
