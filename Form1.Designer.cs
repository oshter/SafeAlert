namespace proyect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            colorDialog1 = new ColorDialog();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCorreo = new TextBoxRedondeado();
            txtContrasena = new TextBoxRedondeado();
            btnIniciar = new BotonRedondeado();
            btnOlvidasteContraseña = new BotonRedondeado();
            btnGoogle = new BotonRedondeado();
            btnFacebook = new BotonRedondeado();
            btnRegistrarte = new BotonRedondeado();
            panelRedondeado1 = new PanelRedondeado();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_06_12_at_10_39_41_AM;
            pictureBox1.Location = new Point(110, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2026_06_16_at_9_39_00_AM;
            pictureBox2.Location = new Point(92, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.facebook_logo_1080029_107_convertido_de_avif_removebg_preview;
            pictureBox4.Location = new Point(204, 552);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Google__G__logo_svg__1__convertido_de_webp_removebg_preview_removebg_preview;
            pictureBox3.Location = new Point(49, 552);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(177, 519);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 4;
            label6.Text = "Or";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(222, 519);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 7;
            label5.Text = "──────────────";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(63, 519);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "──────────────";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(31, 362);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(31, 271);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 4;
            label2.Text = "Correo Electrónico:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(64, 223);
            label1.Name = "label1";
            label1.Size = new Size(266, 25);
            label1.TabIndex = 3;
            label1.Text = "Community Security Network";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderColor = Color.Gray;
            txtCorreo.BorderRadius = 15;
            txtCorreo.Location = new Point(31, 292);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(10, 7, 10, 7);
            txtCorreo.Size = new Size(304, 30);
            txtCorreo.TabIndex = 2;
            txtCorreo.TextWindow = "";
            txtCorreo.Load += txtCorreo_Load;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.White;
            txtContrasena.BorderColor = Color.Gray;
            txtContrasena.BorderRadius = 15;
            txtContrasena.Location = new Point(31, 383);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(10, 7, 10, 7);
            txtContrasena.Size = new Size(304, 30);
            txtContrasena.TabIndex = 3;
            txtContrasena.TextWindow = "";
            txtContrasena.Load += txtContraseña_Load;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Blue;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(51, 440);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(262, 61);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar Sesión I↩";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnOlvidasteContraseña
            // 
            btnOlvidasteContraseña.BackColor = Color.White;
            btnOlvidasteContraseña.FlatStyle = FlatStyle.Flat;
            btnOlvidasteContraseña.ForeColor = Color.Blue;
            btnOlvidasteContraseña.Location = new Point(166, 360);
            btnOlvidasteContraseña.Name = "btnOlvidasteContraseña";
            btnOlvidasteContraseña.Size = new Size(160, 24);
            btnOlvidasteContraseña.TabIndex = 5;
            btnOlvidasteContraseña.Text = "¿Olvidaste tu contraseña?";
            btnOlvidasteContraseña.UseVisualStyleBackColor = false;
            btnOlvidasteContraseña.Click += btnOlvidasteContraseña_Click;
            // 
            // btnGoogle
            // 
            btnGoogle.BackColor = Color.Transparent;
            btnGoogle.FlatStyle = FlatStyle.Flat;
            btnGoogle.Location = new Point(38, 548);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(140, 34);
            btnGoogle.TabIndex = 6;
            btnGoogle.Text = "Google";
            btnGoogle.UseVisualStyleBackColor = false;
            btnGoogle.Click += btnGoogle_Click;
            // 
            // btnFacebook
            // 
            btnFacebook.BackColor = SystemColors.ControlLight;
            btnFacebook.FlatStyle = FlatStyle.Flat;
            btnFacebook.Location = new Point(202, 548);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Size = new Size(140, 34);
            btnFacebook.TabIndex = 7;
            btnFacebook.Text = "Facebook";
            btnFacebook.UseVisualStyleBackColor = false;
            btnFacebook.Click += btnFacebook_Click;
            // 
            // btnRegistrarte
            // 
            btnRegistrarte.BackColor = Color.White;
            btnRegistrarte.FlatStyle = FlatStyle.Flat;
            btnRegistrarte.ForeColor = Color.Blue;
            btnRegistrarte.Location = new Point(97, 598);
            btnRegistrarte.Name = "btnRegistrarte";
            btnRegistrarte.Size = new Size(200, 34);
            btnRegistrarte.TabIndex = 8;
            btnRegistrarte.Text = "Registrarte";
            btnRegistrarte.UseVisualStyleBackColor = false;
            btnRegistrarte.Click += btnRegistrarte_Click;
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.White;
            panelRedondeado1.Location = new Point(26, 251);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(328, 384);
            panelRedondeado1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(364, 628);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(txtContrasena);
            Controls.Add(btnIniciar);
            Controls.Add(btnOlvidasteContraseña);
            Controls.Add(btnGoogle);
            Controls.Add(btnFacebook);
            Controls.Add(btnRegistrarte);
            Controls.Add(panelRedondeado1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ColorDialog colorDialog1;
        private PanelRedondeado panelRedondeado1;
        private Label label1;
        private Label label2;
        private Label label3;
        private BotonRedondeado btnOlvidasteContraseña;
        private TextBoxRedondeado txtContrasena;
        private TextBoxRedondeado txtCorreo;
        private BotonRedondeado btnIniciar;
        private BotonRedondeado btnGoogle;
        private Label label6;
        private Label label5;
        private Label label4;
        private BotonRedondeado btnFacebook;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private BotonRedondeado btnRegistrarte;
    }
}
