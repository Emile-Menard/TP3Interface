namespace Client_PM
{
    partial class PageListeNoire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageListeNoire));
            this.COB_Liste_Noire_Utilisateur = new System.Windows.Forms.ComboBox();
            this.LISTB_Liste_Noire = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Save_Black_List = new System.Windows.Forms.Button();
            this.FBTN_Clean_Black_Lists = new PhotoManagerClient.FlashButton();
            this.FBTN_Delete_Liste_Users = new PhotoManagerClient.FlashButton();
            this.FBTN_Add_User_Black_Lists = new PhotoManagerClient.FlashButton();
            this.SuspendLayout();
            // 
            // COB_Liste_Noire_Utilisateur
            // 
            this.COB_Liste_Noire_Utilisateur.FormattingEnabled = true;
            this.COB_Liste_Noire_Utilisateur.Location = new System.Drawing.Point(32, 41);
            this.COB_Liste_Noire_Utilisateur.Name = "COB_Liste_Noire_Utilisateur";
            this.COB_Liste_Noire_Utilisateur.Size = new System.Drawing.Size(224, 21);
            this.COB_Liste_Noire_Utilisateur.TabIndex = 0;
            // 
            // LISTB_Liste_Noire
            // 
            this.LISTB_Liste_Noire.FormattingEnabled = true;
            this.LISTB_Liste_Noire.Location = new System.Drawing.Point(32, 92);
            this.LISTB_Liste_Noire.Name = "LISTB_Liste_Noire";
            this.LISTB_Liste_Noire.Size = new System.Drawing.Size(224, 173);
            this.LISTB_Liste_Noire.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste noire";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Utilisateurs";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(181, 271);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Save_Black_List
            // 
            this.BTN_Save_Black_List.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Save_Black_List.Location = new System.Drawing.Point(97, 271);
            this.BTN_Save_Black_List.Name = "BTN_Save_Black_List";
            this.BTN_Save_Black_List.Size = new System.Drawing.Size(78, 23);
            this.BTN_Save_Black_List.TabIndex = 7;
            this.BTN_Save_Black_List.Text = "Sauvegarder";
            this.BTN_Save_Black_List.UseVisualStyleBackColor = true;
            this.BTN_Save_Black_List.Click += new System.EventHandler(this.BTN_Save_Black_List_Click);
            // 
            // FBTN_Clean_Black_Lists
            // 
            this.FBTN_Clean_Black_Lists.BackgroundImage = global::Client_PM.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Clean_Black_Lists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Clean_Black_Lists.ClickedImage = global::Client_PM.Properties.Resources.ICON_Annuler_Click;
            this.FBTN_Clean_Black_Lists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBTN_Clean_Black_Lists.DisabledImage = global::Client_PM.Properties.Resources.ICON_Annuler_Disable;
            this.FBTN_Clean_Black_Lists.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Clean_Black_Lists.Image")));
            this.FBTN_Clean_Black_Lists.Location = new System.Drawing.Point(262, 129);
            this.FBTN_Clean_Black_Lists.Name = "FBTN_Clean_Black_Lists";
            this.FBTN_Clean_Black_Lists.NeutralImage = global::Client_PM.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Clean_Black_Lists.OverImage = global::Client_PM.Properties.Resources.ICON_Annuler_Over;
            this.FBTN_Clean_Black_Lists.Size = new System.Drawing.Size(32, 31);
            this.FBTN_Clean_Black_Lists.TabIndex = 10;
            this.FBTN_Clean_Black_Lists.Text = "Vider la liste";
            this.FBTN_Clean_Black_Lists.UseVisualStyleBackColor = true;
            this.FBTN_Clean_Black_Lists.Click += new System.EventHandler(this.FBTN_Clean_Black_Lists_Click_1);
            // 
            // FBTN_Delete_Liste_Users
            // 
            this.FBTN_Delete_Liste_Users.BackgroundImage = global::Client_PM.Properties.Resources.trash;
            this.FBTN_Delete_Liste_Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Delete_Liste_Users.ClickedImage = global::Client_PM.Properties.Resources.trash_accept;
            this.FBTN_Delete_Liste_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBTN_Delete_Liste_Users.DisabledImage = global::Client_PM.Properties.Resources.trash_disable;
            this.FBTN_Delete_Liste_Users.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Delete_Liste_Users.Image")));
            this.FBTN_Delete_Liste_Users.Location = new System.Drawing.Point(262, 92);
            this.FBTN_Delete_Liste_Users.Name = "FBTN_Delete_Liste_Users";
            this.FBTN_Delete_Liste_Users.NeutralImage = global::Client_PM.Properties.Resources.trash;
            this.FBTN_Delete_Liste_Users.OverImage = global::Client_PM.Properties.Resources.trash_accept;
            this.FBTN_Delete_Liste_Users.Size = new System.Drawing.Size(32, 31);
            this.FBTN_Delete_Liste_Users.TabIndex = 9;
            this.FBTN_Delete_Liste_Users.Text = "Enlever un utilisateur de la liste noire";
            this.FBTN_Delete_Liste_Users.UseVisualStyleBackColor = true;
            this.FBTN_Delete_Liste_Users.Click += new System.EventHandler(this.FBTN_Delete_Liste_Users_Click_1);
            // 
            // FBTN_Add_User_Black_Lists
            // 
            this.FBTN_Add_User_Black_Lists.BackgroundImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Neutral;
            this.FBTN_Add_User_Black_Lists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Add_User_Black_Lists.ClickedImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Click;
            this.FBTN_Add_User_Black_Lists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBTN_Add_User_Black_Lists.DisabledImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Disable;
            this.FBTN_Add_User_Black_Lists.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Add_User_Black_Lists.Image")));
            this.FBTN_Add_User_Black_Lists.Location = new System.Drawing.Point(262, 35);
            this.FBTN_Add_User_Black_Lists.Name = "FBTN_Add_User_Black_Lists";
            this.FBTN_Add_User_Black_Lists.NeutralImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Neutral;
            this.FBTN_Add_User_Black_Lists.OverImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Over;
            this.FBTN_Add_User_Black_Lists.Size = new System.Drawing.Size(32, 31);
            this.FBTN_Add_User_Black_Lists.TabIndex = 8;
            this.FBTN_Add_User_Black_Lists.Text = "Ajouter un utilisateur à la liste noire";
            this.FBTN_Add_User_Black_Lists.UseVisualStyleBackColor = true;
            this.FBTN_Add_User_Black_Lists.Click += new System.EventHandler(this.FBTN_Add_User_Black_Lists_Click_1);
            // 
            // PageListeNoire
            // 
            this.AcceptButton = this.BTN_Save_Black_List;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(314, 314);
            this.Controls.Add(this.FBTN_Clean_Black_Lists);
            this.Controls.Add(this.FBTN_Delete_Liste_Users);
            this.Controls.Add(this.FBTN_Add_User_Black_Lists);
            this.Controls.Add(this.BTN_Save_Black_List);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LISTB_Liste_Noire);
            this.Controls.Add(this.COB_Liste_Noire_Utilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PageListeNoire";
            this.Text = "Liste noire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COB_Liste_Noire_Utilisateur;
        private System.Windows.Forms.ListBox LISTB_Liste_Noire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Save_Black_List;
        private PhotoManagerClient.FlashButton FBTN_Add_User_Black_Lists;
        private PhotoManagerClient.FlashButton FBTN_Delete_Liste_Users;
        private PhotoManagerClient.FlashButton FBTN_Clean_Black_Lists;
    }
}