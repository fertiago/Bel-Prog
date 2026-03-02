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
        public Editeur()
        {
            InitializeComponent();
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveau_Click(object sender, EventArgs e)
        {

        }
        private void ouvrir_Click(object sender, EventArgs e)
        {

        }
        private void enregistrer_Click(object sender, EventArgs e)
        {

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
    }
}
