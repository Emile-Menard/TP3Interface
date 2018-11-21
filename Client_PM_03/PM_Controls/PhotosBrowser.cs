using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManagerClient
{
    /// <summary>
    /// Enum énumérant les réglages de placement du fureteur de photos
    /// </summary>
    public enum PhotoBrowserPlacement
    {
        /// <summary>
        /// à gauche
        /// </summary>
        Left,
        /// <summary>
        /// en haut
        /// </summary>
        Top,
        /// <summary>
        /// à droite
        /// </summary>
        Right,
        /// <summary>
        /// en bas
        /// </summary>
        Bottom
    }
    /// <summary>
    /// Contrôle "Fureteur de photos". Elle affiche les miniatures des photos et affiche l'image originale du miniature sélectioné.
    /// Dépendances: Photo, ImageBox, ImagesLayout, DBPhotosWebServices, WaitSplash
    /// 
    /// Auteur: Nicolas Chourot
    /// </summary>
    [DefaultEvent("SelectedChanged")]
    class PhotosBrowser : UserControl
    {
        private const int space = 105;
        private const int margin = 6;

        private PhotoBrowserPlacement _PhotoBrowserPlacement = PhotoBrowserPlacement.Left;

        /// <summary>
        /// Réglage du placement du fureteur de photos
        /// </summary>
        [Description("Get, Set the photo browser placement"), Category("Layout")]
        public PhotoBrowserPlacement Placement
        {
            get
            {
                return _PhotoBrowserPlacement;
            }
            set
            {
                _PhotoBrowserPlacement = value;
                switch (_PhotoBrowserPlacement)
                {
                    case PhotoBrowserPlacement.Left:
                        PhotosList.Location = new Point(0, 0);
                        PhotosList.Width = space;
                        PhotosList.Height = Height;

                        PBX_SelectedPhoto.Location = new Point(PhotosList.Width + margin, 0);
                        PBX_SelectedPhoto.Width = Width - PhotosList.Width - margin;
                        PBX_SelectedPhoto.Height = Height;
                        break;

                    case PhotoBrowserPlacement.Right:
                        PhotosList.Location = new Point(Width - space, 0);
                        PhotosList.Width = space;
                        PhotosList.Height = this.Height;

                        PBX_SelectedPhoto.Location = new Point(0, 0);
                        PBX_SelectedPhoto.Width = Width - PhotosList.Width - margin;
                        PBX_SelectedPhoto.Height = Height;
                        break;

                    case PhotoBrowserPlacement.Top:
                        PhotosList.Location = new Point(0, 0);
                        PhotosList.Width = Width;
                        PhotosList.Height = space;

                        PBX_SelectedPhoto.Location = new Point(0, PhotosList.Height + margin);
                        PBX_SelectedPhoto.Width = Width;
                        PBX_SelectedPhoto.Height = Height - PhotosList.Height - margin;
                        break;

                    case PhotoBrowserPlacement.Bottom:
                        PhotosList.Location = new Point(0, Height - space);
                        PhotosList.Width = Width;
                        PhotosList.Height = space;

                        PBX_SelectedPhoto.Location = new Point(0, 0);
                        PBX_SelectedPhoto.Width = Width;
                        PBX_SelectedPhoto.Height = Height - PhotosList.Height - margin;
                        break;
                }
            }
        }

        private PictureBox PBX_SelectedPhoto;
        private PhotoManagerClient.ImagesLayout PhotosList;

        /// <summary>
        /// Prototype de gestionnaire d'événement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void SelectedChangedHandler(object sender, EventArgs e);

        /// <summary>
        /// Gestionnaire de l'événement qui survient lorsqu'il y a un changement de sélection de miniature de photo
        /// </summary>
        public event SelectedChangedHandler SelectedChanged = null;
        private Photo _SelectedPhoto = null;

        private void InitializeComponent()
        {
            this.PBX_SelectedPhoto = new System.Windows.Forms.PictureBox();
            this.PhotosList = new PhotoManagerClient.ImagesLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_SelectedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PBX_SelectedPhoto
            // 
            this.PBX_SelectedPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBX_SelectedPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PBX_SelectedPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBX_SelectedPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_SelectedPhoto.Location = new System.Drawing.Point(113, 0);
            this.PBX_SelectedPhoto.Name = "PBX_SelectedPhoto";
            this.PBX_SelectedPhoto.Size = new System.Drawing.Size(421, 407);
            this.PBX_SelectedPhoto.TabIndex = 1;
            this.PBX_SelectedPhoto.TabStop = false;
            // 
            // PhotosList
            // 
            this.PhotosList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhotosList.AutoScroll = true;
            this.PhotosList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhotosList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotosList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PhotosList.Location = new System.Drawing.Point(0, 0);
            this.PhotosList.Name = "PhotosList";
            this.PhotosList.SelectedPhotoBox = null;
            this.PhotosList.Size = new System.Drawing.Size(107, 407);
            this.PhotosList.TabIndex = 0;
            this.PhotosList.WrapContents = false;
            this.PhotosList.SelectedChanged += new PhotoManagerClient.ImagesLayout.SelectedChangedHandler(this.PhotosList_SelectedChanged);
            this.PhotosList.Click += new System.EventHandler(this.PhotosList_Click);
            // 
            // PhotosBrowser
            // 
            this.Controls.Add(this.PBX_SelectedPhoto);
            this.Controls.Add(this.PhotosList);
            this.Name = "PhotosBrowser";
            this.Size = new System.Drawing.Size(534, 407);
            this.Resize += new System.EventHandler(this.PhotosBrowser_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_SelectedPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Retourne la référence sur la photo sélectionnée
        /// </summary>
        public Photo SelectedPhoto
        {
            get
            {
                return _SelectedPhoto;
            }
            set
            {
                _SelectedPhoto = value;
                if (PhotosList != null)
                    PhotosList.SelectPhoto(_SelectedPhoto);
                OnSelectedChanged();
            }
        }

        /// <summary>
        /// Construteur de base
        /// </summary>
        public PhotosBrowser() : base()
        {
            InitializeComponent();
            this.PreviewKeyDown += PhotoBrowser_PreviewKeyDown;
        }

        /// <summary>
        /// Clear photo browser
        /// </summary>
        public void Clear()
        {
            PhotosList.Clear();
        }

        /// <summary>
        /// Ajoute les photos de la liste photos passées en paramètre. 
        /// Notez que les photos en place sont remplacées par celles de la liste.
        /// </summary>
        /// <param name="photos">Liste de photos à ajouter</param>
        public void LoadPhotos(List<Photo> photos)
        {
            SelectedPhoto = null;
            if (photos != null)
            {
                PhotosList.Clear();
                foreach (Photo photo in photos)
                {
                    PhotosList.AddPhoto(photo);
                }
            }
        }

        /// <summary>
        /// Ajoute la photo passée en paramètre
        /// </summary>
        /// <param name="photo">Photo à ajouter</param>       
        public void AddPhoto(Photo photo)
        {
            if (photo != null)
            {
                PhotosList.AddPhoto(photo);
                SelectedPhoto = photo;
            }
        }

        /// <summary>
        /// Retire du fureteur la photo sélectionnée
        /// </summary>
        public void DeleteSelectedPhoto()
        {
            if (PhotosList.SelectedPhotoBox != null)
            {
                PhotosList.RemoveSelected();
                SelectedPhoto = null;
            }
        }
        private void GetoriginalImageOfSelectedPhoto()
        {
            if (this.Parent != null)
                WaitSplash.Show(this.Parent as Form, "Loading selected photo ...");

            PBX_SelectedPhoto.BackgroundImage = PhotosList.SelectedPhotoBox.Photo.GetOriginalImage();

            if (this.Parent != null)
                WaitSplash.Hide();
        }
        private Photo GetSelectedPhoto()
        {
            return PhotosList.SelectedPhotoBox.Photo;
        }
        /// <summary>
        /// Sélectionner la photo suivante
        /// </summary>
        public void SelectNext()
        {
            PhotosList.SelectNext();
        }
        /// <summary>
        /// Sélectionner la photo précédente
        /// </summary>
        public void SelectPrevious()
        {
            PhotosList.SelectPrevious();
        }
        private void PhotosList_SelectedChanged(object sender, ImageLayoutEventArgs e)
        {
            if (PhotosList.SelectedPhotoBox != null)
            {
                if (e.TargetPhotoBox.Selected)
                {
                    GetoriginalImageOfSelectedPhoto();
                    SelectedPhoto = GetSelectedPhoto();

                }
            }
            else
            {
                PBX_SelectedPhoto.BackgroundImage = null;
            }
        }
        private void OnSelectedChanged()
        {
            if (SelectedChanged != null)
                SelectedChanged(this, new EventArgs());
        }
        private void PhotosList_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private Form FindParentForm()
        {
            Control parent = Parent;
            while (parent != null && parent.GetType().BaseType.Name != typeof(Form).Name)
                parent = parent.Parent;

            return (Form)parent;
        }
        private void PhotoBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form parentForm = null;
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Right: SelectNext(); parentForm = FindParentForm(); break;
                case Keys.Up:
                case Keys.Left: SelectPrevious(); parentForm = FindParentForm(); break;
            }

            if (parentForm != null)
                parentForm.ActiveControl = this;
        }
        private void PhotosBrowser_Resize(object sender, EventArgs e)
        {
            Placement = _PhotoBrowserPlacement;
        }
    }
}
