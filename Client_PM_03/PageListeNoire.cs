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
    public partial class PageListeNoire : Form
    {

        // Pas fini en construction


        public User lUser;
        public Photo lPhoto;
        public List<User> ListeUsers;
        public List<int> IdUsers;
        public DBPhotosWebServices dBPhotosWebServices;
        public PageListeNoire()
        {
            InitializeComponent();
            FillList();
            FillCombobox();
        }


        private void FillCombobox()
        {
            foreach (User user in ListeUsers)
            {
                if (!LISTB_Liste_Noire.Items.Contains(user.Name))
                {
                    COB_Liste_Noire_Utilisateur.Items.Add(user.Name);
                }
                else
                {
                    COB_Liste_Noire_Utilisateur.Items.Remove(user.Name);
                }
            }
        }

        private void UpdateComboAndListe()
        {
            FillList();
            FillCombobox();
            COB_Liste_Noire_Utilisateur.Hide();
            COB_Liste_Noire_Utilisateur.Show();
            LISTB_Liste_Noire.Hide();
            LISTB_Liste_Noire.Show();
        }


        private void FillList()
        {
            List<User> lusers = new List<User>();
            foreach (User user in User.GetAllUsers())
            {
                if (!LISTB_Liste_Noire.Items.Contains(user))
                {
                    lUser = user;
                    lusers.Add(lUser);
                    ListeUsers = lusers;
                }
            }
        }

        private void FBTN_Add_User_Black_Lists_Click_1(object sender, EventArgs e)
        {
            try
            {
                lUser.Name = Convert.ToString(COB_Liste_Noire_Utilisateur.SelectedItem);
                LISTB_Liste_Noire.Items.Add(lUser.Name);
                //MessageBox.Show("L'ajout du membre a la liste noire réussite!");
                UpdateComboAndListe();
            }
            catch (Exception)
            {
                MessageBox.Show("L'insertion a échoué!");
                throw;
            }
        }

        private void FBTN_Delete_Liste_Users_Click_1(object sender, EventArgs e)
        {
            try
            {
                //lUser.Name = Convert.ToString(LISTB_Liste_Noire.SelectedItem);
                LISTB_Liste_Noire.Items.Remove(LISTB_Liste_Noire.SelectedItem);
                //MessageBox.Show("Le retret du membre a la liste noire réussite!");
                UpdateComboAndListe();
            }
            catch (Exception)
            {
                MessageBox.Show("Le retret a échoué!");
                throw;
            }
        }

        private void FBTN_Clean_Black_Lists_Click_1(object sender, EventArgs e)
        {
            try
            {
                LISTB_Liste_Noire.Items.Clear();
                MessageBox.Show("La rénitialisation de la liste noire a réussi!");
                UpdateComboAndListe();
            }
            catch (Exception)
            {
                MessageBox.Show("La rénitialisation a échoué!");
                throw;
            }
        }

        private void BTN_Save_Black_List_Click(object sender, EventArgs e)
        {
            IdUsers = new List<int>();
            foreach (User user in ListeUsers)
            {
                if (LISTB_Liste_Noire.Items.Contains(user.Name))
                {
                    IdUsers.Add(user.Id);
                }
            }
            MessageBox.Show("Liste noire sauvegarder!");
        }
    }
}
