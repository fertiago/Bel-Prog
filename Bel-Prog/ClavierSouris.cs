using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bel_Prog
{
    public partial class ClavierSouris : Form
    {
        private int nbGauche = 0;
        private int nbDroit = 0;

        public ClavierSouris()
        {
            InitializeComponent();

            this.KeyPreview = true;

            AfficherClic();
            XTextBox.Text = "0";
            YTextBox.Text = "0";
        }

        private void AfficherClic()
        {
            leftClickTextBox.Text = nbGauche.ToString();
            rightClickTextBox.Text = nbDroit.ToString();
        }


        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            XTextBox.Text = e.X.ToString();
            YTextBox.Text = e.Y.ToString();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nbGauche++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                nbDroit++;
            }
            AfficherClic();

            int largeurCase = panel.Width / 3;
            int hauteurCase = panel.Height / 3;

            int colonne = Math.Min((e.X / largeurCase) + 1, 3);
            int ligne = Math.Min((e.Y / hauteurCase) + 1, 3);

            clavierListBox.Items.Insert(0, $"Clic case : Ligne {ligne}, Colonne {colonne}");
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen stylo = new Pen(Color.Black, 1);
            int w = panel.Width;
            int h = panel.Height;

            g.DrawLine(stylo, w / 3, 0, w / 3, h);
            g.DrawLine(stylo, 2 * w / 3, 0, 2 * w / 3, h);

            g.DrawLine(stylo, 0, h / 3, w, h / 3);
            g.DrawLine(stylo, 0, 2 * h / 3, w, 2 * h / 3);
        }


        private void ClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            clavierListBox.Items.Insert(0, $"Down - Code {e.KeyCode}, Valeur {e.KeyValue}");
        }

        private void ClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            clavierListBox.Items.Insert(0, $"Press - Char {e.KeyChar}");
        }

        private void ClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            clavierListBox.Items.Insert(0, $"Up - Code {e.KeyCode}");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();

            XTextBox.Text = "0";
            YTextBox.Text = "0";

            clavierListBox.Items.Clear();
        }
    }
}