namespace Client_PM
{
    partial class PagePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagePrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TLSTRIP_Compte = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSTRIP_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSTRIP_Editer = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSTRIP_Cree = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSTRIP_Deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSTRIP_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeNoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMB_UsersList = new System.Windows.Forms.ComboBox();
            this.TBX_MotsCles = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBOX_NotMine = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBX_MotsCles = new System.Windows.Forms.ListBox();
            this.CBX_MotsCles = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBX_Date = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_Fin = new System.Windows.Forms.DateTimePicker();
            this.DTP_Debut = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Username = new System.Windows.Forms.Label();
            this.IMB_UserAvatar = new PhotoManagerClient.ImageBox();
            this.FBTN_MiseEnPage = new PhotoManagerClient.FlashButton();
            this.FBTN_EditerCarousel = new PhotoManagerClient.FlashButton();
            this.FBTN_Carousel = new PhotoManagerClient.FlashButton();
            this.FTBN_Info = new PhotoManagerClient.FlashButton();
            this.FBTN_Modifier = new PhotoManagerClient.FlashButton();
            this.FBTN_Ajouter = new PhotoManagerClient.FlashButton();
            this.FTBN_Effacer = new PhotoManagerClient.FlashButton();
            this.photosBrowser = new PhotoManagerClient.PhotosBrowser();
            this.FBTN_EffacerMotCle = new PhotoManagerClient.FlashButton();
            this.FBTN_AjouterMotCle = new PhotoManagerClient.FlashButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMB_UserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TLSTRIP_Compte,
            this.gestionDesPhotosToolStripMenuItem,
            this.listeNoireToolStripMenuItem,
            this.rotationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TLSTRIP_Compte
            // 
            this.TLSTRIP_Compte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TLSTRIP_Connexion,
            this.TLSTRIP_Editer,
            this.TLSTRIP_Cree,
            this.TLSTRIP_Deconnexion,
            this.TLSTRIP_Quitter});
            this.TLSTRIP_Compte.Name = "TLSTRIP_Compte";
            this.TLSTRIP_Compte.Size = new System.Drawing.Size(119, 20);
            this.TLSTRIP_Compte.Text = "Gestion de compte";
            // 
            // TLSTRIP_Connexion
            // 
            this.TLSTRIP_Connexion.Name = "TLSTRIP_Connexion";
            this.TLSTRIP_Connexion.Size = new System.Drawing.Size(178, 22);
            this.TLSTRIP_Connexion.Text = "Connexion";
            this.TLSTRIP_Connexion.Click += new System.EventHandler(this.TLSTRIP_Connexion_Click);
            // 
            // TLSTRIP_Editer
            // 
            this.TLSTRIP_Editer.Name = "TLSTRIP_Editer";
            this.TLSTRIP_Editer.Size = new System.Drawing.Size(178, 22);
            this.TLSTRIP_Editer.Text = "Éditer votre compte";
            this.TLSTRIP_Editer.Click += new System.EventHandler(this.TLSTRIP_Editer_Click);
            // 
            // TLSTRIP_Cree
            // 
            this.TLSTRIP_Cree.Name = "TLSTRIP_Cree";
            this.TLSTRIP_Cree.Size = new System.Drawing.Size(178, 22);
            this.TLSTRIP_Cree.Text = "Créer un compte";
            this.TLSTRIP_Cree.Click += new System.EventHandler(this.TLSTRIP_Cree_Click);
            // 
            // TLSTRIP_Deconnexion
            // 
            this.TLSTRIP_Deconnexion.Name = "TLSTRIP_Deconnexion";
            this.TLSTRIP_Deconnexion.Size = new System.Drawing.Size(178, 22);
            this.TLSTRIP_Deconnexion.Text = "Déconnexion";
            this.TLSTRIP_Deconnexion.Click += new System.EventHandler(this.TLSTRIP_Deconnexion_Click);
            // 
            // TLSTRIP_Quitter
            // 
            this.TLSTRIP_Quitter.Name = "TLSTRIP_Quitter";
            this.TLSTRIP_Quitter.Size = new System.Drawing.Size(178, 22);
            this.TLSTRIP_Quitter.Text = "Quitter";
            this.TLSTRIP_Quitter.Click += new System.EventHandler(this.TLSTRIP_Quitter_Click);
            // 
            // gestionDesPhotosToolStripMenuItem
            // 
            this.gestionDesPhotosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.effacerToolStripMenuItem});
            this.gestionDesPhotosToolStripMenuItem.Name = "gestionDesPhotosToolStripMenuItem";
            this.gestionDesPhotosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionDesPhotosToolStripMenuItem.Text = "Gestion des photos";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.effacerToolStripMenuItem.Text = "Effacer";
            this.effacerToolStripMenuItem.Click += new System.EventHandler(this.effacerToolStripMenuItem_Click);
            // 
            // listeNoireToolStripMenuItem
            // 
            this.listeNoireToolStripMenuItem.Name = "listeNoireToolStripMenuItem";
            this.listeNoireToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.listeNoireToolStripMenuItem.Text = "Liste noire";
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.rotationToolStripMenuItem.Text = "Mise-en-page";
            this.rotationToolStripMenuItem.Click += new System.EventHandler(this.rotationToolStripMenuItem_Click);
            // 
            // CMB_UsersList
            // 
            this.CMB_UsersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_UsersList.FormattingEnabled = true;
            this.CMB_UsersList.Location = new System.Drawing.Point(10, 41);
            this.CMB_UsersList.Name = "CMB_UsersList";
            this.CMB_UsersList.Size = new System.Drawing.Size(172, 21);
            this.CMB_UsersList.TabIndex = 1;
            this.CMB_UsersList.SelectedIndexChanged += new System.EventHandler(this.CMB_UsersList_SelectedIndexChanged);
            // 
            // TBX_MotsCles
            // 
            this.TBX_MotsCles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBX_MotsCles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBX_MotsCles.Location = new System.Drawing.Point(10, 49);
            this.TBX_MotsCles.Name = "TBX_MotsCles";
            this.TBX_MotsCles.Size = new System.Drawing.Size(169, 20);
            this.TBX_MotsCles.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBOX_NotMine);
            this.groupBox1.Controls.Add(this.CMB_UsersList);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilisateurs";
            // 
            // CBOX_NotMine
            // 
            this.CBOX_NotMine.AutoSize = true;
            this.CBOX_NotMine.Location = new System.Drawing.Point(10, 19);
            this.CBOX_NotMine.Name = "CBOX_NotMine";
            this.CBOX_NotMine.Size = new System.Drawing.Size(118, 17);
            this.CBOX_NotMine.TabIndex = 2;
            this.CBOX_NotMine.Text = "Exclure mes photos";
            this.CBOX_NotMine.UseVisualStyleBackColor = true;
            this.CBOX_NotMine.CheckedChanged += new System.EventHandler(this.CBOX_NotMine_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.FBTN_EffacerMotCle);
            this.groupBox2.Controls.Add(this.FBTN_AjouterMotCle);
            this.groupBox2.Controls.Add(this.LBX_MotsCles);
            this.groupBox2.Controls.Add(this.CBX_MotsCles);
            this.groupBox2.Controls.Add(this.TBX_MotsCles);
            this.groupBox2.Location = new System.Drawing.Point(13, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 312);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mots-clés";
            // 
            // LBX_MotsCles
            // 
            this.LBX_MotsCles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBX_MotsCles.FormattingEnabled = true;
            this.LBX_MotsCles.Location = new System.Drawing.Point(10, 72);
            this.LBX_MotsCles.Name = "LBX_MotsCles";
            this.LBX_MotsCles.Size = new System.Drawing.Size(169, 225);
            this.LBX_MotsCles.TabIndex = 4;
            // 
            // CBX_MotsCles
            // 
            this.CBX_MotsCles.AutoSize = true;
            this.CBX_MotsCles.Location = new System.Drawing.Point(10, 23);
            this.CBX_MotsCles.Name = "CBX_MotsCles";
            this.CBX_MotsCles.Size = new System.Drawing.Size(15, 14);
            this.CBX_MotsCles.TabIndex = 3;
            this.CBX_MotsCles.UseVisualStyleBackColor = true;
            this.CBX_MotsCles.CheckedChanged += new System.EventHandler(this.CBX_MotsCles_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBX_Date);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.DTP_Fin);
            this.groupBox3.Controls.Add(this.DTP_Debut);
            this.groupBox3.Location = new System.Drawing.Point(13, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 135);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date";
            // 
            // CBX_Date
            // 
            this.CBX_Date.AutoSize = true;
            this.CBX_Date.Location = new System.Drawing.Point(9, 20);
            this.CBX_Date.Name = "CBX_Date";
            this.CBX_Date.Size = new System.Drawing.Size(15, 14);
            this.CBX_Date.TabIndex = 10;
            this.CBX_Date.UseVisualStyleBackColor = true;
            this.CBX_Date.CheckedChanged += new System.EventHandler(this.CBX_Date_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date début";
            // 
            // DTP_Fin
            // 
            this.DTP_Fin.Location = new System.Drawing.Point(10, 100);
            this.DTP_Fin.Name = "DTP_Fin";
            this.DTP_Fin.Size = new System.Drawing.Size(169, 20);
            this.DTP_Fin.TabIndex = 7;
            this.DTP_Fin.ValueChanged += new System.EventHandler(this.DTP_Fin_ValueChanged);
            // 
            // DTP_Debut
            // 
            this.DTP_Debut.Location = new System.Drawing.Point(9, 64);
            this.DTP_Debut.Name = "DTP_Debut";
            this.DTP_Debut.Size = new System.Drawing.Size(169, 20);
            this.DTP_Debut.TabIndex = 6;
            this.DTP_Debut.ValueChanged += new System.EventHandler(this.DTP_Debut_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FTBN_Info);
            this.groupBox4.Controls.Add(this.FBTN_Modifier);
            this.groupBox4.Controls.Add(this.FBTN_Ajouter);
            this.groupBox4.Controls.Add(this.FTBN_Effacer);
            this.groupBox4.Location = new System.Drawing.Point(218, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 69);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Photo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FBTN_EditerCarousel);
            this.groupBox5.Controls.Add(this.FBTN_Carousel);
            this.groupBox5.Location = new System.Drawing.Point(459, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 69);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carousel";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.FBTN_MiseEnPage);
            this.groupBox8.Location = new System.Drawing.Point(975, 31);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(85, 68);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mise-en-page";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Username);
            this.groupBox6.Controls.Add(this.IMB_UserAvatar);
            this.groupBox6.Location = new System.Drawing.Point(595, 34);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(368, 65);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Utilisateur";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(51, 28);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(133, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Aucun utilisateur connecté";
            // 
            // IMB_UserAvatar
            // 
            this.IMB_UserAvatar.AllowDrop = true;
            this.IMB_UserAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IMB_UserAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMB_UserAvatar.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IMB_UserAvatar.ImportImageText = "Import image from file...";
            this.IMB_UserAvatar.Location = new System.Drawing.Point(15, 19);
            this.IMB_UserAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.IMB_UserAvatar.Name = "IMB_UserAvatar";
            this.IMB_UserAvatar.OpenFileDialogTitle = "Please choose image an file";
            this.IMB_UserAvatar.PasteMenuText = "Paste image from clipboard";
            this.IMB_UserAvatar.Size = new System.Drawing.Size(33, 32);
            this.IMB_UserAvatar.TabIndex = 0;
            this.IMB_UserAvatar.TabStop = false;
            // 
            // FBTN_MiseEnPage
            // 
            this.FBTN_MiseEnPage.BackgroundImage = global::Client_PM.Properties.Resources.rotate;
            this.FBTN_MiseEnPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_MiseEnPage.ClickedImage = global::Client_PM.Properties.Resources.rotate_accept;
            this.FBTN_MiseEnPage.DisabledImage = global::Client_PM.Properties.Resources.rotate;
            this.FBTN_MiseEnPage.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_MiseEnPage.Image")));
            this.FBTN_MiseEnPage.Location = new System.Drawing.Point(27, 19);
            this.FBTN_MiseEnPage.Name = "FBTN_MiseEnPage";
            this.FBTN_MiseEnPage.NeutralImage = global::Client_PM.Properties.Resources.rotate;
            this.FBTN_MiseEnPage.OverImage = global::Client_PM.Properties.Resources.rotate_accept;
            this.FBTN_MiseEnPage.Size = new System.Drawing.Size(32, 31);
            this.FBTN_MiseEnPage.TabIndex = 7;
            this.FBTN_MiseEnPage.Text = "Changer la mise-en-page";
            this.FBTN_MiseEnPage.UseVisualStyleBackColor = true;
            this.FBTN_MiseEnPage.Click += new System.EventHandler(this.FBTN_MiseEnPage_Click);
            // 
            // FBTN_EditerCarousel
            // 
            this.FBTN_EditerCarousel.BackgroundImage = global::Client_PM.Properties.Resources.edit;
            this.FBTN_EditerCarousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_EditerCarousel.ClickedImage = global::Client_PM.Properties.Resources.edit_accept;
            this.FBTN_EditerCarousel.DisabledImage = global::Client_PM.Properties.Resources.edit_disable;
            this.FBTN_EditerCarousel.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_EditerCarousel.Image")));
            this.FBTN_EditerCarousel.Location = new System.Drawing.Point(75, 22);
            this.FBTN_EditerCarousel.Margin = new System.Windows.Forms.Padding(2);
            this.FBTN_EditerCarousel.Name = "FBTN_EditerCarousel";
            this.FBTN_EditerCarousel.NeutralImage = global::Client_PM.Properties.Resources.edit;
            this.FBTN_EditerCarousel.OverImage = global::Client_PM.Properties.Resources.edit_accept;
            this.FBTN_EditerCarousel.Size = new System.Drawing.Size(32, 31);
            this.FBTN_EditerCarousel.TabIndex = 0;
            this.FBTN_EditerCarousel.Text = "Éditer le carousel";
            this.FBTN_EditerCarousel.UseVisualStyleBackColor = true;
            this.FBTN_EditerCarousel.Click += new System.EventHandler(this.FBTN_EditCarousel_Click);
            // 
            // FBTN_Carousel
            // 
            this.FBTN_Carousel.BackgroundImage = global::Client_PM.Properties.Resources.carousel;
            this.FBTN_Carousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Carousel.ClickedImage = null;
            this.FBTN_Carousel.DisabledImage = null;
            this.FBTN_Carousel.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Carousel.Image")));
            this.FBTN_Carousel.Location = new System.Drawing.Point(19, 23);
            this.FBTN_Carousel.Margin = new System.Windows.Forms.Padding(2);
            this.FBTN_Carousel.Name = "FBTN_Carousel";
            this.FBTN_Carousel.NeutralImage = null;
            this.FBTN_Carousel.OverImage = null;
            this.FBTN_Carousel.Size = new System.Drawing.Size(32, 31);
            this.FBTN_Carousel.TabIndex = 0;
            this.FBTN_Carousel.Text = "Visionner le carousel";
            this.FBTN_Carousel.UseVisualStyleBackColor = true;
            this.FBTN_Carousel.Click += new System.EventHandler(this.FBTN_Carousel_Click);
            // 
            // FTBN_Info
            // 
            this.FTBN_Info.BackgroundImage = global::Client_PM.Properties.Resources.ICON_Nouveau_Neutral;
            this.FTBN_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FTBN_Info.ClickedImage = global::Client_PM.Properties.Resources.ICON_Nouveau_Click;
            this.FTBN_Info.DisabledImage = global::Client_PM.Properties.Resources.ICON_Nouveau_Disable;
            this.FTBN_Info.Image = ((System.Drawing.Image)(resources.GetObject("FTBN_Info.Image")));
            this.FTBN_Info.Location = new System.Drawing.Point(176, 19);
            this.FTBN_Info.Name = "FTBN_Info";
            this.FTBN_Info.NeutralImage = global::Client_PM.Properties.Resources.ICON_Nouveau_Neutral;
            this.FTBN_Info.OverImage = global::Client_PM.Properties.Resources.ICON_Nouveau_Over;
            this.FTBN_Info.Size = new System.Drawing.Size(32, 31);
            this.FTBN_Info.TabIndex = 11;
            this.FTBN_Info.Text = "Informations sur la photo";
            this.FTBN_Info.UseVisualStyleBackColor = true;
            this.FTBN_Info.Click += new System.EventHandler(this.FTBN_Info_Click);
            // 
            // FBTN_Modifier
            // 
            this.FBTN_Modifier.BackgroundImage = global::Client_PM.Properties.Resources.edit;
            this.FBTN_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Modifier.ClickedImage = global::Client_PM.Properties.Resources.edit_accept;
            this.FBTN_Modifier.DisabledImage = global::Client_PM.Properties.Resources.edit_disable;
            this.FBTN_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Modifier.Image")));
            this.FBTN_Modifier.Location = new System.Drawing.Point(75, 19);
            this.FBTN_Modifier.Name = "FBTN_Modifier";
            this.FBTN_Modifier.NeutralImage = global::Client_PM.Properties.Resources.edit;
            this.FBTN_Modifier.OverImage = global::Client_PM.Properties.Resources.edit_accept;
            this.FBTN_Modifier.Size = new System.Drawing.Size(32, 31);
            this.FBTN_Modifier.TabIndex = 10;
            this.FBTN_Modifier.Text = "Éditer la photo sélectionnée";
            this.FBTN_Modifier.UseVisualStyleBackColor = true;
            this.FBTN_Modifier.Click += new System.EventHandler(this.FBTN_Modifier_Click);
            // 
            // FBTN_Ajouter
            // 
            this.FBTN_Ajouter.BackgroundImage = global::Client_PM.Properties.Resources.add;
            this.FBTN_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Ajouter.ClickedImage = global::Client_PM.Properties.Resources.add_accept;
            this.FBTN_Ajouter.DisabledImage = global::Client_PM.Properties.Resources.add_disable;
            this.FBTN_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Ajouter.Image")));
            this.FBTN_Ajouter.Location = new System.Drawing.Point(23, 19);
            this.FBTN_Ajouter.Name = "FBTN_Ajouter";
            this.FBTN_Ajouter.NeutralImage = global::Client_PM.Properties.Resources.add;
            this.FBTN_Ajouter.OverImage = global::Client_PM.Properties.Resources.add_accept;
            this.FBTN_Ajouter.Size = new System.Drawing.Size(32, 31);
            this.FBTN_Ajouter.TabIndex = 9;
            this.FBTN_Ajouter.Text = "Ajouter une photo";
            this.FBTN_Ajouter.UseVisualStyleBackColor = true;
            this.FBTN_Ajouter.Click += new System.EventHandler(this.FBTN_Ajouter_Click);
            // 
            // FTBN_Effacer
            // 
            this.FTBN_Effacer.BackgroundImage = global::Client_PM.Properties.Resources.trash;
            this.FTBN_Effacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FTBN_Effacer.ClickedImage = global::Client_PM.Properties.Resources.trash_accept;
            this.FTBN_Effacer.DisabledImage = global::Client_PM.Properties.Resources.trash_disable;
            this.FTBN_Effacer.Image = ((System.Drawing.Image)(resources.GetObject("FTBN_Effacer.Image")));
            this.FTBN_Effacer.Location = new System.Drawing.Point(126, 19);
            this.FTBN_Effacer.Name = "FTBN_Effacer";
            this.FTBN_Effacer.NeutralImage = global::Client_PM.Properties.Resources.trash;
            this.FTBN_Effacer.OverImage = global::Client_PM.Properties.Resources.trash_accept;
            this.FTBN_Effacer.Size = new System.Drawing.Size(32, 31);
            this.FTBN_Effacer.TabIndex = 8;
            this.FTBN_Effacer.Text = "Retirer la photo sélectionnée";
            this.FTBN_Effacer.UseVisualStyleBackColor = true;
            this.FTBN_Effacer.Click += new System.EventHandler(this.FTBN_Effacer_Click);
            // 
            // photosBrowser
            // 
            this.photosBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photosBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.photosBrowser.Location = new System.Drawing.Point(218, 106);
            this.photosBrowser.Name = "photosBrowser";
            this.photosBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.photosBrowser.SelectedPhoto = null;
            this.photosBrowser.Size = new System.Drawing.Size(842, 449);
            this.photosBrowser.TabIndex = 8;
            // 
            // FBTN_EffacerMotCle
            // 
            this.FBTN_EffacerMotCle.BackgroundImage = global::Client_PM.Properties.Resources.trash;
            this.FBTN_EffacerMotCle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_EffacerMotCle.ClickedImage = null;
            this.FBTN_EffacerMotCle.DisabledImage = null;
            this.FBTN_EffacerMotCle.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_EffacerMotCle.Image")));
            this.FBTN_EffacerMotCle.Location = new System.Drawing.Point(151, 16);
            this.FBTN_EffacerMotCle.Name = "FBTN_EffacerMotCle";
            this.FBTN_EffacerMotCle.NeutralImage = null;
            this.FBTN_EffacerMotCle.OverImage = null;
            this.FBTN_EffacerMotCle.Size = new System.Drawing.Size(27, 26);
            this.FBTN_EffacerMotCle.TabIndex = 10;
            this.FBTN_EffacerMotCle.Text = "Retirer un mot-clé";
            this.FBTN_EffacerMotCle.UseVisualStyleBackColor = true;
            this.FBTN_EffacerMotCle.Click += new System.EventHandler(this.FBTN_EffacerMotCle_Click);
            // 
            // FBTN_AjouterMotCle
            // 
            this.FBTN_AjouterMotCle.BackgroundImage = global::Client_PM.Properties.Resources.ICON_Ajouter_Neutral;
            this.FBTN_AjouterMotCle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_AjouterMotCle.ClickedImage = null;
            this.FBTN_AjouterMotCle.DisabledImage = null;
            this.FBTN_AjouterMotCle.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_AjouterMotCle.Image")));
            this.FBTN_AjouterMotCle.Location = new System.Drawing.Point(119, 16);
            this.FBTN_AjouterMotCle.Name = "FBTN_AjouterMotCle";
            this.FBTN_AjouterMotCle.NeutralImage = null;
            this.FBTN_AjouterMotCle.OverImage = null;
            this.FBTN_AjouterMotCle.Size = new System.Drawing.Size(27, 26);
            this.FBTN_AjouterMotCle.TabIndex = 9;
            this.FBTN_AjouterMotCle.Text = "Ajouter un mot-clé";
            this.FBTN_AjouterMotCle.UseVisualStyleBackColor = true;
            this.FBTN_AjouterMotCle.Click += new System.EventHandler(this.FBTN_Ajouter_MotCle_Click);
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 567);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.photosBrowser);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1071, 571);
            this.Name = "PagePrincipale";
            this.Text = "Prototype";
            this.Load += new System.EventHandler(this.PagePrincipale_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMB_UserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TLSTRIP_Compte;
        private System.Windows.Forms.ToolStripMenuItem TLSTRIP_Connexion;
        private System.Windows.Forms.ToolStripMenuItem TLSTRIP_Editer;
        private System.Windows.Forms.ToolStripMenuItem TLSTRIP_Cree;
        private System.Windows.Forms.ToolStripMenuItem TLSTRIP_Quitter;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToolStripMenuItem;
        private System.Windows.Forms.ComboBox CMB_UsersList;
        private System.Windows.Forms.TextBox TBX_MotsCles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_Fin;
        private System.Windows.Forms.DateTimePicker DTP_Debut;
        private PhotoManagerClient.FlashButton FBTN_MiseEnPage;
        private System.Windows.Forms.ToolStripMenuItem listeNoireToolStripMenuItem;
        private System.Windows.Forms.CheckBox CBOX_NotMine;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ListBox LBX_MotsCles;
        private System.Windows.Forms.CheckBox CBX_MotsCles;
        private System.Windows.Forms.CheckBox CBX_Date;
        private PhotoManagerClient.PhotosBrowser photosBrowser;
        private PhotoManagerClient.FlashButton FBTN_AjouterMotCle;
        private System.Windows.Forms.GroupBox groupBox4;
        private PhotoManagerClient.FlashButton FBTN_EffacerMotCle;
        private PhotoManagerClient.FlashButton FBTN_Modifier;
        private PhotoManagerClient.FlashButton FBTN_Ajouter;
        private PhotoManagerClient.FlashButton FTBN_Effacer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ToolStripMenuItem TLSTRIP_Deconnexion;
        private PhotoManagerClient.FlashButton FBTN_Carousel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label Username;
        private PhotoManagerClient.ImageBox IMB_UserAvatar;
        private PhotoManagerClient.FlashButton FBTN_EditerCarousel;
        private PhotoManagerClient.FlashButton FTBN_Info;
    }
}