namespace proyect
{
    partial class FormReportar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRedondeado1 = new PanelRedondeado();
            label2 = new Label();
            label1 = new Label();
            botonRedondeado1 = new BotonRedondeado();
            txtDetalles = new TextBox();
            picPreview = new PictureBox();
            botonRedondeado2 = new BotonRedondeado();
            botonRedondeado3 = new BotonRedondeado();
            panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.SteelBlue;
            panelRedondeado1.Controls.Add(label2);
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Controls.Add(botonRedondeado1);
            panelRedondeado1.Location = new Point(0, -17);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(383, 81);
            panelRedondeado1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 35);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 3;
            label2.Text = "REPORTAR INCIDENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(3, 22);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(68, 56);
            botonRedondeado1.TabIndex = 1;
            botonRedondeado1.Text = " ←";
            botonRedondeado1.UseVisualStyleBackColor = true;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(24, 141);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.ScrollBars = ScrollBars.Vertical;
            txtDetalles.Size = new Size(323, 154);
            txtDetalles.TabIndex = 4;
            // 
            // picPreview
            // 
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(133, 311);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(214, 208);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 5;
            picPreview.TabStop = false;
            // 
            // botonRedondeado2
            // 
            botonRedondeado2.BackColor = Color.SteelBlue;
            botonRedondeado2.FlatAppearance.BorderSize = 0;
            botonRedondeado2.FlatStyle = FlatStyle.Flat;
            botonRedondeado2.ForeColor = Color.White;
            botonRedondeado2.Location = new Point(8, 398);
            botonRedondeado2.Name = "botonRedondeado2";
            botonRedondeado2.Size = new Size(119, 39);
            botonRedondeado2.TabIndex = 6;
            botonRedondeado2.Text = "Adjuntar Evidencia/Imagén";
            botonRedondeado2.UseVisualStyleBackColor = false;
            botonRedondeado2.Click += botonRedondeado2_Click;
            // 
            // botonRedondeado3
            // 
            botonRedondeado3.BackColor = Color.SteelBlue;
            botonRedondeado3.FlatAppearance.BorderSize = 0;
            botonRedondeado3.FlatStyle = FlatStyle.Flat;
            botonRedondeado3.ForeColor = Color.White;
            botonRedondeado3.Location = new Point(120, 554);
            botonRedondeado3.Name = "botonRedondeado3";
            botonRedondeado3.Size = new Size(110, 30);
            botonRedondeado3.TabIndex = 7;
            botonRedondeado3.Text = "Enviar Reporte";
            botonRedondeado3.UseVisualStyleBackColor = false;
            botonRedondeado3.Click += botonRedondeado3_Click;
            // 
            // FormReportar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 637);
            Controls.Add(botonRedondeado3);
            Controls.Add(botonRedondeado2);
            Controls.Add(picPreview);
            Controls.Add(txtDetalles);
            Controls.Add(panelRedondeado1);
            ForeColor = Color.White;
            Name = "FormReportar";
            Text = "FormReportar";
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PanelRedondeado panelRedondeado1;
        private BotonRedondeado botonRedondeado1;
        private Label label2;
        private Label label1;
        private TextBox txtDetalles;
        private PictureBox picPreview;
        private BotonRedondeado botonRedondeado2;
        private BotonRedondeado botonRedondeado3;
    }
}