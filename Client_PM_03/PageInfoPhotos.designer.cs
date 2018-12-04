namespace Client_PM
{
    partial class PageInfoPhotos
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
            this.LBX_MotsCles = new System.Windows.Forms.ListBox();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.CBX_Partager = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_Titre = new System.Windows.Forms.TextBox();
            this.IB_Image = new PhotoManagerClient.ImageBox();
            this.infos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // LBX_MotsCles
            // 
            this.LBX_MotsCles.FormattingEnabled = true;
            this.LBX_MotsCles.ItemHeight = 20;
            this.LBX_MotsCles.Location = new System.Drawing.Point(22, 352);
            this.LBX_MotsCles.Name = "LBX_MotsCles";
            this.LBX_MotsCles.Size = new System.Drawing.Size(283, 124);
            this.LBX_MotsCles.TabIndex = 29;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(24, 494);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(284, 52);
            this.BTN_Ok.TabIndex = 28;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // CBX_Partager
            // 
            this.CBX_Partager.AutoSize = true;
            this.CBX_Partager.Enabled = false;
            this.CBX_Partager.Location = new System.Drawing.Point(214, 49);
            this.CBX_Partager.Name = "CBX_Partager";
            this.CBX_Partager.Size = new System.Drawing.Size(91, 24);
            this.CBX_Partager.TabIndex = 25;
            this.CBX_Partager.Text = "Partagé";
            this.CBX_Partager.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mots-clés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Description";
            // 
            // RTB_Description
            // 
            this.RTB_Description.AcceptsTab = true;
            this.RTB_Description.Location = new System.Drawing.Point(24, 197);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.ReadOnly = true;
            this.RTB_Description.Size = new System.Drawing.Size(283, 112);
            this.RTB_Description.TabIndex = 21;
            this.RTB_Description.Text = "";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Enabled = false;
            this.DTP_Date.Location = new System.Drawing.Point(24, 122);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(283, 26);
            this.DTP_Date.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Titre";
            // 
            // TBX_Titre
            // 
            this.TBX_Titre.Location = new System.Drawing.Point(24, 46);
            this.TBX_Titre.Name = "TBX_Titre";
            this.TBX_Titre.ReadOnly = true;
            this.TBX_Titre.Size = new System.Drawing.Size(169, 26);
            this.TBX_Titre.TabIndex = 17;
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
            this.IB_Image.Location = new System.Drawing.Point(334, 23);
            this.IB_Image.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.IB_Image.Name = "IB_Image";
            this.IB_Image.OpenFileDialogTitle = "Please choose image an file";
            this.IB_Image.PasteMenuText = "Paste image from clipboard";
            this.IB_Image.Size = new System.Drawing.Size(443, 454);
            this.IB_Image.TabIndex = 16;
            this.IB_Image.TabStop = false;
            // 
            // infos
            // 
            this.infos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infos.AutoSize = true;
            this.infos.Location = new System.Drawing.Point(330, 511);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(180, 20);
            this.infos.TabIndex = 30;
            this.infos.Text = "par Auteur - Dimensions";
            // 
            // PageInfoPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 562);
            this.Controls.Add(this.infos);
            this.Controls.Add(this.LBX_MotsCles);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.CBX_Partager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTB_Description);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Titre);
            this.Controls.Add(this.IB_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(823, 618);
            this.Name = "PageInfoPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PageInfoPhotos_FormClosing);
            this.Load += new System.EventHandler(this.PageInfoPhotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBX_MotsCles;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.CheckBox CBX_Partager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_Titre;
        private PhotoManagerClient.ImageBox IB_Image;
        private System.Windows.Forms.Label infos;
    }
}