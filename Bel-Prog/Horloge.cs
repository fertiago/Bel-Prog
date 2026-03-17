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
    public partial class Horloge : Form
    {
        private Color cFond;
        private Color cTrait;

        public Horloge()
        {
            cTrait = Color.DarkSlateBlue;
            cFond = Color.White;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics _g = e.Graphics;

            _g.SmoothingMode = SmoothingMode.AntiAlias;

            _g.Clear(cFond);

            int _xc = ClientSize.Width / 2;
            int _yc = ClientSize.Height / 2;
            int _rayon = Math.Min(_xc, _yc) - 20;

            DateTime _maintenant = DateTime.Now;
            this.Text = _maintenant.ToLongTimeString();

            using (Pen _stylo = new Pen(cTrait, 3))
            {
                _g.DrawEllipse(_stylo, _xc - _rayon, _yc - _rayon, _rayon * 2, _rayon * 2);
            }

            dessinerCadran(_g, _xc, _yc, _rayon, new Pen(cTrait, 2));

            double _angleSecondes = (_maintenant.Second * 6 * Math.PI / 180.0) - Math.PI / 2.0;
            double _angleMinutes = ((_maintenant.Minute + _maintenant.Second / 60.0) * 6 * Math.PI / 180.0) - Math.PI / 2.0;
            double _angleHeures = ((_maintenant.Hour % 12 + _maintenant.Minute / 60.0) * 30 * Math.PI / 180.0) - Math.PI / 2.0;

            using (Pen _styloSecondes = new Pen(Color.IndianRed, 1)) dessinerAiguille(_g, _xc, _yc, _angleSecondes, _rayon * 0.9, _styloSecondes);

            using (Pen _styloMinutes = new Pen(Color.DarkGray, 3)) dessinerAiguille(_g, _xc, _yc, _angleMinutes, _rayon * 0.7, _styloMinutes);

            using (Pen _styloHeures = new Pen(Color.DarkGray, 5)) dessinerAiguille(_g, _xc, _yc, _angleHeures, _rayon * 0.4, _styloHeures);
        }

        private void dessinerAiguille(Graphics _g, int _xc, int _yc, double _angleRad, double _longueur, Pen _stylo)
        {
            float _xBout = (float)(_xc + _longueur * Math.Cos(_angleRad));
            float _yBout = (float)(_yc + _longueur * Math.Sin(_angleRad));

            _g.DrawLine(_stylo, _xc, _yc, _xBout, _yBout);
        }

        private void dessinerCadran(Graphics _g, int _xc, int _yc, int _rayon, Pen _stylo)
        {
            for (int i = 0; i < 12; i++)
            {
                double _angleRad = (i * 30 * Math.PI / 180.0) - Math.PI / 2.0;
                float _xDebut = (float)(_xc + (_rayon - 10) * Math.Cos(_angleRad));
                float _yDebut = (float)(_yc + (_rayon - 10) * Math.Sin(_angleRad));
                float _xFin = (float)(_xc + _rayon * Math.Cos(_angleRad));
                float _yFin = (float)(_yc + _rayon * Math.Sin(_angleRad));
                _g.DrawLine(_stylo, _xDebut, _yDebut, _xFin, _yFin);
            }
        }

        private void horloge_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}