using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Bel_Prog
{
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();

            sequentielleProgressBar.Minimum = 0;
            sequentielleProgressBar.Maximum = 100;
            sequentielleProgressBar.Step = 1;

            totalProgressBar.Minimum = 0;
            totalProgressBar.Maximum = 100;
            totalProgressBar.Step = 1;

            debuterButton.Click += DebuterButton_Click;
            quitterButton.Click += QuitterButton_Click;
        }

        private async void DebuterButton_Click(object sender, EventArgs e)
        {
            debuterButton.Enabled = false;
            quitterButton.Enabled = false;

            sequentielleProgressBar.Value = 0;
            totalProgressBar.Value = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    await Task.Delay(50); 
                    sequentielleProgressBar.Value = j;
                    totalProgressBar.Value = (i * 100 + j) / 6;
                }
                
                sequentielleProgressBar.Value = 0;
            }

            debuterButton.Enabled = true;
            quitterButton.Enabled = true;
        }

        private void QuitterButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
