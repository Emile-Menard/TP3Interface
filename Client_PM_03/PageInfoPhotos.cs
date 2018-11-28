using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoManagerClient;

namespace Client_PM
{
    public partial class PageInfoPhotos : Form
    {
        public PageInfoPhotos(Photo photo)
        {
            InitializeComponent();
            infos.Text = "par " + DBPhotosWebServices.GetUser(photo.OwnerId) + ", " + photo.GetOriginalImage().Width + " x " + photo.GetOriginalImage().Height;
            TBX_Titre.Text = photo.Title;
            DTP_Date.Value = photo.CreationDate;
            RTB_Description.Text = photo.Description;
            if (photo.Keywords != "")
            {
                LBX_MotsCles.Items.AddRange(photo.Keywords.Split(' ').ToArray());
            }
            CBX_Partager.Checked = photo.Shared;
            IB_Image.BackgroundImage = photo.GetOriginalImage();
        }
    }
}
