using PhotoManagerClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;

namespace Client_PM
{
    public partial class PageConnexion : Form
    {

        public User Logged_User { get; set; }
        ValidationProvider ValidationProvider;

        public PageConnexion()
        {
            InitializeComponent();
            Logged_User = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this, Submit_Task);
            ValidationProvider.AddControlToValidate(TBXName_Connexion, Validate_UserName, Validate_UserName_OnSubmit);
            ValidationProvider.AddControlToValidate(TBXPassword_Connexion, Validate_Password, Validate_Password_OnSubmit);
        }


        private bool Validate_UserName(ref string message)
        {
            message = "Le nom d'utilisateur est absent";
            return TBXName_Connexion.Text != "";
        }

        private bool Validate_UserName_OnSubmit(ref string message)
        {
            message = "Le nom d'utilisateur n'existe pas";
            return DBPhotosWebServices.UserNameExist(TBXName_Connexion.Text);
        }

        private bool Validate_Password(ref string message)
        {
            message = "Mot de passe absent..";
            return TBXPassword_Connexion.Text != "";
        }

        private bool Validate_Password_OnSubmit(ref string message)
        {
            message = "Mauvais mot de passe...";
            return DBPhotosWebServices.PasswordMatch(TBXName_Connexion.Text, TBXPassword_Connexion.Text);
        }
        private void Submit_Task()
        {
            WaitSplash.Show(this, "Connexion...");
            Logged_User = DBPhotosWebServices.Login(TBXName_Connexion.Text, TBXPassword_Connexion.Text);
            WaitSplash.Hide();
        }
    }
}
