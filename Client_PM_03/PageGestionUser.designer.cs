namespace Client_PM
{
    partial class PageGestionUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_CreePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_CreeUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_CreeConfirmPassword = new System.Windows.Forms.TextBox();
            this.BTN_CreateCancel = new System.Windows.Forms.Button();
            this.BTN_CreeCompte = new System.Windows.Forms.Button();
            this.IBX_CreeAvatar = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_CreeAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe";
            // 
            // TBX_CreePassword
            // 
            this.TBX_CreePassword.Location = new System.Drawing.Point(356, 132);
            this.TBX_CreePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBX_CreePassword.Name = "TBX_CreePassword";
            this.TBX_CreePassword.PasswordChar = '*';
            this.TBX_CreePassword.Size = new System.Drawing.Size(313, 26);
            this.TBX_CreePassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // TBX_CreeUsername
            // 
            this.TBX_CreeUsername.Location = new System.Drawing.Point(354, 40);
            this.TBX_CreeUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBX_CreeUsername.Name = "TBX_CreeUsername";
            this.TBX_CreeUsername.Size = new System.Drawing.Size(313, 26);
            this.TBX_CreeUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirmer le mot de passe";
            // 
            // TBX_CreeConfirmPassword
            // 
            this.TBX_CreeConfirmPassword.Location = new System.Drawing.Point(354, 198);
            this.TBX_CreeConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBX_CreeConfirmPassword.Name = "TBX_CreeConfirmPassword";
            this.TBX_CreeConfirmPassword.PasswordChar = '*';
            this.TBX_CreeConfirmPassword.Size = new System.Drawing.Size(313, 26);
            this.TBX_CreeConfirmPassword.TabIndex = 8;
            // 
            // BTN_CreateCancel
            // 
            this.BTN_CreateCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_CreateCancel.Location = new System.Drawing.Point(556, 292);
            this.BTN_CreateCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_CreateCancel.Name = "BTN_CreateCancel";
            this.BTN_CreateCancel.Size = new System.Drawing.Size(112, 35);
            this.BTN_CreateCancel.TabIndex = 12;
            this.BTN_CreateCancel.Text = "Annuler";
            this.BTN_CreateCancel.UseVisualStyleBackColor = true;
            // 
            // BTN_CreeCompte
            // 
            this.BTN_CreeCompte.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_CreeCompte.Location = new System.Drawing.Point(429, 292);
            this.BTN_CreeCompte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_CreeCompte.Name = "BTN_CreeCompte";
            this.BTN_CreeCompte.Size = new System.Drawing.Size(112, 35);
            this.BTN_CreeCompte.TabIndex = 11;
            this.BTN_CreeCompte.Text = "Accepter";
            this.BTN_CreeCompte.UseVisualStyleBackColor = true;
            // 
            // IBX_CreeAvatar
            // 
            this.IBX_CreeAvatar.AllowDrop = true;
            this.IBX_CreeAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IBX_CreeAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBX_CreeAvatar.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IBX_CreeAvatar.ImportImageText = "Import image from file...";
            this.IBX_CreeAvatar.Location = new System.Drawing.Point(16, 17);
            this.IBX_CreeAvatar.Name = "IBX_CreeAvatar";
            this.IBX_CreeAvatar.OpenFileDialogTitle = "Please choose image an file";
            this.IBX_CreeAvatar.PasteMenuText = "Paste image from clipboard";
            this.IBX_CreeAvatar.Size = new System.Drawing.Size(310, 310);
            this.IBX_CreeAvatar.TabIndex = 13;
            this.IBX_CreeAvatar.TabStop = false;
            this.IBX_CreeAvatar.BackgroundImageChanged += new System.EventHandler(this.IBX_CreeAvatar_BackgroundImageChanged);
            // 
            // PageGestionUser
            // 
            this.AcceptButton = this.BTN_CreeCompte;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_CreateCancel;
            this.ClientSize = new System.Drawing.Size(693, 349);
            this.Controls.Add(this.IBX_CreeAvatar);
            this.Controls.Add(this.BTN_CreateCancel);
            this.Controls.Add(this.BTN_CreeCompte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBX_CreeConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX_CreePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_CreeUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PageGestionUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer un compte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PageGestionUser_FormClosing);
            this.Load += new System.EventHandler(this.PageCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IBX_CreeAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_CreePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_CreeUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_CreeConfirmPassword;
        private System.Windows.Forms.Button BTN_CreateCancel;
        private System.Windows.Forms.Button BTN_CreeCompte;
        private PhotoManagerClient.ImageBox IBX_CreeAvatar;
    }
}