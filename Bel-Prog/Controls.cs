using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bel_Prog
{
    public partial class ControlsForm : Form
    {
        public ControlsForm()
        {
            InitializeComponent();
        }

        private void quiterStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
