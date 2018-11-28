using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    // Panneau de photo sélectionnable
    // Utiliser par DLG_ManageSlideShow
    public class PhotoPanel : Panel
    {
        public PhotoPanel() : base() { Selected = false; }
        public bool Selected { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Selected)
            {
                Rectangle border = new Rectangle(new Point(3, 3), new Size(Size.Width - 6, Size.Height - 6));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 6), border);
            }
        }
    }
}
