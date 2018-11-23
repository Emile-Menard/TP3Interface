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
        bool mConnected;
        User mUser;
        PhotoBrowserPlacement mPhotoBrowserPlacement;
        public PagePrincipale()
        {
            InitializeComponent();
            mConnected = false;
            mUser = new PhotoManagerClient.User();
            mPhotoBrowserPlacement = PhotoBrowserPlacement.Left;
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
                mUser = pgConnexion.Logged_User;
                mConnected = true;
                FBTN_Ajouter_MotCle.Enabled = true;
            }

        }

        //----------------------------------------------------------------------------------
        //
        //Gestion de photo
        //
        //----------------------------------------------------------------------------------

        private void AjouterPhoto(object sender, EventArgs e)
        {
            if (mConnected)
            {
                PageGestionPhotos pgPhoto = new PageGestionPhotos(mUser);
                if (pgPhoto.ShowDialog() == DialogResult.OK)
                {
                    photosBrowser1.AddPhoto(pgPhoto.mPhoto);
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
            if (mConnected)
            {
                PageGestionPhotos pgPhoto = new PageGestionPhotos(mUser, photosBrowser1.SelectedPhoto);
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
            if (mConnected)
            {
                //Si la photo appartient à l'utilisateur courant
                if (mUser.Id == photosBrowser1.SelectedPhoto.OwnerId)
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

        
    }
}
