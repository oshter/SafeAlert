using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace proyect
{
    public class TextBoxRedondeado : UserControl
    {
        private int borderRadius = 15;
        private Color borderColor = Color.Gray;
        private int borderSize = 2;
        public TextBox textBox;

        [Category("Apariencia")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); ReajustarDimensiones(); }
        }

        [Category("Apariencia")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Apariencia")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; if (textBox != null) textBox.BackColor = value; }
        }

        [Category("Apariencia")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; if (textBox != null) textBox.ForeColor = value; }
        }

        [Category("Apariencia")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextWindow
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public TextBoxRedondeado()
        {
            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(10, 7);
            textBox.Width = this.Width - 20;
            this.Controls.Add(textBox);

            this.BackColor = Color.White;
            this.Padding = new Padding(10, 7, 10, 7);
            this.Size = new Size(250, 30);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ReajustarDimensiones();
        }

        private void ReajustarDimensiones()
        {
            if (textBox != null)
            {
                textBox.Width = this.Width - 20;
                this.Height = textBox.Height + 14;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                int r = borderRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.X + rect.Width - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.X + rect.Width - r, rect.Y + rect.Height - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - r, r, r, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    pen.Alignment = PenAlignment.Inset;
                    graph.DrawPath(pen, path);
                }
            }
        }
    }
}

        