using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace proyect
{
    public class PanelRedondeado : Panel
    {
        private int borderRadius = 30; // Curvatura para el cuadro blanco grande

        [Category("Apariencia")]
        [DefaultValue(30)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate(); // Redibuja el panel al cambiar el radio
            }
        }

        public PanelRedondeado()
        {
            this.BackColor = Color.White; // Fondo blanco por defecto
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

