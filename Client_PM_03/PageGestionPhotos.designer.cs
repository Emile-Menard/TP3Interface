﻿namespace Client_PM
{
    partial class PageGestionPhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageGestionPhotos));
            this.TBX_Titre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_MotsCles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBX_Partager = new System.Windows.Forms.CheckBox();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.LBX_MotsCles = new System.Windows.Forms.ListBox();
            this.FBTN_EffacerMotCle = new PhotoManagerClient.FlashButton();
            this.FBTN_AjouterMotCle = new PhotoManagerClient.FlashButton();
            this.FTBN_Rotation = new PhotoManagerClient.FlashButton();
            this.IB_Image = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Titre
            // 
            this.TBX_Titre.Location = new System.Drawing.Point(21, 43);
            this.TBX_Titre.MinimumSize = new System.Drawing.Size(250, 20);
            this.TBX_Titre.Name = "TBX_Titre";
            this.TBX_Titre.Size = new System.Drawing.Size(283, 26);
            this.TBX_Titre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(21, 111);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(283, 26);
            this.DTP_Date.TabIndex = 4;
            // 
            // RTB_Description
            // 
            this.RTB_Description.AcceptsTab = true;
            this.RTB_Description.Location = new System.Drawing.Point(21, 178);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(283, 99);
            this.RTB_Description.TabIndex = 5;
            this.RTB_Description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // TBX_MotsCles
            // 
            this.TBX_MotsCles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBX_MotsCles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBX_MotsCles.Location = new System.Drawing.Point(21, 355);
            this.TBX_MotsCles.Name = "TBX_MotsCles";
            this.TBX_MotsCles.Size = new System.Drawing.Size(283, 26);
            this.TBX_MotsCles.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mots-clés";
            // 
            // CBX_Partager
            // 
            this.CBX_Partager.AutoSize = true;
            this.CBX_Partager.Location = new System.Drawing.Point(21, 537);
            this.CBX_Partager.Name = "CBX_Partager";
            this.CBX_Partager.Size = new System.Drawing.Size(96, 24);
            this.CBX_Partager.TabIndex = 9;
            this.CBX_Partager.Text = "Partager";
            this.CBX_Partager.UseVisualStyleBackColor = true;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(183, 595);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(123, 52);
            this.BTN_Annuler.TabIndex = 11;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Location = new System.Drawing.Point(21, 595);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(123, 52);
            this.BTN_Ajouter.TabIndex = 12;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // LBX_MotsCles
            // 
            this.LBX_MotsCles.FormattingEnabled = true;
            this.LBX_MotsCles.ItemHeight = 20;
            this.LBX_MotsCles.Location = new System.Drawing.Point(21, 400);
            this.LBX_MotsCles.Name = "LBX_MotsCles";
            this.LBX_MotsCles.Size = new System.Drawing.Size(283, 104);
            this.LBX_MotsCles.TabIndex = 13;
            this.LBX_MotsCles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LBX_MotsCles_KeyPress);
            // 
            // FBTN_EffacerMotCle
            // 
            this.FBTN_EffacerMotCle.BackgroundImage = global::Client_PM.Properties.Resources.trash;
            this.FBTN_EffacerMotCle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_EffacerMotCle.ClickedImage = global::Client_PM.Properties.Resources.trash_accept;
            this.FBTN_EffacerMotCle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBTN_EffacerMotCle.DisabledImage = global::Client_PM.Properties.Resources.trash_disable;
            this.FBTN_EffacerMotCle.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_EffacerMotCle.Image")));
            this.FBTN_EffacerMotCle.Location = new System.Drawing.Point(270, 309);
            this.FBTN_EffacerMotCle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_EffacerMotCle.Name = "FBTN_EffacerMotCle";
            this.FBTN_EffacerMotCle.NeutralImage = global::Client_PM.Properties.Resources.trash;
            this.FBTN_EffacerMotCle.OverImage = global::Client_PM.Properties.Resources.trash_accept;
            this.FBTN_EffacerMotCle.Size = new System.Drawing.Size(36, 37);
            this.FBTN_EffacerMotCle.TabIndex = 15;
            this.FBTN_EffacerMotCle.Text = "Effacer un mot-clé";
            this.FBTN_EffacerMotCle.UseVisualStyleBackColor = true;
            this.FBTN_EffacerMotCle.Click += new System.EventHandler(this.FBTN_EffacerMotCle_Click);
            // 
            // FBTN_AjouterMotCle
            // 
            this.FBTN_AjouterMotCle.BackgroundImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Neutral;
            this.FBTN_AjouterMotCle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_AjouterMotCle.ClickedImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Click;
            this.FBTN_AjouterMotCle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBTN_AjouterMotCle.DisabledImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Disable;
            this.FBTN_AjouterMotCle.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_AjouterMotCle.Image")));
            this.FBTN_AjouterMotCle.Location = new System.Drawing.Point(214, 309);
            this.FBTN_AjouterMotCle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_AjouterMotCle.Name = "FBTN_AjouterMotCle";
            this.FBTN_AjouterMotCle.NeutralImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Neutral;
            this.FBTN_AjouterMotCle.OverImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Over;
            this.FBTN_AjouterMotCle.Size = new System.Drawing.Size(36, 37);
            this.FBTN_AjouterMotCle.TabIndex = 14;
            this.FBTN_AjouterMotCle.Text = "Ajouter un mot-clé";
            this.FBTN_AjouterMotCle.UseVisualStyleBackColor = true;
            this.FBTN_AjouterMotCle.Click += new System.EventHandler(this.FBTN_AjouterMotCle_Click);
            // 
            // FTBN_Rotation
            // 
            this.FTBN_Rotation.BackgroundImage = global::Client_PM.Properties.Resources.rotate;
            this.FTBN_Rotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FTBN_Rotation.ClickedImage = global::Client_PM.Properties.Resources.rotate_accept;
            this.FTBN_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FTBN_Rotation.DisabledImage = null;
            this.FTBN_Rotation.Image = ((System.Drawing.Image)(resources.GetObject("FTBN_Rotation.Image")));
            this.FTBN_Rotation.Location = new System.Drawing.Point(254, 522);
            this.FTBN_Rotation.Name = "FTBN_Rotation";
            this.FTBN_Rotation.NeutralImage = global::Client_PM.Properties.Resources.rotate;
            this.FTBN_Rotation.OverImage = global::Client_PM.Properties.Resources.rotate_accept;
            this.FTBN_Rotation.Size = new System.Drawing.Size(52, 52);
            this.FTBN_Rotation.TabIndex = 10;
            this.FTBN_Rotation.Text = "Rotater l\'image";
            this.FTBN_Rotation.UseVisualStyleBackColor = true;
            this.FTBN_Rotation.Click += new System.EventHandler(this.FTBN_Rotation_Click);
            // 
            // IB_Image
            // 
            this.IB_Image.AllowDrop = true;
            this.IB_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IB_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IB_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IB_Image.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IB_Image.ImportImageText = "Import image from file...";
            this.IB_Image.Location = new System.Drawing.Point(339, 20);
            this.IB_Image.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.IB_Image.Name = "IB_Image";
            this.IB_Image.OpenFileDialogTitle = "Please choose image an file";
            this.IB_Image.PasteMenuText = "Paste image from clipboard";
            this.IB_Image.Size = new System.Drawing.Size(614, 627);
            this.IB_Image.TabIndex = 0;
            this.IB_Image.TabStop = false;
            // 
            // PageGestionPhotos
            // 
            this.AcceptButton = this.BTN_Ajouter;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(975, 666);
            this.Controls.Add(this.FBTN_EffacerMotCle);
            this.Controls.Add(this.FBTN_AjouterMotCle);
            this.Controls.Add(this.LBX_MotsCles);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.FTBN_Rotation);
            this.Controls.Add(this.CBX_Partager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBX_MotsCles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTB_Description);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Titre);
            this.Controls.Add(this.IB_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(997, 722);
            this.Name = "PageGestionPhotos";
            this.Text = "Ajouter une photo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PageGestionPhotos_FormClosing);
            this.Load += new System.EventHandler(this.PageGestionPhotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.ImageBox IB_Image;
        private System.Windows.Forms.TextBox TBX_Titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_MotsCles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CBX_Partager;
        private PhotoManagerClient.FlashButton FTBN_Rotation;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.ListBox LBX_MotsCles;
        private PhotoManagerClient.FlashButton FBTN_AjouterMotCle;
        private PhotoManagerClient.FlashButton FBTN_EffacerMotCle;
    }
}