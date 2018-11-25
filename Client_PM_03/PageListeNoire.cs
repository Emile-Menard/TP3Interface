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
        public PageListeNoire()
        {
            InitializeComponent();
            FillCombobox();
        }


        private void FillCombobox()
        {
            foreach (var user in ListeUsers)
            {
                if (!LISTB_Liste_Noire.Items.Contains(user.Name))
                {
                    COB_Liste_Noire_Utilisateur.Items.Add(user.Name);
                }
            }
        }

        private void UpdateComboAndListe()
        {
            FillCombobox();
            COB_Liste_Noire_Utilisateur.Refresh();
            LISTB_Liste_Noire.Refresh();
        }

        private void FBTN_Add_User_Black_List_Click(object sender, EventArgs e)
        {
            LISTB_Liste_Noire.Items.Add(COB_Liste_Noire_Utilisateur.SelectedItem);
            UpdateComboAndListe();
        }

        private void FBTN_Delete_Liste_User_Click(object sender, EventArgs e)
        {
            LISTB_Liste_Noire.Items.Remove(LISTB_Liste_Noire.SelectedItem);
            UpdateComboAndListe();
        }

        private void FBTN_Clean_Black_List_Click(object sender, EventArgs e)
        {
            LISTB_Liste_Noire.Items.Clear();
            UpdateComboAndListe();
        }



    }
}
