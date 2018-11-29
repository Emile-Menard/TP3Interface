namespace Client_PM
{
    partial class PageSlideShow
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
            this.SlideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SlideshowTimer
            // 
            this.SlideshowTimer.Interval = 5000;
            this.SlideshowTimer.Tick += new System.EventHandler(this.SlideshowTimer_Tick);
            // 
            // PageSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1201, 723);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "PageSlideShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide show";
            this.Shown += new System.EventHandler(this.DLG_Slideshow_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DLG_Slideshow_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SlideshowTimer;
    }
}