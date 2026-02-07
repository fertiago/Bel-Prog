using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bel_Prog
{
    public partial class APropos : Form
    {
        private Cursor curseurOrigine;
        private Cursor curseurPerso;

        public APropos()
        {
            InitializeComponent();
            foreach (Control control in mainPanel.Controls)
            {
                control.MouseEnter += panel_MouseEnter;
                control.MouseLeave += panel_MouseLeave;
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            curseurOrigine = this.Cursor;
            this.Cursor = Cursors.Hand;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = curseurOrigine;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            if (curseurPerso == null)
            {
                Bitmap bmp = Properties.Resources.cursor;
                IntPtr ptr = bmp.GetHicon();
                curseurPerso = new Cursor(ptr);
            }

            if (this.Cursor != curseurPerso)
            {
                curseurOrigine = this.Cursor;
                this.Cursor = curseurPerso;
            }
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            if (!mainPanel.ClientRectangle.Contains(mainPanel.PointToClient(Cursor.Position)))
            {
                this.Cursor = curseurOrigine;
            }
        }

        private void confirmerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}