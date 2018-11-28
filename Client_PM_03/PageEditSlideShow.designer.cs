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
            this.SuspendLayout();
            // 
            // FLPN_Photos
            // 
            this.FLPN_Photos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPN_Photos.Location = new System.Drawing.Point(13, 13);
            this.FLPN_Photos.Name = "FLPN_Photos";
            this.FLPN_Photos.Size = new System.Drawing.Size(926, 424);
            this.FLPN_Photos.TabIndex = 0;
            // 
            // DLG_ManageSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 449);
            this.Controls.Add(this.FLPN_Photos);
            this.Name = "DLG_ManageSlideShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Silde Show";
            this.Shown += new System.EventHandler(this.DLG_ManageSildeShow_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPN_Photos;
    }
}