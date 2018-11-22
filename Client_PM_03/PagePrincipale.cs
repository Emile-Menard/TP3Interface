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
    public partial class PagePrincipale : Form
    {
        //Bool qui permet de savoir si on est connecté pour permettre certaines opérations
       // bool mConnected;
        //PhotoManagerClient.User mUser;
        public PagePrincipale()
        {
            InitializeComponent();
            //mConnected = false;
            //mUser = new PhotoManagerClient.User();
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
                //to do retourner le user
                //mConnected = true;
                //FBTN_Ajouter.Enabled = true;
            }

        }

        //----------------------------------------------------------------------------------
        //
        //Gestion de photo
        //
        //----------------------------------------------------------------------------------

        private void AjouterPhoto(object sender, EventArgs e)
        {
            PageGestionPhotos pgPhoto = new PageGestionPhotos(/*mUser*/);
            if (pgPhoto.ShowDialog() == DialogResult.OK)
            {
                //to do
                //update photobrowser
                MessageBox.Show("Photo ajoutée avec succès!");
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // if (mConnected)
            //{
                AjouterPhoto(sender, e);
           // }
        }
        private void FBTN_Ajouter_Click(object sender, EventArgs e)
        {
            //if (mConnected)
            //{
                AjouterPhoto(sender, e);
            //}
        }
    }
}
