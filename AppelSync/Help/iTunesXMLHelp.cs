using AppelSync.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppelSync.Help
{
    public partial class iTunesXMLHelp : Form
    {
        private int Photoindice= 0;
        private Image[] Photos;
        private Timer Atimer;
        public iTunesXMLHelp()
        {
            InitializeComponent();
            InitialicePhotos();
            pictureBox1.Image = Photos[0];

            Atimer = new Timer();
            Atimer.Interval = 700;
            Atimer.Tick += ChangeImage;

            Atimer.Start();

        }
        

        private void InitialicePhotos()
        {
            List<Image> newphotos = new List<Image>();
            newphotos.Add(Resources.Gf11);
            newphotos.Add(Resources.Gf2);
            newphotos.Add(Resources.Gf3);
            newphotos.Add(Resources.GF4);
            newphotos.Add(Resources.GF5);
            newphotos.Add(Resources.GF6);
            newphotos.Add(Resources.GF7);
            newphotos.Add(Resources.GF8);
            newphotos.Add(Resources.GF9);
            Photos=newphotos.ToArray();
        }

        private void ChangeImage(object sender, EventArgs e)
        {
            if (++Photoindice > Photos.Length+2)
            {
                Photoindice = 0;
            }
            //PAUSA en el fotograma final 2 ciclos
            if(Photoindice < Photos.Length)
            {
                pictureBox1.Image = Photos[Photoindice];
            }
        }
    }
}
