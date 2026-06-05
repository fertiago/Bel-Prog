using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    /// <summary>
    /// Custom button with color gradient.
    /// </summary>
    [ToolboxBitmap(typeof(Button))]
    public class BoutonColore : Button
    {
        private Color cGauche;
        private Color cDroite;
        private int tGauche;
        private int tDroite;

        public BoutonColore()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            cGauche = Color.Blue;
            cDroite = Color.LightBlue;
            tGauche = 255;
            tDroite = 255;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Left color of the gradient.
        /// </summary>
        [Category("Appearance"), Description("Left color of the gradient")]
        public Color CouleurGauche
        {
            get { return cGauche; }
            set
            {
                cGauche = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Right color of the gradient.
        /// </summary>
        [Category("Appearance"), Description("Right color of the gradient")]
        public Color CouleurDroite
        {
            get { return cDroite; }
            set
            {
                cDroite = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Transparency of the left color.
        /// </summary>
        [Category("Appearance"), Description("Transparency of the left color")]
        public int TransparenceGauche
        {
            get { return tGauche; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    tGauche = value;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Transparency of the right color.
        /// </summary>
        [Category("Appearance"), Description("Transparency of the right color")]
        public int TransparenceDroite
        {
            get { return tDroite; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    tDroite = value;
                    Invalidate();
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color couleurGaucheTransparente = Color.FromArgb(tGauche, cGauche);
            Color couleurDroiteTransparente = Color.FromArgb(tDroite, cDroite);

            LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, this.Height),
                couleurGaucheTransparente,
                couleurDroiteTransparente,
                LinearGradientMode.Horizontal);

            g.FillRectangle(brush, new Rectangle(0, 0, this.Width, this.Height));

            g.DrawRectangle(new Pen(Color.Gray, 1), new Rectangle(0, 0, this.Width - 1, this.Height - 1));

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            SizeF textSize = g.MeasureString(this.Text, this.Font);
            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 
                new RectangleF(0, 0, this.Width, this.Height), stringFormat);

            e.Graphics.DrawImageUnscaled(bmp, 0, 0);

            brush.Dispose();
            g.Dispose();
            bmp.Dispose();
        }
    }
}
