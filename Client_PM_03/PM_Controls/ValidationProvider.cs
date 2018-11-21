using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation
{
    // Auteur: Nicolas Chourot
    //
    // Classes de gestion de validation et de rapport d'erreur pour un formulaire.
    //


    /// <summary>
    /// Prototype de méthode de validation
    /// </summary>
    /// <param name="message">Message d'erreur à afficher en cas d'échec de la validation</param>
    /// <returns></returns>
    public delegate bool Validate(ref string message);
    /// <summary>
    /// Prototype de méthode tâche de fermeture de dialogue

    public delegate void SubmitTask();

    /// <summary>
    /// Cette classe converse la référence à un contrôle qui devra être validé
    /// </summary>
    public class ControlToValidate
    {
        // Contrôle à valider
        public Control Control { get; set; }

        // Référence sur la méthode de validation
        public Validate Validate { get; set; }
        public Validate ValidateOnSubmit { get; set; }

        // Indique si le contrôle a déjà été validé avec succès
        public bool WasValid { get; set; }
        public bool JustFocused { get; set; }

        // Constructeur
        public ControlToValidate(Control c, Validate validate, Validate validateOnSubmit = null)
        {
            Control = c;
            WasValid = false;
            JustFocused = false;
            Validate = validate;
            ValidateOnSubmit = validateOnSubmit;
        }
    }

    public static class ImageToIcon
    {
        public enum IconSizeDimensions
        {
            IconSize16x16Pixels = 16,
            IconSize24x24Pixels = 24,
            IconSize32x32Pixels = 32,
            IconSize48x48Pixels = 48,
            IconSize64x64Pixels = 64,
            IconSize96x96Pixels = 96,
            IconSize128x128Pixels = 128
        }
        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, Color canvasBackground)
        {
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ? sourceBitmap.Width : sourceBitmap.Height;
            Bitmap bitmapResult = new Bitmap(maxSide, maxSide, PixelFormat.Format32bppArgb);
            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.Clear(canvasBackground);
                int xOffset = (sourceBitmap.Width - maxSide) / 2;
                int yOffset = (sourceBitmap.Height - maxSide) / 2;
                graphicsResult.DrawImage(sourceBitmap, new Point(xOffset, xOffset));
            }
            return bitmapResult;
        }
        public static Icon CreateIcon(this Bitmap sourceBitmap, IconSizeDimensions iconSize)
        {
            Bitmap squareCanvas = sourceBitmap.CopyToSquareCanvas(Color.Transparent);
            squareCanvas = (Bitmap)squareCanvas.GetThumbnailImage((int)iconSize, (int)iconSize, null, new IntPtr());
            Icon iconResult = Icon.FromHandle(squareCanvas.GetHicon());
            return iconResult;
        }
    }

    /// <summary>
    /// Cette classe une collection de contrôles qui devront êtres tous valide afin de déterminer si le formulaire est valide pour une soumission
    /// </summary>
    public class ValidationProvider
    {
        #region Membres privés
        // utilisé pour ajouter un indicateur d'erreur à côté du contrôle en faute.
        // Cet indicateur donnera accès à une info- bulle qui affiche le message d'erreur.
        private ErrorProvider _ErrorProvider = new ErrorProvider();

        // Formulaire parent des contrôles
        private Form _form = null;

        // Liste des contrôles à valider
        private List<ControlToValidate> _ControlsToValidate = new List<ControlToValidate>();

        SubmitTask SubmitTask;

        #endregion

        #region Contructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="formToValidate">Formulaire parent des contrôles</param>
        /// <param name="submitTask">Réréference sur la fonction à appeler lors de la soumission</param>
        public ValidationProvider(Form formToValidate, SubmitTask submitTask = null)
        {
            // Formulaire parent des contrôles
            _form = formToValidate;

            // Assignation du formulaire parent des contrôles
            _ErrorProvider.ContainerControl = _form;
            _ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ErrorProvider.BlinkRate = 50;

            // Si le formulaire parent des contrôles possède un bouton de sortie de soumission
            if (_form.AcceptButton != null)
            {
                Control acceptButton = _form.AcceptButton as Control;

                // Ajout du gestionnaire de l'événement click qui permettra ou non de soumettre le formulaire
                acceptButton.Click += new EventHandler(AcceptButtonClick);
            }

            SubmitTask = submitTask;
        }

        public void SetErrorIcon(Bitmap image)
        {
            _ErrorProvider.Icon = ImageToIcon.CreateIcon(image, ImageToIcon.IconSizeDimensions.IconSize32x32Pixels);
        }
        #endregion

        #region Méthodes publiques d'ajout et de gestion de validation
        /// <summary>
        /// Ajouter un contrôle à valider avec sa méthode de validation
        /// </summary>
        /// <param name="control">Contrôle à valider</param>
        /// <param name="validate">Méthode de validation</param>
        /// <param name="validateOnSubmit">Méthode de validation à la soumission du formulaire</param>
        public void AddControlToValidate(Control control, Validate validate, Validate validateOnSumit = null)
        {
            _ControlsToValidate.Add(new ControlToValidate(control, validate, validateOnSumit));

            ////////////////////////////////////////////////////////////////////////////
            // Remarque importante: 
            // Les événements Leave et TextChanged sont communs à tous les contrôles
            // mais peuvent-être sans effet selon le type de contrôle.
            // Pour certains contrôles, il faudra ajouter un gestionnaire d'événement
            // qui déclenchera la validation avec UpdateValid()
            //
            // Ajout de l'événement Leave afin que la validation soit déclenchée
            // après que le contrôle perd la main
            control.Leave += new EventHandler(Leave);

            // Ajout de l'événement TextChanged afin que la validation soit déclenchée
            // lorsque que le texte du contrôle a changé
            control.TextChanged += new EventHandler(TextChanged);
            control.Enter += new EventHandler(Enter);
            control.Click += new EventHandler(Click);
            //
            ////////////////////////////////////////////////////////////////////////////

            // Mise à jour de la validation du contrôle
            UpdateValid(control);
        }

        /// <summary>
        /// Vérification de la validité d'un contrôle. Si ce dernier est en faute,
        /// ajouter un indicateur d'erreur.
        /// </summary>
        /// <param name="control">Référence sur le contrôle à valider</param>
        public void UpdateError(object control)
        {
            if (_ErrorProvider != null)
            {
                ControlToValidate ctv = FindControlToValidate(control);
                if (ctv != null)
                {
                    string message = "";
                    if (!ctv.Validate(ref message))
                    {
                        _ErrorProvider.SetError(ctv.Control, message);
                    }
                    else
                    {
                        _ErrorProvider.SetError(ctv.Control, null);
                    }
                }
            }
        }

        /// <summary>
        /// Vérification de la validité d'un contrôle. 
        /// Si ce dernier est en faute et qu'il a déjà été validé avec succès, ajouter un indicateur d'erreur 
        /// </summary>
        /// <param name="control">Référence sur le contrôle à valider</param>
        public void UpdateValid(object control)
        {
            if (_ErrorProvider != null)
            {
                ControlToValidate ctv = FindControlToValidate(control);
                if (ctv != null)
                {
                    string message = "";
                    if (ctv.Validate(ref message))
                    {
                        _ErrorProvider.SetError(ctv.Control, null);
                        ctv.WasValid = true;
                    }
                    else
                    {
                        if (ctv.WasValid)
                        {
                            _ErrorProvider.SetError(ctv.Control, message);
                        }
                    }
                }
            }
        }
        #endregion

        #region Méthodes privées

        // Recherche du contrôle à valider par la référence du contrôle proprement dit
        private ControlToValidate FindControlToValidate(object c)
        {
            foreach (ControlToValidate ctv in _ControlsToValidate)
            {
                if (c == ctv.Control)
                    return ctv;
            }
            return null;
        }

        // Cette méthode invoque la méthode de validation de tous les contrôles
        // et ajoute un indicateur d'erreur à chacun d'entre eux qui sont en faute 
        private void ReportAllErrors()
        {
            foreach (ControlToValidate controlToValidate in _ControlsToValidate)
            {
                string message = "";

                if (!controlToValidate.Validate(ref message))
                {
                    _ErrorProvider.SetError(controlToValidate.Control, message);
                }
                else
                {
                    if (controlToValidate.ValidateOnSubmit != null)
                    {
                        if (!controlToValidate.ValidateOnSubmit(ref message))
                        {
                            _ErrorProvider.SetError(controlToValidate.Control, message);
                        }
                        else
                        {
                            _ErrorProvider.SetError(controlToValidate.Control, null);
                        }
                    }
                    else
                    {
                        _ErrorProvider.SetError(controlToValidate.Control, null);
                    }
                }
            }
        }

        /// Indique si le formulaire est valide en vérifiant tous les contrôles à valider
        private bool FormValid()
        {
            foreach (ControlToValidate ctv in _ControlsToValidate)
            {
                string message = "";
                if (!ctv.Validate(ref message))
                {
                    return false;
                }
                if (ctv.ValidateOnSubmit != null)
                {
                    if (!ctv.ValidateOnSubmit(ref message))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region Gestionnaires d'événements locales à la classe
        // Permet la soumission du formulaire si ce dernier est valide
        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (!FormValid())
            {
                // Empêcher la soumission
                _form.DialogResult = DialogResult.None;
                ReportAllErrors();
            }
            else
            {
                // Permettre la soumission
                _form.DialogResult = DialogResult.OK;
                if (SubmitTask != null)
                {
                    SubmitTask.Invoke();
                }
            }
        }

        // S'assurer que le curseur soit placé au dernier caractère du champ
        private void PlaceCursorAtEnd(MaskedTextBox mtbx)
        {
            if (mtbx.Text.Contains('_'))
            {
                int first_Prompt_Position = 0;
                for (int pos = 0; pos < mtbx.Text.Length; pos++)
                {
                    first_Prompt_Position = pos;
                    if (mtbx.Text[pos] == '_')
                        break;
                }
                mtbx.SelectionStart = first_Prompt_Position;
            }
            else
            {
                mtbx.SelectionStart = mtbx.Text.Length;
            }
        }
        // S'assurer que le curseur soit placé au dernier caractère du champ
        public void PlaceCursorAtEnd(TextBox tbx)
        {
            tbx.SelectionStart = tbx.Text.Length;
        }

        // Marquer le contrôle comme venant d'avoir le focus
        private void Enter(object sender, EventArgs e)
        {
            ControlToValidate ctv = FindControlToValidate(sender);
            ctv.JustFocused = true;
        }

        // Si le contrôle vient d'avoir le focus, placer le curseur à la fin
        private void Click(object sender, EventArgs e)
        {
            ControlToValidate ctv = FindControlToValidate(sender);
            if (ctv.JustFocused)
            {
                ctv.JustFocused = false;
                if (sender.GetType() == typeof(MaskedTextBox))
                {
                    PlaceCursorAtEnd((MaskedTextBox)sender);
                }
                else
                {
                    if (sender.GetType() == typeof(TextBox))
                    {
                        PlaceCursorAtEnd((TextBox)sender);
                    }
                }
            }
        }
        // Valider le contrôle en quittant ce dernier
        private void Leave(object sender, EventArgs e)
        {
            ControlToValidate ctv = FindControlToValidate(sender);
            ctv.JustFocused = false;
            UpdateError(sender);
        }

        // Valider le contrôle lorsque le texte de ce dernier a changé
        private void TextChanged(object sender, EventArgs e)
        {
            UpdateValid(sender);
        }
        #endregion

    }
}
