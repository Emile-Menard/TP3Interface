﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using PhotoManagerClient;

namespace Client_PM
{

    public partial class PagePrincipale : Form
    {

        private List<Photo> photos = new List<Photo>();
        private List<int> SlideShowList = new List<int>();
        //Bool qui permet de savoir si on est connecté pour permettre certaines opérations
        User LoggedUser = null;
        PhotoBrowserPlacement mPhotoBrowserPlacement;
        PhotoFilter mPhotoFilter;
        ArrayList mBlackListedUsers;

        Point mPointListeNoire;

        //List<Photo> mPhotos;
        public PagePrincipale()
        {
            InitializeComponent();
            mPhotoBrowserPlacement = PhotoBrowserPlacement.Left;
            Update_MotsCles();
            mBlackListedUsers = new ArrayList();


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
            photosBrowser.Clear();
            WaitSplash.Show(this, "Téléchargement des photos");

            photosBrowser.LoadPhotos(mPhotoFilter.GetPhotos().Where(p => mBlackListedUsers.IndexOf(p.OwnerId) == -1).ToList());

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
                    photosBrowser.SelectedPhoto = pgPhoto.mPhoto;
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
                if(photosBrowser.SelectedPhoto != null)
                {
                    //S'il y a une photo sélectionnée et si la photo appartient à l'utilisateur courant
                    if (LoggedUser.Id == photosBrowser.SelectedPhoto.OwnerId)
                    {
                        PageGestionPhotos pgPhoto = new PageGestionPhotos(LoggedUser, photosBrowser.SelectedPhoto);
                        if (pgPhoto.ShowDialog() == DialogResult.OK)
                        {
                            Update_Photo_Browser();
                            Update_MotsCles();

                            photosBrowser.SelectedPhoto = pgPhoto.mPhoto;
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
                if (photosBrowser.SelectedPhoto != null)
                {
                    //Si la photo appartient à l'utilisateur courant
                    if (LoggedUser.Id == photosBrowser.SelectedPhoto.OwnerId)
                    {
                        var confirmer = MessageBox.Show("Êtes-vous certain de vouloir effacer cette photo?", "Confirmation", MessageBoxButtons.YesNo);
                        if (confirmer == DialogResult.Yes)
                        {
                            DBPhotosWebServices.DeletePhoto(photosBrowser.SelectedPhoto);
                            photosBrowser.DeleteSelectedPhoto();
                            Update_MotsCles();
                            MessageBox.Show("Photo effacée avec succès!");
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

            AjouterMotCle();
        }

        private void TBX_MotsCles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AjouterMotCle();
            }
                
        }

        private void AjouterMotCle()
        {
            if (TBX_MotsCles.Text != "")
            {
                if (LoggedUser.Exists())
                {
                    LBX_MotsCles.Items.Add(TBX_MotsCles.Text);
                    TBX_MotsCles.Clear();
                    Update_PhotoFilter_And_PhotoBrowser();
                }
                else
                {
                    MessageBox.Show("Veuillez vous connecter!");
                }

            }
        }

        private void FBTN_EffacerMotCle_Click(object sender, EventArgs e)
        {
          
            EffacerMotCle();            
        }

        private void LBX_MotsCles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                 EffacerMotCle();
            }
               
        }

        private void EffacerMotCle()
        {
            if (LBX_MotsCles.SelectedItem != null)
            {
                LBX_MotsCles.Items.Remove(LBX_MotsCles.SelectedItem);
                Update_PhotoFilter_And_PhotoBrowser();
            }
            else
            {
                MessageBox.Show("Aucun mot-clé n'est sélectionné");
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
            if(LoggedUser.Exists())
            Update_PhotoFilter_And_PhotoBrowser();
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }
        }
        private void Update_PhotoFilter_And_PhotoBrowser()
        {
            mPhotoFilter.SetKeywordsFilter(CBX_MotsCles.Checked, GenericMethods.ListBoxToString(LBX_MotsCles));
            Update_Photo_Browser();
        }

        //----------------------------------------------------------------------------------
        //
        //Date
        //
        //----------------------------------------------------------------------------------


        private void CBX_Date_CheckedChanged(object sender, EventArgs e)
        {
            if(LoggedUser.Exists())
            Update_DateFilter();
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }
        }


        private void DTP_Debut_ValueChanged(object sender, EventArgs e)
        {
            Update_DateFilter();
        }

        private void DTP_Fin_ValueChanged(object sender, EventArgs e)
        {
            Update_DateFilter();
        }
        private void Update_DateFilter()
        {
            if(LoggedUser.Exists())
            {
                mPhotoFilter.SetDateFilter(CBX_Date.Checked, DTP_Debut.Value, DTP_Fin.Value);
                Update_Photo_Browser();
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

            photosBrowser.Placement = mPhotoBrowserPlacement;

        }

        //----------------------------------------------------------------------------------
        //
        //Liste noire
        //
        //----------------------------------------------------------------------------------
        private void listeNoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoggedUser.Exists())
            {
               PageListeNoire pg = new PageListeNoire(mBlackListedUsers, LoggedUser);
                if (pg.ShowDialog() == DialogResult.OK)
                {
                    mBlackListedUsers = pg.mListeNoire;
                    Update_Photo_Browser();
                    Update_MotsCles();
                    UpdatePhotoPool();
                   
                    mPointListeNoire = pg.Location;
                    MessageBox.Show("Liste noire modifiée avec succès");
                }
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }
        }


        private void UpdatePhotoPool()
        {

            photos = DBPhotosWebServices.GetAllPhotos().Where(p => mBlackListedUsers.IndexOf(p.OwnerId) == -1).ToList();
            List<Photo> tempPhotos  = DBPhotosWebServices.GetAllPhotos().Where(p => SlideShowList.Contains(p.Id) && mBlackListedUsers.IndexOf(p.OwnerId) == -1).ToList();
            List<int> tempsInts = new List<int>();
            foreach (Photo p in tempPhotos)
                tempsInts.Add(p.Id);

            SlideShowList = tempsInts;

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


        //----------------------------------------------------------------------------------
        //
        //Éditer compte
        //
        //----------------------------------------------------------------------------------

        private void EditerCompte()
        {
            PageGestionUser pgEditerCompte = new PageGestionUser();
            pgEditerCompte.User = LoggedUser;
            if (pgEditerCompte.ShowDialog() == DialogResult.OK)
            {

            }
        } 
        private void TLSTRIP_Editer_Click(object sender, EventArgs e)
        {
            EditerCompte();
        }

        private void IMB_UserAvatar_Click(object sender, EventArgs e)
        {
            if(LoggedUser.Exists())
            {
                EditerCompte();
            }
            else
            {
                CreerCompte();
            }
            
        }

        //----------------------------------------------------------------------------------
        //
        //Creer
        //
        //----------------------------------------------------------------------------------

        private void CreerCompte()
        {
            PageGestionUser pgCreation = new PageGestionUser();
            if (pgCreation.ShowDialog() == DialogResult.OK)
            {
                LoggedUser = pgCreation.User;
                ToggleUserStripOptions();
                FilterInit();
                LoadDataLogin();
                UpdatePhotoPool();
            }
        }

        private void TLSTRIP_Cree_Click(object sender, EventArgs e)
        {
            CreerCompte();
        }

        //----------------------------------------------------------------------------------
        //
        //Quitter
        //
        //----------------------------------------------------------------------------------


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
            photosBrowser.Clear();
            ToggleUserStripOptions();
            UnloadUserData();
            SlideShowList.Clear();
            Properties.Settings.Default.Reset();
        }

        //----------------------------------------------------------------------------------
        //
        //Load / Leave
        //
        //----------------------------------------------------------------------------------

        private void PagePrincipale_Load_1(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.RememberMe)
            {
                Properties.Settings.Default.Reset();
            }else
            {
                this.Location = Properties.Settings.Default.PosPagePrincipale;
            }
            Load_Settings();
            if (!Properties.Settings.Default.FirstInit && Properties.Settings.Default.RememberMe)
            {
                LoadSlideShowList();
                
                this.Size = Properties.Settings.Default.DimensionPagePrincipale;
           
                
                mPhotoBrowserPlacement = Init_miseEnPage();
               
                if (Properties.Settings.Default.Blacklist != null)
                {
                    mBlackListedUsers = Properties.Settings.Default.Blacklist;
                    UpdatePhotoPool();
                }
                else
                {
                    mBlackListedUsers = new ArrayList();
                }


            }
            else
            {
                SlideShowList = new List<int>();
                
            }


          

            photos = DBPhotosWebServices.GetAllPhotos();
            UpdatePhotoPool();
            ToggleUserStripOptions();
            if(LoggedUser.Exists())
            {
                UserComboBox(); 
            }
            photosBrowser.Placement = mPhotoBrowserPlacement;

        }

        //Retourne 
        private PhotoBrowserPlacement Init_miseEnPage()
        {
            PhotoBrowserPlacement placement = PhotoBrowserPlacement.Left;
            string placementStr = Properties.Settings.Default.MiseEnPage;
            if(placementStr == PhotoBrowserPlacement.Right.ToString())
            {
                placement = PhotoBrowserPlacement.Right;
            }
            else if (placementStr == PhotoBrowserPlacement.Top.ToString())
            {
                placement = PhotoBrowserPlacement.Top;
            }
            else if (placementStr == PhotoBrowserPlacement.Bottom.ToString())
            {
                placement = PhotoBrowserPlacement.Bottom;
            }
            return placement;
        }

        private void PagePrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                Properties.Settings.Default.DimensionPagePrincipale = this.Size;
              
                Properties.Settings.Default.PosPagePrincipale = this.Location;
                Properties.Settings.Default.Blacklist = mBlackListedUsers;
                Properties.Settings.Default.MiseEnPage = photosBrowser.Placement.ToString();
                Properties.Settings.Default.PosListeNoire = mPointListeNoire;
                Properties.Settings.Default.Save();
            }
        }

        private void Load_Settings()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                User user = DBPhotosWebServices.Login(Properties.Settings.Default.Username, Properties.Settings.Default.Password);
                if (user.Exists())
                {
                    LoggedUser = user;
                    FilterInit();
                    LoadDataLogin();
          
                    CBOX_NotMine.Checked = Properties.Settings.Default.NotMyPhoto;

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
            LoadUserData();
        }

        private void LoadUserData()
        {
            IMB_UserAvatar.BackgroundImage = LoggedUser.GetAvatarOriginalImage();
            Username.Text = LoggedUser.Name;
        }

        private void UnloadUserData()
        {
            Username.Text = "Aucun utilisateur connecté";
            IMB_UserAvatar.BackgroundImage = null;
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
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
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
                    mPhotoFilter.SetUserFilter(Properties.Settings.Default.NotMyPhoto, true, 0);
                }
                else
                {
                    mPhotoFilter.SetUserFilter(!Properties.Settings.Default.NotMyPhoto, false, selectedUser.Id);
                }
            }
            Update_MotsCles();
        }

        //----------------------------------------------------------------------------------
        //
        //Carousel
        //
        //----------------------------------------------------------------------------------

        private void visionnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionnerCarousel();
        }

        private void FBTN_Carousel_Click(object sender, EventArgs e)
        {
            VisionnerCarousel();

        }

        private void VisionnerCarousel()
        {
            if (LoggedUser.Exists())
            {
                if (SlideShowList.Count > 0)
                {
                    PageSlideShow slideShow = new PageSlideShow();
                    slideShow.SlideShowList = SlideShowList;
                    slideShow.PhotoPool = photos;
                    slideShow.ShowDialog();
                    SaveSlideShowList();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Veuillez ajouter des photos dans l'édition du carousel!");
                }
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }
        }

        


        private void FBTN_EditCarousel_Click(object sender, EventArgs e)
        {
            EditerCarousel();
        }

        private void éditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditerCarousel();
        }

        private void EditerCarousel()
        {
            if (LoggedUser.Exists())
            {
                PageEditSlideShow slideShow = new PageEditSlideShow();
                slideShow.SlideShowList = SlideShowList;
                slideShow.PhotoPool = photos;
                slideShow.ShowDialog();
                SaveSlideShowList();
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour effectuer cette opération!");
            }

        }

        private void LoadSlideShowList()
        {
            SlideShowList = new List<int>();
            if (Properties.Settings.Default.SlideShowList != null)
            {
                foreach (string stringPhotoId in Properties.Settings.Default.SlideShowList)
                {
                    int photoId = int.Parse(stringPhotoId);
                    SlideShowList.Add(photoId);
                }
            }
        }

        private void SaveSlideShowList()
        {
            if (Properties.Settings.Default.SlideShowList == null)
                Properties.Settings.Default.SlideShowList = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.SlideShowList.Clear();
            if (SlideShowList != null)
                foreach (int photoId in SlideShowList)
                {
                    Properties.Settings.Default.SlideShowList.Add(photoId.ToString());
                }
        }

        //----------------------------------------------------------------------------------
        //
        //Info photo
        //
        //----------------------------------------------------------------------------------


        private void FTBN_Info_Click(object sender, EventArgs e)
        {
            DisplayInfoPhoto();
            
        }

        private void voirInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayInfoPhoto();
        }

        private void DisplayInfoPhoto()
        {
            if (LoggedUser != null)
            {
                if (photosBrowser.SelectedPhoto != null)
                {
                    PageInfoPhotos pgPhoto = new PageInfoPhotos(photosBrowser.SelectedPhoto);
                    if (pgPhoto.ShowDialog() == DialogResult.OK)
                    {


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

        //----------------------------------------------------------------------------------
        //
        //Aide
        //
        //----------------------------------------------------------------------------------

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageAideOuAPropos pa = new PageAideOuAPropos(
                "Aide:" + '\t' + '\t' + " Alt + I" + '\n' +
                '\n' +
                "Connexion:" + '\t' + " Alt + C" + '\n' +
                "Déconnexion:" + '\t' + " Alt + D" + '\n' +
                '\n' +
                "Ajouter photo:" + '\t' + " Alt + A" + '\n' +
                "Modifier photo:" + '\t' + " Alt + M" + '\n' +
                "Effacer photo:" + '\t' + " Alt + E" + '\n' +
                "Voir infos photo:" + '\t' + " Alt + V" + '\n' +
                '\n' +
                "Liste noire:" + '\t' + " Alt + L" + '\n' +
                '\n' +
                "Visionner carousel:" + '\t' + " Alt + S" + '\n' +
                "Éditer carousel:" + '\t' + " Alt + B" + '\n' +
                '\n' +
                "Mise-en-page:" + '\t' + " Alt + R" + '\n' +
                '\n' +
                "À propos:" + '\t' + '\t' + " Alt + P" + '\n' +
                '\n' +
                "Quitter:" + '\t' +'\t' + " Alt + Q" + '\n', "Aide");
            pa.Show();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageAideOuAPropos pa = new PageAideOuAPropos(
               "Travail pratique 3" + '\n' + '\n' +
               "Réalisé par " + '\n' + '\n' +
               "Vincent Falardeau" + '\n' +
               "Émile Ménard" + '\n' +
               "Dominic Vachon" + '\n' + '\n' +
               "Pour le cours de développement d'interfaces" + '\n' +
               "Le 5 décembre 2018", "À propos");
            pa.Show();
        }

      
    }
}
