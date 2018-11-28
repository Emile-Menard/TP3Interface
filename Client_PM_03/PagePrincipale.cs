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

    public partial class PagePrincipale : Form
    {
        //Bool qui permet de savoir si on est connecté pour permettre certaines opérations
        User LoggedUser = null;
        PhotoBrowserPlacement mPhotoBrowserPlacement;
        PhotoFilter mPhotoFilter;
        //List<int> mBlackListedUsers;
        //List<Photo> mPhotos;
        public PagePrincipale()
        {
            InitializeComponent();
            mPhotoBrowserPlacement = PhotoBrowserPlacement.Left;
            Update_MotsCles();
            // mPhotos = DBPhotosWebServices.GetAllPhotos().Where(p => mBlackListedUsers.IndexOf(p.OwnerId) == -1).ToList();

        }

        //----------------------------------------------------------------------------------
        //
        //Compte
        //
        //----------------------------------------------------------------------------------

        private void TLSTRIP_Connexion_Click(object sender, EventArgs e)
        {
            PageConnexion pgConnexion = new PageConnexion();
            if (pgConnexion.ShowDialog() == DialogResult.OK)
            {
                LoggedUser = pgConnexion.Logged_User;
                FilterInit();
                LoadDataLogin();
            }

        }
        //----------------------------------------------------------------------------------
        //
        //Photo browser
        //
        //----------------------------------------------------------------------------------
        private void Update_Photo_Browser()
        {
            photosBrowser1.Clear();
            WaitSplash.Show(this, "Téléchargement des photos");
            photosBrowser1.LoadPhotos(mPhotoFilter.GetPhotos());
            WaitSplash.Hide();
        }

        //----------------------------------------------------------------------------------
        //
        //Gestion de photo
        //
        //----------------------------------------------------------------------------------

        private void AjouterPhoto(object sender, EventArgs e)
        {
            if (LoggedUser.Exists())
            {
                PageGestionPhotos pgPhoto = new PageGestionPhotos(LoggedUser);
                if (pgPhoto.ShowDialog() == DialogResult.OK)
                {
                    Update_Photo_Browser();
                    Update_MotsCles();
                    photosBrowser1.SelectedPhoto = pgPhoto.mPhoto;
                    MessageBox.Show("Photo ajoutée avec succès!");
                }
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }
            
        }

        private void ModifierPhoto()
        {
            if (LoggedUser != null)
            {
                if(photosBrowser1.SelectedPhoto != null)
                {
                    //S'il y a une photo sélectionnée et si la photo appartient à l'utilisateur courant
                    if (LoggedUser.Id == photosBrowser1.SelectedPhoto.OwnerId)
                    {
                        PageGestionPhotos pgPhoto = new PageGestionPhotos(LoggedUser, photosBrowser1.SelectedPhoto);
                        if (pgPhoto.ShowDialog() == DialogResult.OK)
                        {
                            Update_Photo_Browser();
                            Update_MotsCles();

                            photosBrowser1.SelectedPhoto = pgPhoto.mPhoto;
                            MessageBox.Show("Photo modifiée avec succès!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous ne pouvez pas effacer cette photo! (elle appartient à quelqu'un d'autre)");
                    }
                }
                else
                {
                    MessageBox.Show("Aucune photo n'est sélectionnée");
                }

            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }
        }

        private void EffacerPhoto()
        {
            if (LoggedUser.Exists())
            {
                //Si la photo appartient à l'utilisateur courant
                if (LoggedUser.Id == photosBrowser1.SelectedPhoto.OwnerId)
                {
                    var confirmer = MessageBox.Show("Êtes-vous certain de vouloir effacer cette photo?", "Confirmation", MessageBoxButtons.YesNo);
                    if (confirmer == DialogResult.Yes)
                    {
                        DBPhotosWebServices.DeletePhoto(photosBrowser1.SelectedPhoto);
                        photosBrowser1.DeleteSelectedPhoto();
                        Update_MotsCles();
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas effacer cette photo! (elle appartient à quelqu'un d'autre)");
                }
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }
            
        }

        //----------------------------------------------------------------------------------
        //
        //Mots-Clés
        //
        //----------------------------------------------------------------------------------
        private void Update_MotsCles()
        {
            if(LoggedUser.Exists())
            {
                

                AutoCompleteStringCollection motsCles = new AutoCompleteStringCollection();
                mPhotoFilter.GetPhotos();

                foreach (string keyword in mPhotoFilter.KeywordsList)
                {
                    motsCles.Add(keyword);
                }

                TBX_MotsCles.AutoCompleteCustomSource = motsCles;
            }
        }

        private void FBTN_Ajouter_MotCle_Click(object sender, EventArgs e)
        {
            if (TBX_MotsCles.Text != "")
            {
                LBX_MotsCles.Items.Add(TBX_MotsCles.Text);
                TBX_MotsCles.Clear();
                Update_PhotoFilter_And_PhotoBrowser();
            }

        }

        private void FBTN_EffacerMotCle_Click(object sender, EventArgs e)
        {
            if(LBX_MotsCles.SelectedItem != null)
            {
                LBX_MotsCles.Items.Remove(LBX_MotsCles.SelectedItem);
                Update_PhotoFilter_And_PhotoBrowser();
            }
           
            
        }

        private void UserComboBox()
        {
            foreach (User user in mPhotoFilter.UsersList)
            {
                if (user.Name != null)
                    CMB_UsersList.Items.Add(user);
            }
            CMB_UsersList.SelectedIndex = 0;
        }

        private void CBX_MotsCles_CheckedChanged(object sender, EventArgs e)
        {
            Update_PhotoFilter_And_PhotoBrowser();
        }
        private void Update_PhotoFilter_And_PhotoBrowser()
        {
            mPhotoFilter.SetKeywordsFilter(CBX_MotsCles.Checked, GenericMethods.ListBoxToString(LBX_MotsCles));
            Update_Photo_Browser();
        }

       

        //----------------------------------------------------------------------------------
        //
        //Mise en page
        //
        //----------------------------------------------------------------------------------
        private void RotationMiseEnPage()
        {
            if (mPhotoBrowserPlacement == PhotoBrowserPlacement.Left)
            {
                mPhotoBrowserPlacement = PhotoBrowserPlacement.Bottom;
            }
            else if (mPhotoBrowserPlacement == PhotoBrowserPlacement.Bottom)
            {
                mPhotoBrowserPlacement = PhotoBrowserPlacement.Right;
            }
            else if (mPhotoBrowserPlacement == PhotoBrowserPlacement.Right)
            {
                mPhotoBrowserPlacement = PhotoBrowserPlacement.Top;
            }
            else if (mPhotoBrowserPlacement == PhotoBrowserPlacement.Top)
            {
                mPhotoBrowserPlacement = PhotoBrowserPlacement.Left;
            }
            else
            {
                mPhotoBrowserPlacement = PhotoBrowserPlacement.Left;
            }

            photosBrowser1.Placement = mPhotoBrowserPlacement;

        }

        //----------------------------------------------------------------------------------
        //
        //Évènements
        //
        //----------------------------------------------------------------------------------

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AjouterPhoto(sender, e);
        }
        private void FBTN_Ajouter_Click(object sender, EventArgs e)
        {
             AjouterPhoto(sender, e);
        }

        private void FBTN_Modifier_Click(object sender, EventArgs e)
        {
            ModifierPhoto();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierPhoto();
        }

        private void FTBN_Effacer_Click(object sender, EventArgs e)
        {
            EffacerPhoto();
        }

        private void effacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EffacerPhoto();
        }

        private void FBTN_MiseEnPage_Click(object sender, EventArgs e)
        {
            RotationMiseEnPage();
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotationMiseEnPage();
        }

        private void ToggleUserStripOptions()
        {
            TLSTRIP_Editer.Enabled = LoggedUser.Exists();
            TLSTRIP_Cree.Enabled = !LoggedUser.Exists();
            TLSTRIP_Deconnexion.Enabled = LoggedUser.Exists();
            TLSTRIP_Connexion.Enabled = !LoggedUser.Exists();
        }

        private void TLSTRIP_Editer_Click(object sender, EventArgs e)
        {
            PageGestionUser pgEditerCompte = new PageGestionUser();
            pgEditerCompte.User = LoggedUser;
            if (pgEditerCompte.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TLSTRIP_Cree_Click(object sender, EventArgs e)
        {
            PageGestionUser pgCreation = new PageGestionUser();
            if (pgCreation.ShowDialog() == DialogResult.OK)
            {
               LoggedUser = pgCreation.User;
                ToggleUserStripOptions();
            }
        }

        private void TLSTRIP_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void TLSTRIP_Deconnexion_Click(object sender, EventArgs e)
        {
            LoggedUser = null;
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();
            CMB_UsersList.Items.Clear();
            photosBrowser1.Clear();
            ToggleUserStripOptions();
        }

        private void PagePrincipale_Load_1(object sender, EventArgs e)
        {
            Load_Settings();
            ToggleUserStripOptions();
            if(LoggedUser.Exists())
            {
                UserComboBox();
            }

        }

        private void Load_Settings()
        {
            if (Properties.Settings.Default.RememberMe)
            {
               var RememberMe = Properties.Settings.Default.RememberMe;
               if(RememberMe)
                {
                    User user = DBPhotosWebServices.Login(Properties.Settings.Default.Username, Properties.Settings.Default.Password);
                    if (user.Exists()) {
                        LoggedUser = user;
                        FilterInit();
                        LoadDataLogin();
                        CBOX_NotMine.Checked = Properties.Settings.Default.NotMyPhoto;
                       
                    }
                }
            }
        }


        private void FilterInit()
        {
            mPhotoFilter = new PhotoFilter(LoggedUser.Id);
        }

        private void LoadDataLogin()
        {
            mPhotoFilter.SetUserFilter(false, false, 0);
            Update_MotsCles();
            UserComboBox();
            ToggleUserStripOptions();
        }

        private void CMB_UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {

            updateSelectedUser();

            Update_Photo_Browser();
        }

        private void CBOX_NotMine_CheckedChanged(object sender, EventArgs e)
        {
            if(LoggedUser.Exists())
            {
            Properties.Settings.Default.NotMyPhoto = CBOX_NotMine.Checked;
            Properties.Settings.Default.Save();
            updateSelectedUser();
            Update_Photo_Browser();
            }
        }


        private void updateSelectedUser()
        {
            User selectedUser = (User)CMB_UsersList.SelectedItem;
            if (selectedUser.Id == -1)
            {

                mPhotoFilter.SetUserFilter(Properties.Settings.Default.NotMyPhoto, false, 0);

            }
            else
            {
                if (selectedUser.Id == 0)
                {
                    mPhotoFilter.SetUserFilter(!Properties.Settings.Default.NotMyPhoto, true, 0);
                }
                else if(CBOX_NotMine.Checked)
                {
                    mPhotoFilter.SetUserFilter(Properties.Settings.Default.NotMyPhoto, false, selectedUser.Id);
                }
                else if (!CBOX_NotMine.Checked)
                {
                    mPhotoFilter.SetUserFilter(false, false, selectedUser.Id);
                }
            }
            Update_MotsCles();
        }

        
    }
}
