using System;
using System.Linq;
using System.Windows.Forms;

namespace GTranslator
{
    public partial class TranslatorForm : Form
    {
        #region Constructor

        public TranslatorForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void TranslatorForm_Load(object sender, EventArgs e)
        {
            cboFrom.Items.AddRange(Translator.Languages.ToArray());
            cboFrom.SelectedItem = "English";
            cboTo.Items.AddRange(Translator.Languages.ToArray());
            cboTo.SelectedItem = "Indonesian";
        }

        private void lnkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cboFrom.SelectedItem = "English";
        }

        private void lnkTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cboTo.SelectedItem = "English";
        }

        private void lnkReverse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Swap translation mode
            string from = (string)cboFrom.SelectedItem;
            string to = (string)cboTo.SelectedItem;
            cboFrom.SelectedItem = to;
            cboTo.SelectedItem = from;

            // Reset text
            rtbSource.Text = rtbTarget.Text;
            rtbTarget.Text = string.Empty;
            Update();
            translationSpeakURL = string.Empty;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            // initialize translator
            Translator translator = new Translator();

            rtbTarget.Text = string.Empty;
            rtbTarget.Update();

            translationSpeakURL = null;

            // translate the text
            try
            {
                Cursor = Cursors.WaitCursor;

                lblStatus.Text = "Translating...";
                lblStatus.Update();

                rtbTarget.Text = translator.Translate(
                    rtbSource.Text.Trim(), 
                    (string)cboFrom.SelectedItem, 
                    (string)cboTo.SelectedItem);

                if (translator.Error == null)
                {
                    rtbTarget.Update();
                    translationSpeakURL = translator.TranslationSpeechURL;
                }
                else
                {
                    MessageBox.Show(translator.Error.Message, Text, 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                lblStatus.Text = string.Format(
                    "Translated in {0} ms", 
                    (int)translator.TranslationTime.TotalMilliseconds);
                Cursor = Cursors.Default;
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(translationSpeakURL))
            {
                webBrowser.Navigate(translationSpeakURL);
            }
        }

        #endregion

        /// <summary>
        /// URL to speak the translation.
        /// </summary>
        private string translationSpeakURL;
    }
}
