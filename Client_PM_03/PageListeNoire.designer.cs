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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FBTN_Add_User_Black_List = new PhotoManagerClient.FlashButton();
            this.FBTN_Delete_Liste_User = new PhotoManagerClient.FlashButton();
            this.F_BTN_Clean_Black_List = new PhotoManagerClient.FlashButton();
            this.SuspendLayout();
            // 
            // COB_Liste_Noire_Utilisateur
            // 
            this.COB_Liste_Noire_Utilisateur.FormattingEnabled = true;
            this.COB_Liste_Noire_Utilisateur.Location = new System.Drawing.Point(32, 50);
            this.COB_Liste_Noire_Utilisateur.Name = "COB_Liste_Noire_Utilisateur";
            this.COB_Liste_Noire_Utilisateur.Size = new System.Drawing.Size(167, 21);
            this.COB_Liste_Noire_Utilisateur.TabIndex = 0;
            // 
            // LISTB_Liste_Noire
            // 
            this.LISTB_Liste_Noire.FormattingEnabled = true;
            this.LISTB_Liste_Noire.Location = new System.Drawing.Point(32, 105);
            this.LISTB_Liste_Noire.Name = "LISTB_Liste_Noire";
            this.LISTB_Liste_Noire.Size = new System.Drawing.Size(263, 160);
            this.LISTB_Liste_Noire.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Suprimer de la liste";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste noire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Utilisateurs";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Sauvegarder";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Reinitialiser";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FBTN_Add_User_Black_List
            // 
            this.FBTN_Add_User_Black_List.BackgroundImage = global::Client_PM.Properties.Resources.Plus;
            this.FBTN_Add_User_Black_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Add_User_Black_List.ClickedImage = null;
            this.FBTN_Add_User_Black_List.DisabledImage = null;
            this.FBTN_Add_User_Black_List.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Add_User_Black_List.Image")));
            this.FBTN_Add_User_Black_List.Location = new System.Drawing.Point(237, 43);
            this.FBTN_Add_User_Black_List.Name = "FBTN_Add_User_Black_List";
            this.FBTN_Add_User_Black_List.NeutralImage = null;
            this.FBTN_Add_User_Black_List.OverImage = null;
            this.FBTN_Add_User_Black_List.Size = new System.Drawing.Size(32, 32);
            this.FBTN_Add_User_Black_List.TabIndex = 9;
            this.FBTN_Add_User_Black_List.UseVisualStyleBackColor = true;
            this.FBTN_Add_User_Black_List.Click += new System.EventHandler(this.FBTN_Add_User_Black_List_Click);
            // 
            // FBTN_Delete_Liste_User
            // 
            this.FBTN_Delete_Liste_User.BackgroundImage = global::Client_PM.Properties.Resources.Delete;
            this.FBTN_Delete_Liste_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Delete_Liste_User.ClickedImage = null;
            this.FBTN_Delete_Liste_User.DisabledImage = null;
            this.FBTN_Delete_Liste_User.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Delete_Liste_User.Image")));
            this.FBTN_Delete_Liste_User.Location = new System.Drawing.Point(275, 41);
            this.FBTN_Delete_Liste_User.Name = "FBTN_Delete_Liste_User";
            this.FBTN_Delete_Liste_User.NeutralImage = null;
            this.FBTN_Delete_Liste_User.OverImage = null;
            this.FBTN_Delete_Liste_User.Size = new System.Drawing.Size(36, 36);
            this.FBTN_Delete_Liste_User.TabIndex = 10;
            this.FBTN_Delete_Liste_User.Text = "flashButton1";
            this.FBTN_Delete_Liste_User.UseVisualStyleBackColor = true;
            this.FBTN_Delete_Liste_User.Click += new System.EventHandler(this.FBTN_Delete_Liste_User_Click);
            // 
            // F_BTN_Clean_Black_List
            // 
            this.F_BTN_Clean_Black_List.BackgroundImage = global::Client_PM.Properties.Resources.ArrowRotation;
            this.F_BTN_Clean_Black_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.F_BTN_Clean_Black_List.ClickedImage = null;
            this.F_BTN_Clean_Black_List.DisabledImage = null;
            this.F_BTN_Clean_Black_List.Image = ((System.Drawing.Image)(resources.GetObject("F_BTN_Clean_Black_List.Image")));
            this.F_BTN_Clean_Black_List.Location = new System.Drawing.Point(46, 301);
            this.F_BTN_Clean_Black_List.Name = "F_BTN_Clean_Black_List";
            this.F_BTN_Clean_Black_List.NeutralImage = null;
            this.F_BTN_Clean_Black_List.OverImage = null;
            this.F_BTN_Clean_Black_List.Size = new System.Drawing.Size(36, 36);
            this.F_BTN_Clean_Black_List.TabIndex = 11;
            this.F_BTN_Clean_Black_List.Text = "flashButton1";
            this.F_BTN_Clean_Black_List.UseVisualStyleBackColor = true;
            this.F_BTN_Clean_Black_List.Click += new System.EventHandler(this.F_BTN_Clean_Black_List_Click);
            // 
            // PageListeNoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 364);
            this.Controls.Add(this.F_BTN_Clean_Black_List);
            this.Controls.Add(this.FBTN_Delete_Liste_User);
            this.Controls.Add(this.FBTN_Add_User_Black_List);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LISTB_Liste_Noire);
            this.Controls.Add(this.COB_Liste_Noire_Utilisateur);
            this.Name = "PageListeNoire";
            this.Text = "Liste noire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COB_Liste_Noire_Utilisateur;
        private System.Windows.Forms.ListBox LISTB_Liste_Noire;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private PhotoManagerClient.FlashButton FBTN_Add_User_Black_List;
        private PhotoManagerClient.FlashButton FBTN_Delete_Liste_User;
        private PhotoManagerClient.FlashButton F_BTN_Clean_Black_List;
    }
}