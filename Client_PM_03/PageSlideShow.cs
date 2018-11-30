using PhotoManagerClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class PageSlideShow : Form
    {
        // Liste des id des photos incluses dans le diaporama
        public List<int> SlideShowList { get; set; }

        // Liste des photos incluses dans le diaporama
        public List<Photo> PhotoPool { get; set; }
        private List<Photo> Slides;

        // Liste des index de photo dans définissant l'ordre de passation
        private int[] PhotosOrder;
        // Ordre aléatoire si vrai
        private bool RandomOrder = false;
        // Plein écran si vrai
        private bool FullScreen = false;

        // Index courrant de PhotosOrder 
        private int Current_PhotosOrder_Index = 0;
        public PageSlideShow()
        {
            InitializeComponent();
            

            // Optimiser l'affichage
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            
        }
        private void DLG_Slideshow_Shown(object sender, EventArgs e)
        {
            WaitSplash.Show(this, "Loading slide show photos...");
            Slides = new List<Photo>();
            foreach (int photoId in SlideShowList)
            {
                // Obtenir la photo 
                Photo photo = PhotoPool.Where(p => p.Id == photoId).First<Photo>();
                if (photo != null)
                    Slides.Add(photo);
            }
            WaitSplash.Hide();
            // Définir l'ordre des photos
            SetPhotosOrder();
            // Démarrer l'horloge
            SlideshowTimer.Start();
        }

        private void Toggle_FullScreen()
        {
            FullScreen = !FullScreen;

            if (FullScreen)
            {
                // Masquer la bordure et l'entête
                this.FormBorderStyle = FormBorderStyle.None;
                // Masquer la barre des menus
                // Agrandir
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void DLG_Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1: ShowHelp(); break;
                case Keys.F11: Toggle_FullScreen(); break;
                case Keys.P: SlideshowTimer.Start(); break;
                case Keys.S: SlideshowTimer.Stop(); break;
                case Keys.R: RandomOrder = !RandomOrder; SetPhotosOrder(); break;
                case Keys.Down: SlideshowTimer.Interval = (SlideshowTimer.Interval < 60000 ? SlideshowTimer.Interval + 250 : SlideshowTimer.Interval); break;
                case Keys.Up: SlideshowTimer.Interval = (SlideshowTimer.Interval > 500 ? SlideshowTimer.Interval - 250 : SlideshowTimer.Interval); break;
                case Keys.Escape: SlideshowTimer.Stop(); Close(); break;
            }
        }
        private void Next()
        {
            if (PhotosOrder.Count() > 0)
            {
                // Régler l'image de fond avec la prochaine photo
                this.BackgroundImage = Slides[PhotosOrder[Current_PhotosOrder_Index]].GetOriginalImage();
                // Index de la prochaine photo. Si était la dernière, revenir à la première
                Current_PhotosOrder_Index = Current_PhotosOrder_Index < Slides.Count - 1 ? Current_PhotosOrder_Index + 1 : 0;
            }
        }
        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            // passer à la prochaine photo
            Next();
        }

        // Mélanger les photos aléatoirement
        private void ShufflePhotosOrder()
        {
            Random rnd = new Random(DateTime.Now.Second);
            int nb_Photos = SlideShowList.Count;
            for (int i = 0; i < nb_Photos - 1; i++)
            {
                int j = rnd.Next((nb_Photos - i - 2)) + i + 1;
                int k = PhotosOrder[i];
                PhotosOrder[i] = PhotosOrder[j];
                PhotosOrder[j] = k;
            }
        }

        // Définir l'ordre des photos
        private void SetPhotosOrder()
        {
            WaitSplash.Show(this, "Setting photo order...");
            Current_PhotosOrder_Index = 0;

            int nb_Photos = SlideShowList.Count;
            PhotosOrder = new int[nb_Photos];
            // Ordre séquentiel
            for (int i = 0; i < nb_Photos; i++)
            {
                PhotosOrder[i] = i;
            }
            if (RandomOrder)
            {
                // Ordre aléatoire
                ShufflePhotosOrder();
            }
            WaitSplash.Hide();
            // Affichier la première photo
            Next();
        }
        private void ShowHelp()
        {
         
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }




        private void SaveSlideShowList()
        {
            if (Properties.Settings.Default.SlideShowList == null)
                Properties.Settings.Default.SlideShowList = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.SlideShowList.Clear();
            if (SlideShowList != null)
                foreach (int photoId in SlideShowList)
                {
                    Properties.Settings.Default.SlideShowList.Add(photoId.ToString());
                }
        }

        private void PageSlideShow_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void TSL_Fullscreen_Click(object sender, EventArgs e)
        {
            Toggle_FullScreen();
            if (TSL_Fullscreen.Text == "Mode plein écran")
            {
                TSL_Fullscreen.Text = "Mode pas plein écran";
            }
            else if(TSL_Fullscreen.Text == "Mode pas plein écran")
            {
                TSL_Fullscreen.Text = "Mode plein écran";
            }
           
        }

        private void TSL_Random_Click(object sender, EventArgs e)
        {
            //RandomOrder = !RandomOrder;
            //SetPhotosOrder();
            //if (TSL_Random.Text == "Ordre aléatoire")
            //{
            //    TSL_Fullscreen.Text = "Ordre pas aléatoire";
            //}
            //else if (TSL_Fullscreen.Text == "Ordre pas aléatoire")
            //{
            //    TSL_Fullscreen.Text = "Ordre aléatoire";
            //}
        }
    }
}
