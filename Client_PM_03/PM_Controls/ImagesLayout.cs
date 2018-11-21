using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitmapExtension;
using System.Drawing.Imaging;

namespace PhotoManagerClient
{
    /// <summary>
    /// Contrôle d'affichage de photo utilisé par le fureteur de photos PhotosBrowser
    /// 
    /// Auteur: Nicolas Chourot
    /// </summary>
    public class PhotoBox : PictureBox
    {
        /// <summary>
        /// Référence sur la photo
        /// </summary>
        public Photo Photo { get; set; }

        private bool _Selected;
        private bool _Overed { get; set; }

        /// <summary>
        /// Indicateur de sélection
        /// </summary>
        public bool Selected { get { return _Selected; } set { _Selected = value; Refresh(); } }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="photo">photo</param>
        public PhotoBox(Photo photo) : base()
        {
            _Selected = false;
            _Overed = false;
            Photo = photo;
            BackgroundImageLayout = ImageLayout.Zoom;
            Size = new System.Drawing.Size(78, 78);
            if (Photo != null)
            {
                BackgroundImage = photo.GetThumbnailImage();
                ToolTip tp = new ToolTip();
                tp.SetToolTip(this, Photo.Title);
            }
        }

        /// <summary>
        /// Réglage du dellegate de l'événement clic
        /// </summary>
        /// <param name="clickHandler"></param>
        public void SetClickListener(EventHandler clickHandler)
        {
            this.Click += clickHandler;
        }

        private void DrawBorder(Graphics DC, Color color)
        {
            Rectangle border = new Rectangle(new Point(0, 0), Size);
            border.Inflate(-1, -1);
            DC.DrawRectangle(new Pen(color, 4), border);
        }

        /// <summary>
        /// Surchage
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (_Selected)
            {
                DrawBorder(pe.Graphics, Color.Black);
            }
            if (_Overed)
            {
                DrawBorder(pe.Graphics, Color.Gray);
            }
        }

        /// <summary>
        /// Surchage
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _Overed = true;
            Refresh();
        }
        /// <summary>
        /// Surchage
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _Overed = false;
            Refresh();
        }
        private void UnselectBrothers()
        {
            if (Parent != null)
            {
                foreach (PhotoBox photoBox in Parent.Controls)
                {
                    if (photoBox.Selected)
                    {
                        photoBox.Selected = false;
                    }
                }
            }
        }

        /// <summary>
        /// Sélectionner la photo
        /// </summary>
        public void Select()
        {
            bool wasSelected = _Selected;
            UnselectBrothers();

            Selected = true;
            if (Parent != null && !wasSelected)
            {
                ((ImagesLayout)Parent).SelectedPhotoBox = this;
            }
        }

        /// <summary>
        /// Surchage
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Select();
        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoBox
            // 
            this.Size = new System.Drawing.Size(80, 80);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }
    }

    /// <summary>
    /// Argument d'événement du contrôle ImagesLayout
    /// 
    /// Auteur: Nicolas Chourot
    /// </summary>
    public class ImageLayoutEventArgs : EventArgs
    {
        /// <summary>
        /// Boite de photo ciblée
        /// </summary>
        public PhotoBox TargetPhotoBox { get; set; }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="targetPhotoBox"></param>
        public ImageLayoutEventArgs(PhotoBox targetPhotoBox) : base()
        {
            TargetPhotoBox = targetPhotoBox;
        }
    }

    /// <summary>
    /// Contrôle de regroupement de miniatures de photo
    /// utilisé par le fureteur de photos PhotoBrowser
    /// 
    /// Auteur: Nicolas Chourot
    /// </summary>
    [DefaultEvent("SelectedChanged")]
    public class ImagesLayout : FlowLayoutPanel
    {
        /// <summary>
        /// Prototype d'événement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void SelectedChangedHandler(object sender, ImageLayoutEventArgs e);

        /// <summary>
        /// Gestionnaire d'événement
        /// </summary>
        public event SelectedChangedHandler SelectedChanged = null;

        /// <summary>
        /// Référence sur la boite de photo sélectionnée
        /// </summary>
        private PhotoBox _SelectedPhotoBox;

        /// <summary>
        /// Référence sur la boite de photo sélectionnée
        /// </summary>
        public PhotoBox SelectedPhotoBox
        {
            get
            {
                return _SelectedPhotoBox;
            }
            set
            {
                _SelectedPhotoBox = value;
                foreach (PhotoBox photoBox in Controls)
                {
                    photoBox.Selected = photoBox == _SelectedPhotoBox;
                }
                OnSelectedChanged(_SelectedPhotoBox);
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public ImagesLayout() : base()
        {
            _SelectedPhotoBox = null;
            WrapContents = false;
            AutoScroll = true;
            FlowDirection = FlowDirection.TopDown;
        }

        /// <summary>
        /// Surchage
        /// </summary>
        /// <param name="eventargs"></param>
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            if (ClientRectangle.Width > ClientRectangle.Height)
            {
                FlowDirection = FlowDirection.LeftToRight;
            }
            else
            {
                FlowDirection = FlowDirection.TopDown;
            }
            if (SelectedPhotoBox != null)
                SelectPhoto(SelectedPhotoBox.Photo);
        }

        private void ImagesLayout_Click(object sender, EventArgs e)
        {
            OnClick(e);
            Parent.Focus();
        }
 
        /// <summary>
        /// Ajout d'une photo
        /// </summary>
        /// <param name="photo"></param>
        public void AddPhoto(Photo photo)
        {
            PhotoBox photoBox = new PhotoBox(photo);
            photoBox.SetClickListener(ImagesLayout_Click);
            Controls.Add(photoBox);
        }

        /// <summary>
        /// Sélectionne la boite de photo correspondant à la photo
        /// </summary>
        /// <param name="photo"></param>
        public void SelectPhoto(Photo photo)
        {
            foreach (PhotoBox photoBox in Controls)
            {
                if (photoBox.Photo == photo)
                {
                    photoBox.Select();
                    this.ScrollControlIntoView(photoBox);

                    break;
                }
            }
        }
 
        /// <summary>
        /// Vider le regroupement de boites de photo
        /// </summary>
        public void Clear()
        {
            Controls.Clear();
            SelectedPhotoBox = null;
        }

        /// <summary>
        /// Retirer la boite de photo sélectionnée
        /// </summary>
        public void RemoveSelected()
        {
            foreach (PhotoBox photoBox in Controls)
            {
                if (photoBox.Selected)
                {
                    Controls.Remove(photoBox);
                    SelectedPhotoBox = null;
                    break;
                }
            }
        }

        /// <summary>
        /// Sélectionner la boite de photo suivante
        /// </summary>
        public void SelectNext()
        {
            if (Controls.Count > 0)
            {
                if (SelectedPhotoBox == null)
                {
                    ((PhotoBox)Controls[0]).Select();
                }
                else
                {
                    int selectedIndex = Controls.IndexOf(SelectedPhotoBox);
                    if (selectedIndex < Controls.Count - 1)
                        selectedIndex++;
                    else
                        selectedIndex = 0;
                    ((PhotoBox)Controls[selectedIndex]).Select();
                }
            }
        }

        /// <summary>
        /// Sélectionner la boite de phot précédente
        /// </summary>
        public void SelectPrevious()
        {
            if (Controls.Count > 0)
            {
                if (SelectedPhotoBox == null)
                {
                    ((PhotoBox)Controls[Controls.Count - 1]).Select();
                }
                else
                {
                    int selectedIndex = Controls.IndexOf(SelectedPhotoBox);
                    if (selectedIndex > 0)
                        selectedIndex--;
                    else
                        selectedIndex = Controls.Count - 1;
                    ((PhotoBox)Controls[selectedIndex]).Select();
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événement 
        /// </summary>
        /// <param name="targetedPhotoBox">Boite de photo ciblée</param>
        public void OnSelectedChanged(PhotoBox targetedPhotoBox)
        {
            if (SelectedChanged != null)
                SelectedChanged(this, new ImageLayoutEventArgs(targetedPhotoBox));
        }
    }
}
