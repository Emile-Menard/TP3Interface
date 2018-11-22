namespace Client_PM
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
            this.FTBN_Rotation = new PhotoManagerClient.FlashButton();
            this.imageBox1 = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Titre
            // 
            this.TBX_Titre.Location = new System.Drawing.Point(101, 12);
            this.TBX_Titre.MinimumSize = new System.Drawing.Size(283, 26);
            this.TBX_Titre.Name = "TBX_Titre";
            this.TBX_Titre.Size = new System.Drawing.Size(283, 26);
            this.TBX_Titre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(101, 45);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(283, 26);
            this.DTP_Date.TabIndex = 4;
            // 
            // RTB_Description
            // 
            this.RTB_Description.AcceptsTab = true;
            this.RTB_Description.Location = new System.Drawing.Point(101, 78);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(283, 151);
            this.RTB_Description.TabIndex = 5;
            this.RTB_Description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // TBX_MotsCles
            // 
            this.TBX_MotsCles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBX_MotsCles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBX_MotsCles.Location = new System.Drawing.Point(101, 236);
            this.TBX_MotsCles.Name = "TBX_MotsCles";
            this.TBX_MotsCles.Size = new System.Drawing.Size(284, 26);
            this.TBX_MotsCles.TabIndex = 7;
            this.TBX_MotsCles.TextChanged += new System.EventHandler(this.TBX_MotsCles_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mots-clés";
            // 
            // CBX_Partager
            // 
            this.CBX_Partager.AutoSize = true;
            this.CBX_Partager.Location = new System.Drawing.Point(290, 268);
            this.CBX_Partager.Name = "CBX_Partager";
            this.CBX_Partager.Size = new System.Drawing.Size(96, 24);
            this.CBX_Partager.TabIndex = 9;
            this.CBX_Partager.Text = "Partager";
            this.CBX_Partager.UseVisualStyleBackColor = true;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(208, 538);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(176, 53);
            this.BTN_Annuler.TabIndex = 11;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Location = new System.Drawing.Point(10, 538);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(176, 53);
            this.BTN_Ajouter.TabIndex = 12;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // FTBN_Rotation
            // 
            this.FTBN_Rotation.BackgroundImage = global::Client_PM.Properties.Resources.ArrowRotation;
            this.FTBN_Rotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FTBN_Rotation.ClickedImage = null;
            this.FTBN_Rotation.DisabledImage = null;
            this.FTBN_Rotation.Image = ((System.Drawing.Image)(resources.GetObject("FTBN_Rotation.Image")));
            this.FTBN_Rotation.Location = new System.Drawing.Point(353, 298);
            this.FTBN_Rotation.Name = "FTBN_Rotation";
            this.FTBN_Rotation.NeutralImage = null;
            this.FTBN_Rotation.OverImage = null;
            this.FTBN_Rotation.Size = new System.Drawing.Size(32, 31);
            this.FTBN_Rotation.TabIndex = 10;
            this.FTBN_Rotation.Text = "flashButton1";
            this.FTBN_Rotation.UseVisualStyleBackColor = true;
            // 
            // imageBox1
            // 
            this.imageBox1.AllowDrop = true;
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox1.ImportImageText = "Import image from file...";
            this.imageBox1.Location = new System.Drawing.Point(426, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox1.PasteMenuText = "Paste image from clipboard";
            this.imageBox1.Size = new System.Drawing.Size(633, 580);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.TabStop = false;
            // 
            // PageGestionPhotos
            // 
            this.AcceptButton = this.BTN_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(1075, 604);
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
            this.Controls.Add(this.imageBox1);
            this.MinimumSize = new System.Drawing.Size(900, 530);
            this.Name = "PageGestionPhotos";
            this.Text = "Prototype_gestion_photos";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.ImageBox imageBox1;
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
    }
}