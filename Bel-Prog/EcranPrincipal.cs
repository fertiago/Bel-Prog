using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bel_Prog
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void quiterStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aProposStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos window = new APropos();
            window.Show();
        }

        private void barreDeProgressionStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranProgression window = new EcranProgression();
            window.Show();
        }

        private void listesStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationListe window = new ManipulationListe();
            window.Show();
        }

        private void editeurStripMenuItem_Click(object sender, EventArgs e)
        {
            Editeur window = new Editeur();
            window.Show();
        }

        private void spirographeStripMenuItem_Click(object sender, EventArgs e)
        {
            Spirographe window = new Spirographe();
            window.Show();
        }


        private void horlogeStripMenuItem_Click(object sender, EventArgs e)
        {
            Horloge windows = new Horloge();
            windows.Show();
        }

        private void clavierSourisMenuItem_Click(object sender, EventArgs e)
        {
            ClavierSouris windows = new ClavierSouris();
            windows.Show();
        }

        private void baseDeDonneeStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranDbDirect windows = new EcranDbDirect();
            windows.Show();
        }    

    }
}
