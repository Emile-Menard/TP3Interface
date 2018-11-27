﻿using System;
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

        private void FBTN_Add_User_Black_Lists_Click(object sender, EventArgs e)
        {
            lUser.Name = Convert.ToString(COB_Liste_Noire_Utilisateur.SelectedItem);
            LISTB_Liste_Noire.Items.Add(lUser.Name);
            UpdateComboAndListe();
        }

        private void FBTN_Delete_Liste_Users_Click(object sender, EventArgs e)
        {
            //lUser.Name = Convert.ToString(LISTB_Liste_Noire.SelectedItem);
            LISTB_Liste_Noire.Items.Remove(LISTB_Liste_Noire.SelectedItem);
            UpdateComboAndListe();
        }

        private void FBTN_Clean_Black_Lists_Click(object sender, EventArgs e)
        {
            LISTB_Liste_Noire.Items.Clear();
            UpdateComboAndListe();
        }

        private void FillList()
        {
            foreach (User user in User.GetAllUsers())
            {
                if (!LISTB_Liste_Noire.Items.Contains(user.Name))
                {
                    lUser = user;
                    ListeUsers.Add(lUser);
                }
            }
        }

    }
}
