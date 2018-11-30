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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSL_Aide = new System.Windows.Forms.ToolStripLabel();
            this.TSL_Next = new System.Windows.Forms.ToolStripLabel();
            this.TSL_Fullscreen = new System.Windows.Forms.ToolStripLabel();
            this.TSL_Random = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlideshowTimer
            // 
            this.SlideshowTimer.Interval = 5000;
            this.SlideshowTimer.Tick += new System.EventHandler(this.SlideshowTimer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_Aide,
            this.TSL_Next,
            this.TSL_Fullscreen,
            this.TSL_Random});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1802, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSL_Aide
            // 
            this.TSL_Aide.Name = "TSL_Aide";
            this.TSL_Aide.Size = new System.Drawing.Size(48, 25);
            this.TSL_Aide.Text = "Aide";
            // 
            // TSL_Next
            // 
            this.TSL_Next.Name = "TSL_Next";
            this.TSL_Next.Size = new System.Drawing.Size(143, 25);
            this.TSL_Next.Text = "Prochaine image";
            this.TSL_Next.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // TSL_Fullscreen
            // 
            this.TSL_Fullscreen.Name = "TSL_Fullscreen";
            this.TSL_Fullscreen.Size = new System.Drawing.Size(149, 25);
            this.TSL_Fullscreen.Text = "Mode plein écran";
            this.TSL_Fullscreen.Click += new System.EventHandler(this.TSL_Fullscreen_Click);
            // 
            // TSL_Random
            // 
            this.TSL_Random.Name = "TSL_Random";
            this.TSL_Random.Size = new System.Drawing.Size(130, 25);
            this.TSL_Random.Text = "Ordre aléatoire";
            this.TSL_Random.Click += new System.EventHandler(this.TSL_Random_Click);
            // 
            // PageSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1802, 1050);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PageSlideShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carousel (F1 pour aide)";
            this.Shown += new System.EventHandler(this.DLG_Slideshow_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DLG_Slideshow_KeyDown);
            this.Leave += new System.EventHandler(this.PageSlideShow_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer SlideshowTimer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel TSL_Aide;
        private System.Windows.Forms.ToolStripLabel TSL_Next;
        private System.Windows.Forms.ToolStripLabel TSL_Fullscreen;
        private System.Windows.Forms.ToolStripLabel TSL_Random;
    }
}