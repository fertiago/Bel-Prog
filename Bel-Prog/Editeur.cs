using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bel_Prog
{
    public partial class Editeur : Form
    {
        private string sFichier;
        private bool bModifier;
        public Editeur()
        {
            sFichier = "";
            bModifier = false;
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(editeur_FormClosing);
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }
        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editeur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (verifierModifications() == false)
            {
                e.Cancel = true;
            }
        }

        private bool verifierModifications()
        {
            if (bModifier == true)
            {
                DialogResult _reponse = MessageBox.Show("Le document a été modifié. Voulez-vous l'enregistrer ?", "Enregistrer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (_reponse == DialogResult.Yes)
                {
                    return fichierEnregistrer();
                }
                else if (_reponse == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            if (verifierModifications() == true)
            {
                richText.Clear();
                sFichier = "";
                bModifier = false;
            }
        }
        private void ouvrir_Click(object sender, EventArgs e)
        {
            if (verifierModifications() == true)
            {
                OpenFileDialog _fichier = new OpenFileDialog();
                _fichier.Filter = "Fichiers RTF (*.rtf)|*.rtf|Fichiers texte (*.txt)|*.txt";

                if (_fichier.ShowDialog() == DialogResult.OK)
                {
                    sFichier = _fichier.FileName;
                    try
                    {
                        if (sFichier.EndsWith(".rtf"))
                        {
                            richText.LoadFile(sFichier, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            richText.LoadFile(sFichier, RichTextBoxStreamType.PlainText);
                        }
                        bModifier = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'ouverture : " + ex.Message);
                    }
                }
            }
        }

        private bool fichierEnregistrer()
        {
            if (sFichier == "")
            {
                SaveFileDialog _fichier = new SaveFileDialog();
                _fichier.Filter = "Fichiers RTF (*.rtf)|*.rtf|Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

                if (_fichier.ShowDialog() == DialogResult.OK)
                {
                    sFichier = _fichier.FileName;
                }
                else
                {
                    return false;
                }
            }

            try
            {
                if (sFichier.EndsWith(".rtf"))
                {
                    richText.SaveFile(sFichier, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richText.SaveFile(sFichier, RichTextBoxStreamType.PlainText);
                }
                bModifier = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
                return false;
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            fichierEnregistrer();
        }

        private void copier_Click(object sender, EventArgs e)
        {
            richText.Copy();
        }

        private void couper_Click(object sender, EventArgs e)
        {
            richText.Cut();
        }

        private void coller_Click(object sender, EventArgs e)
        {
            richText.Paste();
        }

        private void gauche_Click(object sender, EventArgs e)
        {
            richText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centre_Click(object sender, EventArgs e)
        {
            richText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void droite_Click(object sender, EventArgs e)
        {
            richText.SelectionAlignment = HorizontalAlignment.Right;
        }


        private void police_Click(object sender, EventArgs e)
        {
            FontDialog _police = new FontDialog();

            if (richText.SelectionFont != null)
            {
                _police.Font = richText.SelectionFont;
            }

            if (_police.ShowDialog() == DialogResult.OK)
            {
                richText.SelectionFont = _police.Font;
            }
        }

        private void gras_Click(object sender, EventArgs e)
        {
            ChangerStyleCaracteres(FontStyle.Bold);
        }

        private void italique_Click(object sender, EventArgs e)
        {
            ChangerStyleCaracteres(FontStyle.Italic);
        }

        private void souligne_Click(object sender, EventArgs e)
        {
            ChangerStyleCaracteres(FontStyle.Underline);
        }

        private void barre_Click(object sender, EventArgs e)
        {
            ChangerStyleCaracteres(FontStyle.Strikeout);
        }

        private void ChangerStyleCaracteres(FontStyle style)
        {
            Font _police = richText.SelectionFont;

            if (_police == null)
            {
                _police = richText.Font;
            }

            FontStyle _style = _police.Style ^ style;

            richText.SelectionFont = new Font(_police.FontFamily, _police.Size, _style);
        }
    }
}
