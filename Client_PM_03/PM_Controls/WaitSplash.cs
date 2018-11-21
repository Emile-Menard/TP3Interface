using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManagerClient
{
    // Auteur: Nicolas Chourot
    public class WaitSplash : Form
    {
        static string _Message;
        static Form CallerForm;
        static Control _ActiveControl;
        public WaitSplash()
        {
            InitializeComponent();
            label1.Text = _Message;
            this.TopMost = true;
        }
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static WaitSplash waitSplash;
        private static Thread thread;
        static public void Show(Form callerForm, string message = "")
        {
            _Message = message;
            if (waitSplash != null)
                return;
            if (thread != null)
            {
                thread.Abort();
            }
            if (CallerForm != null)
            {
                CallerForm.BringToFront();
                //Thread.Sleep(100);
            }
            CallerForm = callerForm;
            thread = new Thread(ShowForm);
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            waitSplash = new WaitSplash();
            if (CallerForm != null)
                _ActiveControl = CallerForm.ActiveControl;
            Application.Run(waitSplash);
        }

        static public void Hide()
        {
            Thread.Sleep(100);
            if (waitSplash != null)
                waitSplash.Invoke(new CloseDelegate(WaitSplash.CloseFormInternal));

            if (CallerForm != null)
            {
               // Thread.Sleep(300);
                CallerForm.BringToFront();
                CallerForm.ActiveControl = _ActiveControl;
                CallerForm = null;
            }

            if (thread != null)
            {
                thread.Abort();
                thread = null;
            }
         }

        static private void CloseFormInternal()
        {
            waitSplash.Close();
            waitSplash = null;
        }
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please wait ...";
            // 
            // WaitSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(347, 95);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitSplash";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitSplah";
            this.Load += new System.EventHandler(this.WaitSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;

        private void WaitSplash_Load(object sender, EventArgs e)
        {
            if (CallerForm != null)
            {
                this.Location = new Point(CallerForm.Location.X + CallerForm.Width / 2 - waitSplash.Width / 2,
                                          CallerForm.Location.Y + CallerForm.Height / 2 - waitSplash.Height / 2);
            }
        }
    }
}
