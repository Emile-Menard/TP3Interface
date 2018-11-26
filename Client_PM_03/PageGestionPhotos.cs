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
using Validation;

namespace Client_PM
{
    public partial class PageGestionPhotos : Form
    {
        const string MODE_MODIFIER = "Modifier";
        public User mUser;
        public Photo mPhoto;
        private  AutoCompleteStringCollection mMotsCles;
        private PhotoFilter mPhotoFilter;
        private ValidationProvider mValidationProvider;
        
        public PageGestionPhotos(User user)
        {
            InitializeComponent();
            Init_Ajouter(user);
            Init_Dialogue();
        }

        public PageGestionPhotos(User user, Photo photo)
        {
            InitializeComponent();
            Init_Modifier(user, photo);
            Init_Dialogue();
        }

        //----------------------------------------------------------------------------------
        //
        //Initialisation
        //
        //----------------------------------------------------------------------------------
        private void Init_Ajouter(User user)
        {
            mUser = user;
            mPhoto = new Photo();
        }

        private void Init_Modifier(User user, Photo photo)
        {
            mUser = user;
            mPhoto = photo;
            this.Text = "Modifier une photo";
            BTN_Ajouter.Text = MODE_MODIFIER;
            PhotoToDialog();
        }

        private void Init_Dialogue()
        {
            if(mUser != null)
            {
                mMotsCles = new AutoCompleteStringCollection();
                mPhotoFilter = new PhotoFilter(mUser.Id);
                mPhotoFilter.SetUserFilter(false, true, 0);
                Init_MotsCles();
                Init_IB_Image();
                mValidationProvider = new ValidationProvider(this);
            }
        }

        private void Init_IB_Image()
        {
            if(mPhoto != null)
            {
                IB_Image.BackgroundImage = mPhoto.GetOriginalImage();
            }
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

        //----------------------------------------------------------------------------------
        //
        //Validation
        //
        //----------------------------------------------------------------------------------

        private bool Valider_TBX_Titre(ref string message)
        {
            message = "Le titre de la photo est absent";
            return TBX_Titre.Text != "";

        }

        private bool Valider_IB_Image(ref string message)
        {
            message = "Il n'y a aucune photo";
            return IB_Image.BackgroundImage != null;
            
        }

        //----------------------------------------------------------------------------------
        //
        //Mots-clés
        //
        //----------------------------------------------------------------------------------

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

        //----------------------------------------------------------------------------------
        //
        //Image
        //
        //----------------------------------------------------------------------------------

        private Image RotaterImage(Image source)
        {
            Image rotated = (Image)source.Clone();
            rotated.RotateFlip(RotateFlipType.Rotate270FlipNone);
            source.Dispose();
            return rotated;
        }

        //----------------------------------------------------------------------------------
        //
        //DialogToPhoto, PhotoToDialog
        //
        //----------------------------------------------------------------------------------

        private void DialogToPhotoCreate()
        {
            mPhoto.Title = TBX_Titre.Text;
            mPhoto.CreationDate = DTP_Date.Value;
            mPhoto.Description = RTB_Description.Text;
            if(LBX_MotsCles.Items.Count > 0)
            {
                mPhoto.Keywords = string.Join(" ", LBX_MotsCles.Items);
            }
            mPhoto.Shared = CBX_Partager.Checked;
            mPhoto.SetImage(IB_Image.BackgroundImage);
            mPhoto.OwnerId = mUser.Id;
            mPhoto = DBPhotosWebServices.CreatePhoto(mPhoto);
        }

        private void DialogToPhotoUpdate()
        {
            mPhoto.Title = TBX_Titre.Text;
            mPhoto.CreationDate = DTP_Date.Value;
            mPhoto.Description = RTB_Description.Text;
            if (LBX_MotsCles.Items.Count > 0)
            {
                mPhoto.Keywords = string.Join(" ", LBX_MotsCles.Items);
            }
            mPhoto.Shared = CBX_Partager.Checked;
            mPhoto.SetImage(IB_Image.BackgroundImage);
            mPhoto.OwnerId = mUser.Id;
            mPhoto = DBPhotosWebServices.UpdatePhoto(mPhoto);
        }

        private void PhotoToDialog()
        {
            TBX_Titre.Text = mPhoto.Title;
            DTP_Date.Value =  mPhoto.CreationDate;
            RTB_Description.Text = mPhoto.Description;
            if(mPhoto.Keywords == "")
            {
                LBX_MotsCles.Items.AddRange(mPhoto.Keywords.Split(' ').ToArray());
            }
            CBX_Partager.Checked = mPhoto.Shared;
            IB_Image.BackgroundImage = mPhoto.GetOriginalImage();
        }

        //----------------------------------------------------------------------------------
        //
        //Évènements
        //
        //----------------------------------------------------------------------------------
        private void PageGestionPhotos_Load(object sender, EventArgs e)
        {
            mValidationProvider.AddControlToValidate(TBX_Titre, Valider_TBX_Titre);
            mValidationProvider.AddControlToValidate(IB_Image, Valider_IB_Image);
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

        private void FBTN_EffacerMotCle_Click(object sender, EventArgs e)
        {
            RetirerMotCle();
        }

        private void FTBN_Rotation_Click(object sender, EventArgs e)
        {
            if(IB_Image.BackgroundImage != null)
            {
                IB_Image.BackgroundImage = RotaterImage(IB_Image.BackgroundImage);
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            if(BTN_Ajouter.Text == MODE_MODIFIER)
            {
                DialogToPhotoUpdate();
            }
            else
            {
                DialogToPhotoCreate();
            }
           
        }


    }
}
