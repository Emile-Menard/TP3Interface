using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManagerClient
{
    /// <summary>
    /// Cette classe dérive de PictureBox. Elle se comporte comme sa classe parente avec en plus 
    /// des fonctionnalités d'importation d'image telles que:
    /// Cliqué-déposé
    /// Coller
    /// Choix du fichier via le dialogue de sélection de fichier
    /// 
    /// Auteur Nicolas Chourot
    /// </summary>
    class ImageBox : PictureBox
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public ImageBox() : base()
        {
            BackgroundImageLayout = ImageLayout.Zoom;
            BorderStyle = BorderStyle.FixedSingle;
            DragDrop += new System.Windows.Forms.DragEventHandler(ImageBoxDragDrop);
            DragEnter += new System.Windows.Forms.DragEventHandler(ImageBoxDragEnter);
            ((PictureBox)this).AllowDrop = true;
            OpenFileDialogTitle = "Please choose image an file";
            PasteMenuText = "Paste image from clipboard";
            ImportImageText = "Import image from file...";
            ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file with context menu.";
            PrepareContextMenu();
        }
        /// <summary>
        /// Titre du dialogue de sélection de fichier d'image
        /// </summary>
        public string OpenFileDialogTitle { get; set; }
 
        /// <summary>
        /// Titre de menu pour coller l'image provenant du presse-papier
        /// </summary>
        public string PasteMenuText { get; set; }

        /// <summary>
        /// Titre de menu pour choisir le fichier d'image à importer
        /// </summary>
        public string ImportImageText { get; set; }

        /// <summary>
        /// Texte de l'info-bulle du contrôle
        /// </summary>
        public string ControlToolTipText { get; set; }

        private void ImageBoxDragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                this.BackgroundImage = img;
            }
        }
        private void ImageBoxDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void PasteImageFormClipboard()
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                this.BackgroundImage = (Image)iData.GetData(DataFormats.Bitmap);
            }
        }
        private void ImportImageFormFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = OpenFileDialogTitle;
            // filtre de choix de fichier
            dlg.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp|All Files(*.*) |*.*";
            // afficher le dialogue et traiter l'ouverture si le dialogue a été fermé par le bouton de sortie Ok
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // affecter l'image de fond avec l'image extraite du fichier sélectionné
                    this.BackgroundImage = Image.FromFile(dlg.FileName);
                }
                catch (Exception)
                {
                    // il y a eu une exception lors de la lecture du fichier sélectionné
                    MessageBox.Show("Unknown file format.");
                }
            }
        }
        private void PrepareContextMenu()
        {
            ContextMenuStrip PopupMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip = PopupMenuStrip;
            ToolStripMenuItem pasteItem = new ToolStripMenuItem(PasteMenuText);
            pasteItem.Click += new EventHandler(pasteItem_Click);
            ToolStripMenuItem ImportImageItem = new ToolStripMenuItem(ImportImageText);
            ImportImageItem.Click += new EventHandler(ImportImageItem_Click);

            pasteItem.Name = "pasteItem";
            ImportImageItem.Name = "ImportImageItem";

            PopupMenuStrip.Items.Add(pasteItem);
            PopupMenuStrip.Items.Add(ImportImageItem);

            ToolTip tp = new ToolTip();
            tp.SetToolTip(this, ControlToolTipText);
        }
        private void pasteItem_Click(object sender, EventArgs e)
        {
            PasteImageFormClipboard();
        }
        private void ImportImageItem_Click(object sender, EventArgs e)
        {
            ImportImageFormFile();
        }

    }
}
