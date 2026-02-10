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
    }
}
