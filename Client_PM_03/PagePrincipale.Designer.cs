﻿namespace Client_PM
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
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retraitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.flashButton4 = new PhotoManagerClient.FlashButton();
            this.flashButton3 = new PhotoManagerClient.FlashButton();
            this.FBTN_Ajouter_MotCle = new PhotoManagerClient.FlashButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FBTN_Modifier = new PhotoManagerClient.FlashButton();
            this.FBTN_Ajouter = new PhotoManagerClient.FlashButton();
            this.FTBN_Effacer = new PhotoManagerClient.FlashButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.imageBox1 = new PhotoManagerClient.ImageBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.FBTN_MiseEnPage = new PhotoManagerClient.FlashButton();
            this.photosBrowser1 = new PhotoManagerClient.PhotosBrowser();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox8.SuspendLayout();
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
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.effacerToolStripMenuItem.Text = "Effacer";
            // 
            // listeNoireToolStripMenuItem
            // 
            this.listeNoireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.retraitToolStripMenuItem,
            this.réinitialisationToolStripMenuItem});
            this.listeNoireToolStripMenuItem.Name = "listeNoireToolStripMenuItem";
            this.listeNoireToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.listeNoireToolStripMenuItem.Text = "Liste noire";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            // 
            // retraitToolStripMenuItem
            // 
            this.retraitToolStripMenuItem.Name = "retraitToolStripMenuItem";
            this.retraitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.retraitToolStripMenuItem.Text = "Retrait";
            // 
            // réinitialisationToolStripMenuItem
            // 
            this.réinitialisationToolStripMenuItem.Name = "réinitialisationToolStripMenuItem";
            this.réinitialisationToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.réinitialisationToolStripMenuItem.Text = "Réinitialisation";
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hautToolStripMenuItem,
            this.basToolStripMenuItem,
            this.droiteToolStripMenuItem,
            this.gaucheToolStripMenuItem});
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.rotationToolStripMenuItem.Text = "Rotation";
            // 
            // hautToolStripMenuItem
            // 
            this.hautToolStripMenuItem.Name = "hautToolStripMenuItem";
            this.hautToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.hautToolStripMenuItem.Text = "Haut";
            // 
            // basToolStripMenuItem
            // 
            this.basToolStripMenuItem.Name = "basToolStripMenuItem";
            this.basToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.basToolStripMenuItem.Text = "Bas";
            // 
            // droiteToolStripMenuItem
            // 
            this.droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            this.droiteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.droiteToolStripMenuItem.Text = "Droite";
            // 
            // gaucheToolStripMenuItem
            // 
            this.gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            this.gaucheToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.gaucheToolStripMenuItem.Text = "Gauche";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(174, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilisateurs";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Exclure mes photos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.flashButton4);
            this.groupBox2.Controls.Add(this.flashButton3);
            this.groupBox2.Controls.Add(this.FBTN_Ajouter_MotCle);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(174, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 249);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mots-clés";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(141, 255);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(84, 65);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // flashButton4
            // 
            this.flashButton4.BackgroundImage = global::Client_PM.Properties.Resources.Recherche;
            this.flashButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton4.ClickedImage = null;
            this.flashButton4.DisabledImage = null;
            this.flashButton4.Image = ((System.Drawing.Image)(resources.GetObject("flashButton4.Image")));
            this.flashButton4.Location = new System.Drawing.Point(184, 20);
            this.flashButton4.Name = "flashButton4";
            this.flashButton4.NeutralImage = null;
            this.flashButton4.OverImage = null;
            this.flashButton4.Size = new System.Drawing.Size(32, 32);
            this.flashButton4.TabIndex = 11;
            this.flashButton4.Text = "flashButton4";
            this.flashButton4.UseVisualStyleBackColor = true;
            // 
            // flashButton3
            // 
            this.flashButton3.BackgroundImage = global::Client_PM.Properties.Resources.Delete;
            this.flashButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton3.ClickedImage = null;
            this.flashButton3.DisabledImage = null;
            this.flashButton3.Image = ((System.Drawing.Image)(resources.GetObject("flashButton3.Image")));
            this.flashButton3.Location = new System.Drawing.Point(184, 103);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.NeutralImage = null;
            this.flashButton3.OverImage = null;
            this.flashButton3.Size = new System.Drawing.Size(32, 32);
            this.flashButton3.TabIndex = 10;
            this.flashButton3.Text = "flashButton3";
            this.flashButton3.UseVisualStyleBackColor = true;
            // 
            // FBTN_Ajouter_MotCle
            // 
            this.FBTN_Ajouter_MotCle.BackgroundImage = global::Client_PM.Properties.Resources.Plus;
            this.FBTN_Ajouter_MotCle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Ajouter_MotCle.ClickedImage = null;
            this.FBTN_Ajouter_MotCle.DisabledImage = null;
            this.FBTN_Ajouter_MotCle.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Ajouter_MotCle.Image")));
            this.FBTN_Ajouter_MotCle.Location = new System.Drawing.Point(184, 65);
            this.FBTN_Ajouter_MotCle.Name = "FBTN_Ajouter_MotCle";
            this.FBTN_Ajouter_MotCle.NeutralImage = null;
            this.FBTN_Ajouter_MotCle.OverImage = null;
            this.FBTN_Ajouter_MotCle.Size = new System.Drawing.Size(32, 32);
            this.FBTN_Ajouter_MotCle.TabIndex = 9;
            this.FBTN_Ajouter_MotCle.Text = "flashButton2";
            this.FBTN_Ajouter_MotCle.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 160);
            this.listBox1.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(174, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 135);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date interval";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 20);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date début";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(72, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FBTN_Modifier);
            this.groupBox4.Controls.Add(this.FBTN_Ajouter);
            this.groupBox4.Controls.Add(this.FTBN_Effacer);
            this.groupBox4.Location = new System.Drawing.Point(174, 501);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(135, 69);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Photo";
            // 
            // FBTN_Modifier
            // 
            this.FBTN_Modifier.BackgroundImage = global::Client_PM.Properties.Resources.Editer;
            this.FBTN_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Modifier.ClickedImage = null;
            this.FBTN_Modifier.DisabledImage = null;
            this.FBTN_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Modifier.Image")));
            this.FBTN_Modifier.Location = new System.Drawing.Point(53, 21);
            this.FBTN_Modifier.Name = "FBTN_Modifier";
            this.FBTN_Modifier.NeutralImage = null;
            this.FBTN_Modifier.OverImage = null;
            this.FBTN_Modifier.Size = new System.Drawing.Size(32, 32);
            this.FBTN_Modifier.TabIndex = 10;
            this.FBTN_Modifier.Text = "Éditer la photo sélectionnée";
            this.FBTN_Modifier.UseVisualStyleBackColor = true;
            this.FBTN_Modifier.Click += new System.EventHandler(this.FBTN_Modifier_Click);
            // 
            // FBTN_Ajouter
            // 
            this.FBTN_Ajouter.BackgroundImage = global::Client_PM.Properties.Resources.Plus;
            this.FBTN_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Ajouter.ClickedImage = null;
            this.FBTN_Ajouter.DisabledImage = null;
            this.FBTN_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Ajouter.Image")));
            this.FBTN_Ajouter.Location = new System.Drawing.Point(15, 21);
            this.FBTN_Ajouter.Name = "FBTN_Ajouter";
            this.FBTN_Ajouter.NeutralImage = null;
            this.FBTN_Ajouter.OverImage = null;
            this.FBTN_Ajouter.Size = new System.Drawing.Size(32, 32);
            this.FBTN_Ajouter.TabIndex = 9;
            this.FBTN_Ajouter.Text = "Ajouter une photo";
            this.FBTN_Ajouter.UseVisualStyleBackColor = true;
            this.FBTN_Ajouter.Click += new System.EventHandler(this.FBTN_Ajouter_Click);
            // 
            // FTBN_Effacer
            // 
            this.FTBN_Effacer.BackgroundImage = global::Client_PM.Properties.Resources.Delete;
            this.FTBN_Effacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FTBN_Effacer.ClickedImage = null;
            this.FTBN_Effacer.DisabledImage = null;
            this.FTBN_Effacer.Image = ((System.Drawing.Image)(resources.GetObject("FTBN_Effacer.Image")));
            this.FTBN_Effacer.Location = new System.Drawing.Point(90, 21);
            this.FTBN_Effacer.Name = "FTBN_Effacer";
            this.FTBN_Effacer.NeutralImage = null;
            this.FTBN_Effacer.OverImage = null;
            this.FTBN_Effacer.Size = new System.Drawing.Size(32, 32);
            this.FTBN_Effacer.TabIndex = 8;
            this.FTBN_Effacer.Text = "Retirer la photo sélectionnée";
            this.FTBN_Effacer.UseVisualStyleBackColor = true;
            this.FTBN_Effacer.Click += new System.EventHandler(this.FTBN_Effacer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.listBox2);
            this.groupBox5.Location = new System.Drawing.Point(12, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 322);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carousel";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Réinitialiser";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Retirer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Visionner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(17, 143);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 160);
            this.listBox2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.imageBox1);
            this.groupBox6.Location = new System.Drawing.Point(12, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(156, 213);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nom d\'utilisateur";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Déconnexion";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Éditer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // imageBox1
            // 
            this.imageBox1.AllowDrop = true;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox1.ImportImageText = "Import image from file...";
            this.imageBox1.Location = new System.Drawing.Point(17, 22);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox1.PasteMenuText = "Paste image from clipboard";
            this.imageBox1.Size = new System.Drawing.Size(120, 115);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.FBTN_MiseEnPage);
            this.groupBox8.Location = new System.Drawing.Point(315, 503);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(85, 68);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mise-en-page";
            // 
            // FBTN_MiseEnPage
            // 
            this.FBTN_MiseEnPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FBTN_MiseEnPage.BackgroundImage")));
            this.FBTN_MiseEnPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_MiseEnPage.ClickedImage = null;
            this.FBTN_MiseEnPage.DisabledImage = null;
            this.FBTN_MiseEnPage.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_MiseEnPage.Image")));
            this.FBTN_MiseEnPage.Location = new System.Drawing.Point(27, 19);
            this.FBTN_MiseEnPage.Name = "FBTN_MiseEnPage";
            this.FBTN_MiseEnPage.NeutralImage = null;
            this.FBTN_MiseEnPage.OverImage = null;
            this.FBTN_MiseEnPage.Size = new System.Drawing.Size(36, 36);
            this.FBTN_MiseEnPage.TabIndex = 7;
            this.FBTN_MiseEnPage.Text = "Changer la mise-en-page";
            this.FBTN_MiseEnPage.UseVisualStyleBackColor = true;
            this.FBTN_MiseEnPage.Click += new System.EventHandler(this.FBTN_MiseEnPage_Click);
            // 
            // photosBrowser1
            // 
            this.photosBrowser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.photosBrowser1.Location = new System.Drawing.Point(406, 27);
            this.photosBrowser1.Name = "photosBrowser1";
            this.photosBrowser1.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.photosBrowser1.SelectedPhoto = null;
            this.photosBrowser1.Size = new System.Drawing.Size(691, 541);
            this.photosBrowser1.TabIndex = 8;
            this.photosBrowser1.SelectedChanged += new PhotoManagerClient.PhotosBrowser.SelectedChangedHandler(this.photosBrowser1_SelectedChanged);
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 573);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.photosBrowser1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox8.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private PhotoManagerClient.FlashButton FBTN_MiseEnPage;
        private System.Windows.Forms.ToolStripMenuItem listeNoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retraitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialisationToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaucheToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private PhotoManagerClient.PhotosBrowser photosBrowser1;
        private PhotoManagerClient.FlashButton FBTN_Ajouter_MotCle;
        private System.Windows.Forms.GroupBox groupBox4;
        private PhotoManagerClient.FlashButton flashButton3;
        private PhotoManagerClient.FlashButton flashButton4;
        private PhotoManagerClient.FlashButton FBTN_Modifier;
        private PhotoManagerClient.FlashButton FBTN_Ajouter;
        private PhotoManagerClient.FlashButton FTBN_Effacer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private PhotoManagerClient.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ToolStripMenuItem TLSTRIP_Deconnexion;
    }
}