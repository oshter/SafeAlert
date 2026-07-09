using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace proyect
{
    // CORRECCIÓN: Cambiado a 'public' para que el Diseñador de VS pueda leerlo
    public class BotonRedondeado : Button
    {
        private int borderRadius = 20;

        [Category("Apariencia")]
        [DefaultValue(20)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public BotonRedondeado()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                int r = Math.Min(borderRadius, Math.Min(this.Width, this.Height));

                if (r > 1)
                {
                    path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                    path.AddArc(rect.X + rect.Width - r, rect.Y, r, r, 270, 90);
                    path.AddArc(rect.X + rect.Width - r, rect.Y + rect.Height - r, r, r, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - r, r, r, 90, 90);
                    path.CloseFigure();
                    this.Region = new Region(path);
                }
                else
                {
                    this.Region = new Region(rect);
                }
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            }
        }
    }
}

