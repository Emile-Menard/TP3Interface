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
        public List<int> SlideShowList { get; set; }
        public List<Photo> PhotoPool { get; set; }

        public PageEditSlideShow()
        {
            InitializeComponent();
            FLPN_Photos.AutoScroll = true;
        }

        private void DLG_ManageSildeShow_Shown(object sender, EventArgs e)
        {
            WaitSplash.Show(this, "Chargement des photos...");
            Load_Photos();
            WaitSplash.Hide();
        }

        private void Load_Photos()
        {
            SuspendLayout();
            foreach (Photo photo in PhotoPool)
            {
                Panel pp = MakePhotoPanel(photo.Id);
                if (pp != null)
                    FLPN_Photos.Controls.Add(pp);
            }
            ResumeLayout();
        }

        private PhotoPanel MakePhotoPanel(int photoId)
        {
            Photo photo = PhotoPool.Where(p => p.Id == photoId).First<Photo>();
            if (photo != null)
            {
                PictureBox pbx = new PictureBox();
                pbx.Size = new Size(80, 80);
                pbx.BackgroundImageLayout = ImageLayout.Zoom;
                pbx.BackgroundImage = photo.GetThumbnailImage();
                pbx.Location = new Point(10, 10);
                pbx.Click += PBX_Click;

                PhotoPanel photoPanel = new PhotoPanel();
                photoPanel.Size = new Size(100, 100);
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
            string stringId = PPN.Name.Substring(PPN.Name.IndexOf("_") + 1);
            int photoId = int.Parse(stringId);
            AddRemove_SlideShow(photoId);
            PPN.Selected = InSlideShow(photoId);
            PPN.Refresh();
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            PhotoPanel PPN = (PhotoPanel)sender;
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

        private void AddRemove_SlideShow(int photoId)
        {
            int index = SlideShowList.IndexOf(photoId);
            if (index == -1)
                SlideShowList.Add(photoId);
            else
                SlideShowList.RemoveAt(index);
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ReinitCarousel_Click(object sender, EventArgs e)
        {
            SlideShowList.Clear();
            this.Close();

        }

        private void PageEditSlideShow_Load(object sender, EventArgs e)
        {


            this.Location = Properties.Settings.Default.LocationPageEditCarousel;

        }

        private void PageEditSlideShow_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.LocationPageEditCarousel = this.Location;

            Properties.Settings.Default.Save();
        }
    }
}
