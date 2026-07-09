using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace proyect
{
    public class BotonCircular : Button
    {
        public BotonCircular()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Red;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Forzar a que el botón siempre sea un círculo perfecto basado en su tamaño
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                this.Region = new Region(path);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            }
            base.OnPaint(e);
        }
    }
}
