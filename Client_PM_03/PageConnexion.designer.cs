namespace Client_PM
{
    partial class PageConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBXName_Connexion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBXPassword_Connexion = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.CBOX_RememberMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TBXName_Connexion
            // 
            this.TBXName_Connexion.Location = new System.Drawing.Point(12, 41);
            this.TBXName_Connexion.Name = "TBXName_Connexion";
            this.TBXName_Connexion.Size = new System.Drawing.Size(210, 20);
            this.TBXName_Connexion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // TBXPassword_Connexion
            // 
            this.TBXPassword_Connexion.Location = new System.Drawing.Point(12, 98);
            this.TBXPassword_Connexion.Name = "TBXPassword_Connexion";
            this.TBXPassword_Connexion.PasswordChar = '*';
            this.TBXPassword_Connexion.Size = new System.Drawing.Size(210, 20);
            this.TBXPassword_Connexion.TabIndex = 2;
            // 
            // BTN_Login
            // 
            this.BTN_Login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Login.Location = new System.Drawing.Point(66, 154);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(75, 23);
            this.BTN_Login.TabIndex = 4;
            this.BTN_Login.Text = "Accepter";
            this.BTN_Login.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(147, 154);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // CBOX_RememberMe
            // 
            this.CBOX_RememberMe.AutoSize = true;
            this.CBOX_RememberMe.Location = new System.Drawing.Point(12, 127);
            this.CBOX_RememberMe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBOX_RememberMe.Name = "CBOX_RememberMe";
            this.CBOX_RememberMe.Size = new System.Drawing.Size(116, 17);
            this.CBOX_RememberMe.TabIndex = 6;
            this.CBOX_RememberMe.Text = "Se souvenir de moi";
            this.CBOX_RememberMe.UseVisualStyleBackColor = true;
            // 
            // PageConnexion
            // 
            this.AcceptButton = this.BTN_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(237, 201);
            this.Controls.Add(this.CBOX_RememberMe);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBXPassword_Connexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBXName_Connexion);
            this.Name = "PageConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBXName_Connexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBXPassword_Connexion;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.CheckBox CBOX_RememberMe;
    }
}

