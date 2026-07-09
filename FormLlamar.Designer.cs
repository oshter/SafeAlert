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
            panelRedondeado1.Location = new Point(0, -10);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(381, 74);
            panelRedondeado1.TabIndex = 0;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.SteelBlue;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(3, 15);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(68, 56);
            botonRedondeado1.TabIndex = 1;
            botonRedondeado1.Text = " ←";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 28);
            label1.Name = "label1";
            label1.Size = new Size(268, 25);
            label1.TabIndex = 1;
            label1.Text = "LLAMADAS DE EMERGENCIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 128);
            label2.Name = "label2";
            label2.Size = new Size(181, 17);
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
            btnPolicia.Location = new Point(21, 173);
            btnPolicia.Name = "btnPolicia";
            btnPolicia.Size = new Size(123, 104);
            btnPolicia.TabIndex = 2;
            btnPolicia.Text = "\r\n\r\n\r\nPolicía Local";
            btnPolicia.UseVisualStyleBackColor = false;
            btnPolicia.Click += btnPolicia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 63);
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
            btnBomberos.Location = new Point(212, 173);
            btnBomberos.Name = "btnBomberos";
            btnBomberos.Size = new Size(123, 104);
            btnBomberos.TabIndex = 5;
            btnBomberos.Text = "\r\n\r\n\r\nBomberos";
            btnBomberos.UseVisualStyleBackColor = false;
            btnBomberos.Click += btnBomberos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox2.Image = Properties.Resources.image__1_;
            pictureBox2.Location = new Point(234, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 63);
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
            botonRedondeado2.Location = new Point(117, 325);
            botonRedondeado2.Name = "botonRedondeado2";
            botonRedondeado2.Size = new Size(123, 104);
            botonRedondeado2.TabIndex = 7;
            botonRedondeado2.Text = "\r\n\r\n\r\nCruz Roja / Ambulancia";
            botonRedondeado2.UseVisualStyleBackColor = false;
            botonRedondeado2.Click += botonRedondeado2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cruz_roja;
            pictureBox3.Location = new Point(129, 325);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.SteelBlue;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(118, 511);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(123, 41);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar Directorio";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormLlamar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 631);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox3);
            Controls.Add(botonRedondeado2);
            Controls.Add(pictureBox2);
            Controls.Add(btnBomberos);
            Controls.Add(pictureBox1);
            Controls.Add(btnPolicia);
            Controls.Add(label2);
            Controls.Add(panelRedondeado1);
            Name = "FormLlamar";
            Text = "FormLlamar";
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