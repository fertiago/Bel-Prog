using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Bel_Prog
{
    public partial class Spirographe : Form
    {
        private Color Fond;
        private Color Trait;
        private GraphicsPath Graphique;

        public Spirographe()
        {
            Fond = Color.White;
            Trait = Color.Blue;
            Graphique = null;

            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            int _sommets = sommetsTrackBar.Value;
            int _densite = densiteTrackBar.Value;
            int _profondeur = profondeurTrackBar.Value;

            int _xOffset = 248;
            int _largeurUtile = ClientSize.Width - _xOffset;
            int _hauteurUtile = ClientSize.Height;

            int _xc = _xOffset + (_largeurUtile / 2);
            int _yc = _hauteurUtile / 2;
            int _rayon = (Math.Min(_largeurUtile, _hauteurUtile) / 2) - 10;

            double[] _sx = new double[_sommets + 1];
            double[] _sy = new double[_sommets + 1];

            for (int i = 0; i <= _sommets; i++)
            {
                _sx[i] = _xc + _rayon * Math.Cos(2 * Math.PI * i / _sommets);
                _sy[i] = _yc + _rayon * Math.Sin(2 * Math.PI * i / _sommets);
            }

            Graphique = new GraphicsPath();

            double _seuilArret = (double)_rayon * _profondeur / 100.0;

            while (Math.Sqrt(Math.Pow(_sx[0] - _xc, 2) + Math.Pow(_sy[0] - _yc, 2)) > _seuilArret)
            {
                for (int i = 0; i < _sommets; i++)
                {
                    Graphique.AddLine((float)_sx[i], (float)_sy[i], (float)_sx[i + 1], (float)_sy[i + 1]);
                }

                for (int i = 0; i < _sommets; i++)
                {
                    _sx[i] = _sx[i] + (_sx[i + 1] - _sx[i]) / _densite;
                    _sy[i] = _sy[i] + (_sy[i + 1] - _sy[i]) / _densite;
                }
                _sx[_sommets] = _sx[0];
                _sy[_sommets] = _sy[0];
            }

            Invalidate();
        }

        private void fond_Click(object sender, EventArgs e)
        {
            ColorDialog _couleur = new ColorDialog();
            if (_couleur.ShowDialog() == DialogResult.OK)
            {
                Fond = _couleur.Color;
                Invalidate();
            }
        }

        private void trait_Click(object sender, EventArgs e)
        {
            ColorDialog _couleur = new ColorDialog();
            if (_couleur.ShowDialog() == DialogResult.OK)
            {
                Trait = _couleur.Color;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Graphique != null)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(Fond),
                    new Rectangle(new Point(248, 0), ClientSize));

                e.Graphics.DrawPath(new Pen(Trait), Graphique);
            }
        }
    }
}