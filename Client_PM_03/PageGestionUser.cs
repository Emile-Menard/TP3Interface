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
    public partial class PageGestionUser : Form
    {

        public User User { get; set; }
        private ValidationProvider ValidationProvider;
        private bool AvatarImageChanged = false;

        public PageGestionUser()
        {
            InitializeComponent();
        }

        private void PageCreation_Load(object sender, EventArgs e)
        {
            if(!Properties.Settings.Default.LocationPageEditionUser.IsEmpty)
            {
                this.Location = Properties.Settings.Default.LocationPageEditionUser;
            }
         
            ValidationProvider = new ValidationProvider(this, SubmitTask);
            ValidationProvider.AddControlToValidate(TBX_CreeUsername, Validate_TBX_Username, Validate_TBX_Username_OnSubmit);
            ValidationProvider.AddControlToValidate(TBX_CreePassword, Validate_TBX_Password);
            ValidationProvider.AddControlToValidate(TBX_CreeConfirmPassword, Validate_TBX_verifyPassword);
            ValidationProvider.AddControlToValidate(IBX_CreeAvatar, Validate_IBX_Avatar);

            if (User.Exists())
                UserToData();
        }

        private void DataToUser()
        {
            User.Name = TBX_CreeUsername.Text;
            User.Password = TBX_CreePassword.Text;
            if (AvatarImageChanged)
                User.SetAvatarImage(TBX_CreeConfirmPassword.BackgroundImage);
        }

        private void UserToData()
        {
            this.Text = "Modifier votre compte";
            TBX_CreeUsername.Text = User.Name;
            TBX_CreePassword.Text = User.Password;
            TBX_CreeConfirmPassword.Text = User.Password;
            IBX_CreeAvatar.BackgroundImage = User.GetAvatarOriginalImage();
            AvatarImageChanged = false;
        }

        private bool Validate_TBX_Username(ref string message)
        {
            message = "Nom d'usager manquant";
            return TBX_CreeUsername.Text != "";
        }
        private bool Validate_TBX_Username_OnSubmit(ref string message)
        {
            message = "Nom d'usager déjà utilisé";
            if (User.Exists())
                return !DBPhotosWebServices.UserNameAlreadyUsed(User.Id, TBX_CreeUsername.Text);
            else
                return !DBPhotosWebServices.UserNameExist(TBX_CreeUsername.Text);
        }
        private bool Validate_TBX_Password(ref string message)
        {
            message = "Mot de passe manquant";
            return TBX_CreePassword.Text != "";
        }
        private bool Validate_TBX_verifyPassword(ref string message)
        {
            message = "Mot de passe ne correspond avec vérification";
            return TBX_CreePassword.Text == TBX_CreePassword.Text;
        }

        private bool Validate_IBX_Avatar(ref string message)
        {
            message = "Veuillez vhoisir votre avatar.";
            return IBX_CreeAvatar.BackgroundImage != null;
        }

        private void SubmitTask()
        {
            if (!User.Exists())
            {
                User = new User();
                UserToData();
                User = DBPhotosWebServices.CreateUser(User);
            }
            else
            {
                DataToUser();
                DBPhotosWebServices.UpdateUser(User);
            }
        }

        private void PageGestionUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LocationPageEditionUser = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
