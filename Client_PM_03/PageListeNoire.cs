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
using System.Collections;
using Validation;

namespace Client_PM
{
    public partial class PageListeNoire : Form
    {
        private User mUser;
        public ArrayList mListeNoire;
        public PageListeNoire(ArrayList listeNoire, User user)
        {
            InitializeComponent();
            mUser = user;
            mListeNoire = listeNoire;
            Init_COB_Liste_Noire();
            listeNoireToDialog();
           
        }

        private void listeNoireToDialog()
        {
            foreach (User user in DBPhotosWebServices.GetAllUsers())
            {
                foreach (int id in mListeNoire)
                {
                    if (user.Id == id)
                    {
                        LISTB_Liste_Noire.Items.Add(user.Name);
                    }
                }
                   
            }
        }

        private void Init_COB_Liste_Noire()
        {
           
           List<User> userList = DBPhotosWebServices.GetAllUsers();
           foreach (User user in userList)
           {
                this.COB_Liste_Noire_Utilisateur.Items.Add(user.Name);
           }
        }       

        private void FBTN_Add_User_Black_Lists_Click_1(object sender, EventArgs e)
        {
            LISTB_Liste_Noire.Items.Add(COB_Liste_Noire_Utilisateur.SelectedItem.ToString());
            COB_Liste_Noire_Utilisateur.SelectedItem = null;
        }

        private void FBTN_Delete_Liste_Users_Click_1(object sender, EventArgs e)
        {
           
            LISTB_Liste_Noire.Items.Remove(LISTB_Liste_Noire.SelectedItem);
        }

        private void FBTN_Clean_Black_Lists_Click_1(object sender, EventArgs e)
        {
            LISTB_Liste_Noire.Items.Clear();
        }

        private void BTN_Save_Black_List_Click(object sender, EventArgs e)
        {
            mListeNoire = new ArrayList();
           foreach(User user in DBPhotosWebServices.GetAllUsers())
           {
                foreach(string nom in LISTB_Liste_Noire.Items)
                {
                    if (user.Name == nom)
                    {
                        mListeNoire.Add(user.Id);
                    }
                }
           }
        }
    }
}
