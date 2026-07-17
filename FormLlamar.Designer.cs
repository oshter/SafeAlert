namespace proyect
{
    partial class FormLlamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLlamar));
            panelRedondeado1 = new PanelRedondeado();
            botonRedondeado1 = new BotonRedondeado();
            label1 = new Label();
            label2 = new Label();
            btnPolicia = new BotonRedondeado();
            pictureBox1 = new PictureBox();
            btnBomberos = new BotonRedondeado();
            pictureBox2 = new PictureBox();
            botonRedondeado2 = new BotonRedondeado();
            pictureBox3 = new PictureBox();
            btnCerrar = new BotonRedondeado();
            panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.SteelBlue;
            panelRedondeado1.Controls.Add(botonRedondeado1);
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Location = new Point(0, -17);
            panelRedondeado1.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(544, 123);
            panelRedondeado1.TabIndex = 0;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.Transparent;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(4, 25);
            botonRedondeado1.Margin = new Padding(4, 5, 4, 5);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(97, 93);
            botonRedondeado1.TabIndex = 1;
            botonRedondeado1.Text = " ←";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 36);
            label1.TabIndex = 1;
            label1.Text = "LLAMADAS DE EMERGENCIA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 213);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(284, 28);
            label2.TabIndex = 1;
            label2.Text = "Seleccione una dependencia:";
            label2.Click += label2_Click;
            // 
            // btnPolicia
            // 
            btnPolicia.BackColor = Color.DodgerBlue;
            btnPolicia.FlatAppearance.BorderSize = 0;
            btnPolicia.FlatStyle = FlatStyle.Flat;
            btnPolicia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPolicia.ForeColor = Color.White;
            btnPolicia.Location = new Point(30, 288);
            btnPolicia.Margin = new Padding(4, 5, 4, 5);
            btnPolicia.Name = "btnPolicia";
            btnPolicia.Size = new Size(176, 173);
            btnPolicia.TabIndex = 2;
            btnPolicia.Text = "\r\n\r\n\r\nPolicía Local";
            btnPolicia.UseVisualStyleBackColor = false;
            btnPolicia.Click += btnPolicia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 303);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnBomberos
            // 
            btnBomberos.BackColor = Color.FromArgb(192, 0, 0);
            btnBomberos.FlatAppearance.BorderSize = 0;
            btnBomberos.FlatStyle = FlatStyle.Flat;
            btnBomberos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBomberos.ForeColor = Color.White;
            btnBomberos.Location = new Point(303, 288);
            btnBomberos.Margin = new Padding(4, 5, 4, 5);
            btnBomberos.Name = "btnBomberos";
            btnBomberos.Size = new Size(176, 173);
            btnBomberos.TabIndex = 5;
            btnBomberos.Text = "\r\n\r\n\r\nBomberos";
            btnBomberos.UseVisualStyleBackColor = false;
            btnBomberos.Click += btnBomberos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox2.Image = Properties.Resources.image__1_;
            pictureBox2.Location = new Point(334, 303);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // botonRedondeado2
            // 
            botonRedondeado2.BackColor = Color.White;
            botonRedondeado2.FlatAppearance.BorderSize = 0;
            botonRedondeado2.FlatStyle = FlatStyle.Flat;
            botonRedondeado2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado2.ForeColor = Color.Red;
            botonRedondeado2.Location = new Point(167, 542);
            botonRedondeado2.Margin = new Padding(4, 5, 4, 5);
            botonRedondeado2.Name = "botonRedondeado2";
            botonRedondeado2.Size = new Size(176, 173);
            botonRedondeado2.TabIndex = 7;
            botonRedondeado2.Text = "\r\n\r\n\r\nCruz Roja / Ambulancia";
            botonRedondeado2.UseVisualStyleBackColor = false;
            botonRedondeado2.Click += botonRedondeado2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cruz_roja;
            pictureBox3.Location = new Point(184, 542);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.SteelBlue;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(169, 852);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(176, 68);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar Directorio";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormLlamar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 1050);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox3);
            Controls.Add(botonRedondeado2);
            Controls.Add(pictureBox2);
            Controls.Add(btnBomberos);
            Controls.Add(pictureBox1);
            Controls.Add(btnPolicia);
            Controls.Add(label2);
            Controls.Add(panelRedondeado1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLlamar";
            Text = "FormLlamar";
            Load += FormLlamar_Load;
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PanelRedondeado panelRedondeado1;
        private Label label1;
        private BotonRedondeado botonRedondeado1;
        private Label label2;
        private BotonRedondeado btnPolicia;
        private PictureBox pictureBox1;
        private BotonRedondeado btnBomberos;
        private PictureBox pictureBox2;
        private BotonRedondeado botonRedondeado2;
        private PictureBox pictureBox3;
        private BotonRedondeado btnCerrar;
    }
}