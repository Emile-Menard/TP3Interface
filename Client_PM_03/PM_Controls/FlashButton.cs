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
    /// Cette classe est un contrôle personnalisé qui implémente un "Flash button".
    /// Ce type de contrôle a été popularisé par l'ancien logiciel de création multimédia Web Adobe/Macromedia Flash
    /// https://fr.wikipedia.org/wiki/Adobe_Flash
    /// 
    /// Un "Flash button" est un bouton à 4 états  qui réagit à la souris (survol et clic)
    /// L'utilisateur programmeur devra sélectionner une image pour chacun des 4 états suivants:
    /// Neutre
    /// Survolé
    /// Cliqué
    /// Désactivé
    /// 
    /// Allez voir dans l'explorateur de cette solution dans Ressources.resx de Properties
    /// Il s'y trouve les images qu'utilise le contrôle FB_Clear du formulaire MainForm.
    /// 
    /// Allez voir aussi dans la boîte à outils en activant la fenêtre du concepteur de MainForm.
    /// Vous y verrez ce contrôle "FlashButton" vous permettant ainsi d'installer des instances
    /// dans le formulaire.
    /// 
    /// On pourrait bâtir une DLL avec cette classe pour l'utiliser dans d'autres projets WinForms
    /// 
    /// Notez que cette classe doit être compilée avant d'utiliser de ses instances dans le concepteur de MainForm
    /// 
    /// Auteur: Nicolas Chourot
    /// 
    /// </summary>
    class FlashButton : Button
    {
        public Image NeutralImage { get; set; }
        public Image OverImage { get; set; }
        public Image ClickedImage { get; set; }
        public Image DisabledImage { get; set; }

        public FlashButton() : base()
        {
            Size = new Size(36, 36);
            BackgroundImageLayout = ImageLayout.Zoom;
            Image = new Bitmap(ClientSize.Width, ClientSize.Height);
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this, Text);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this, Text);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);
            if (BackgroundImage != null)
                pevent.Graphics.DrawImage(BackgroundImage, ClientRectangle);
        }
        /// <summary>
        /// Gestion de l'événement [MouseDown]
        /// Il survient lorsqu'un des boutons de la souris est enfoncé
        /// </summary>
        /// <param name="e">Paramètres de l'événement</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if ((ClickedImage != null) && Enabled)
            {
                BackgroundImage = ClickedImage;
            }
        }
        /// <summary>
        /// Gestion de l'événement [MouseUp]
        /// Il survient lorsqu'un des boutons de la souris est relâché
        /// </summary>
        /// <param name="e">Paramètres de l'événement</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if ((NeutralImage != null) && Enabled)
            {
                BackgroundImage = NeutralImage;
            }
        }

        /// <summary>
        /// Gestion de l'événement [MouseEnter]
        /// Il survient lorsque le curseur de la souris survole la région du contrôle
        /// </summary>
        /// <param name="e">Paramètres de l'événement</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if ((OverImage != null) && Enabled)
            {
                BackgroundImage = OverImage;
            }
        }

        /// <summary>
        /// Gestion de l'événement [MouseDown]
        /// Il survient lorsque le curseur de la souris quitte la région du contrôle
        /// </summary>
        /// <param name="e">Paramètres de l'événement</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if ((NeutralImage != null) && Enabled)
            {
                BackgroundImage = NeutralImage;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if ((NeutralImage != null) && Enabled)
            {
                BackgroundImage = NeutralImage;
            }
        }

        /// <summary>
        /// Gestion de l'événement [EnabledChanged]
        /// Il survient lorsque la propriété Enabled change de valeur
        /// </summary>
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (Enabled)
            {
                BackgroundImage = NeutralImage;
            }
            else
            {
                BackgroundImage = DisabledImage;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if ((NeutralImage != null) && Enabled)
            {
                BackgroundImage = NeutralImage;
            }
        }
    }
}
