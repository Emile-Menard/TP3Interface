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
    public partial class PageGestionPhotos : Form
    {
        User mUser;
        AutoCompleteStringCollection mMotsCles;
        PhotoFilter mPhotoFilter;
        public PageGestionPhotos(User user)
        {
            InitializeComponent();
            mUser = user;
            mMotsCles = new AutoCompleteStringCollection();
            mPhotoFilter = new PhotoFilter(mUser.Id);
            mPhotoFilter.SetUserFilter(false, true, 0);
            Init_MotsCles();
        }

        private void Init_MotsCles()
        {
            
            mPhotoFilter.GetPhotos();
            foreach (string keyword in mPhotoFilter.KeywordsList)
            {
                mMotsCles.Add(keyword);
            }
            TBX_MotsCles.AutoCompleteCustomSource = mMotsCles;
        }

        private void AjouterMotCle()
        {
            if(TBX_MotsCles.Text != "")
            {
                LBX_MotsCles.Items.Add(TBX_MotsCles.Text);
                TBX_MotsCles.Clear();
            }
           
        }

        private void RetirerMotCle()
        {
            LBX_MotsCles.Items.Remove(LBX_MotsCles.SelectedItem);
        }

        //private void TBX_MotsCles_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(e.KeyChar == (char)Keys.Enter)
        //    {
        //        AjouterMotCle();
        //    }
        //}

        private void FBTN_AjouterMotCle_Click(object sender, EventArgs e)
        {
            AjouterMotCle();
        }

        private void LBX_MotsCles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                RetirerMotCle();
            }
        }
    }
}
