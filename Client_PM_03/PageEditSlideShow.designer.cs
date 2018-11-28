namespace Client_PM
{
    partial class PageEditSlideShow
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
            this.FLPN_Photos = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_ReinitCarousel = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FLPN_Photos
            // 
            this.FLPN_Photos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPN_Photos.Location = new System.Drawing.Point(13, 13);
            this.FLPN_Photos.Name = "FLPN_Photos";
            this.FLPN_Photos.Size = new System.Drawing.Size(926, 395);
            this.FLPN_Photos.TabIndex = 0;
            // 
            // BTN_ReinitCarousel
            // 
            this.BTN_ReinitCarousel.Location = new System.Drawing.Point(864, 418);
            this.BTN_ReinitCarousel.Name = "BTN_ReinitCarousel";
            this.BTN_ReinitCarousel.Size = new System.Drawing.Size(75, 23);
            this.BTN_ReinitCarousel.TabIndex = 1;
            this.BTN_ReinitCarousel.Text = "Réinitialiser";
            this.BTN_ReinitCarousel.UseVisualStyleBackColor = true;
            this.BTN_ReinitCarousel.Click += new System.EventHandler(this.BTN_ReinitCarousel_Click);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(765, 418);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 1;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // PageEditSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 449);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_ReinitCarousel);
            this.Controls.Add(this.FLPN_Photos);
            this.Name = "PageEditSlideShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Silde Show";
            this.Shown += new System.EventHandler(this.DLG_ManageSildeShow_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPN_Photos;
        private System.Windows.Forms.Button BTN_ReinitCarousel;
        private System.Windows.Forms.Button BTN_Ok;
    }
}