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
        List<Photo> mPhotos;
        AutoCompleteStringCollection mMotsCles;
        public PageGestionPhotos(User user = null)
        {
            InitializeComponent();
            mUser = user;
            mPhotos = DBPhotosWebServices.GetAllPhotos();
            mMotsCles = new AutoCompleteStringCollection();
            Init_MotsCles();
        }

        private void Init_MotsCles()
        {
            //List<string> motsCles;
            foreach (Photo photo in mPhotos)
            {
                //To do bâtir une liste de keyword
                //motsCles = String.split(photo.Keywords);
                //mMotsCles.Add(photo.Keywords);
            }
            TBX_MotsCles.AutoCompleteCustomSource = mMotsCles;
        }

        private void TBX_MotsCles_TextChanged(object sender, EventArgs e)
        {


        }

        
    }
}
