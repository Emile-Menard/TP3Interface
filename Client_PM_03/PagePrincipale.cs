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
        //List<int> mBlackListedUsers;
        //List<Photo> mPhotos;
        public PagePrincipale()
        {
            InitializeComponent();
            mPhotoBrowserPlacement = PhotoBrowserPlacement.Left;
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
                FBTN_Ajouter_MotCle.Enabled = true;
                ToggleUserStripOptions();
                Update_Photo_Browser();
            }

        }
        //----------------------------------------------------------------------------------
        //
        //Photo browser
        //
        //----------------------------------------------------------------------------------
        private void Update_Photo_Browser()
        {
            WaitSplash.Show(this, "Téléchargement des photos");
            photosBrowser1.LoadPhotos(DBPhotosWebServices.GetAllPhotos());
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
                    
                    //pgPhoto.mPhoto.
                    //photosBrowser1.AddPhoto(pgPhoto.mPhoto);
                    Update_Photo_Browser();
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
                PageGestionPhotos pgPhoto = new PageGestionPhotos(LoggedUser, photosBrowser1.SelectedPhoto);
                if (pgPhoto.ShowDialog() == DialogResult.OK)
                {
                    photosBrowser1.SelectedPhoto = pgPhoto.mPhoto;
                    MessageBox.Show("Photo modifiée avec succès!");
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
                        photosBrowser1.DeleteSelectedPhoto();
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

        private void FTBN_Effacer_Click(object sender, EventArgs e)
        {
            EffacerPhoto();
        }

        private void FBTN_MiseEnPage_Click(object sender, EventArgs e)
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

        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            ToggleUserStripOptions();
        }

        private void TLSTRIP_Deconnexion_Click(object sender, EventArgs e)
        {
            LoggedUser = null;
            ToggleUserStripOptions();
        }

        private void PagePrincipale_Load_1(object sender, EventArgs e)
        {
            Load_Settings();
            ToggleUserStripOptions();
            if(LoggedUser.Exists())
            {
                Update_Photo_Browser();
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
                    }
                }
            }
        }

        private void photosBrowser1_SelectedChanged(object sender, EventArgs e)
        {

        }
    }
}
