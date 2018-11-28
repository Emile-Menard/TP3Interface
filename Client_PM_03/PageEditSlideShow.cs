using PhotoManagerClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class PageEditSlideShow : Form
    {
        // Liste des id des photos incluses dans le diaporama
        public List<int> SlideShowList { get; set; }

        // Liste de toutes les photos éligibles au diaporama
        public List<Photo> PhotoPool { get; set; }

        public PageEditSlideShow()
        {
            InitializeComponent();
            FLPN_Photos.AutoScroll = true;
        }

        private void DLG_ManageSildeShow_Shown(object sender, EventArgs e)
        {
            WaitSplash.Show(this, "Loading photos...");
            Load_Photos();
            WaitSplash.Hide();
        }

        // Ajouter les images des photos dans le layout
        private void Load_Photos()
        {
            // Suspendre la mise à jour 
            SuspendLayout();
            foreach (Photo photo in PhotoPool)
            {
                Panel pp = MakePhotoPanel(photo.Id);
                if (pp != null)
                    FLPN_Photos.Controls.Add(pp);
            }
            // Reprendre la mise à jour
            ResumeLayout();
        }

        // Construire un panneaux de photo sélectionnable
        private PhotoPanel MakePhotoPanel(int photoId)
        {
            //Photo photo = DBPhotosWebServices.GetPhoto(photoId);
            Photo photo = PhotoPool.Where(p => p.Id == photoId).First<Photo>();
            if (photo != null)
            {
                // Boîte d'image
                PictureBox pbx = new PictureBox();
                pbx.Size = new Size(80, 80);
                pbx.BackgroundImageLayout = ImageLayout.Zoom;
                pbx.BackgroundImage = photo.GetThumbnailImage();
                pbx.Location = new Point(10, 10);
                pbx.Click += PBX_Click;

                // panneaux de photo sélectionnable
                PhotoPanel photoPanel = new PhotoPanel();
                photoPanel.Size = new Size(100, 100);
                // Définir son nom en incluant le id de la photo 
                // permettant ainsi de retrouver la photo concernée par un clic
                photoPanel.Name = "PN_" + photoId.ToString();
                photoPanel.Click += Photo_Click;
                photoPanel.Selected = InSlideShow(photoId);
                photoPanel.Controls.Add(pbx);

                return photoPanel;
            }
            return null;
        }

        private void PBX_Click(object sender, EventArgs e)
        {
            PictureBox PBX = (PictureBox)sender;
            PhotoPanel PPN = PBX.Parent as PhotoPanel;
            // Extraire le id de la photo concernée
            string stringId = PPN.Name.Substring(PPN.Name.IndexOf("_") + 1);
            int photoId = int.Parse(stringId);
            AddRemove_SlideShow(photoId);
            PPN.Selected = InSlideShow(photoId);
            PPN.Refresh();
        }

        // Gestionnaire est utile dans le cas ou le clic aurait lieu à l'extérieur de la boîte de photo
        // mais à l'intérieur de son panneau
        private void Photo_Click(object sender, EventArgs e)
        {
            PhotoPanel PPN = (PhotoPanel)sender;
            // Extraire le id de la photo concernée
            string stringId = PPN.Name.Substring(PPN.Name.IndexOf("_") + 1);
            int photoId = int.Parse(stringId);
            AddRemove_SlideShow(photoId);
            PPN.Selected = InSlideShow(photoId);
            PPN.Refresh();
        }

        private bool InSlideShow(int photoId)
        {
            return SlideShowList.IndexOf(photoId) != -1;
        }

        // Ajouter ou retirer l'index de photo
        private void AddRemove_SlideShow(int photoId)
        {
            int index = SlideShowList.IndexOf(photoId);
            if (index == -1)
                SlideShowList.Add(photoId);
            else
                SlideShowList.RemoveAt(index);
        }
    }
}
