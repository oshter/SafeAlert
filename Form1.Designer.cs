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
            panelRedondeado1.SuspendLayout();
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
            pictureBox4.Location = new Point(173, 380);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Google__G__logo_svg__1__convertido_de_webp_removebg_preview_removebg_preview;
            pictureBox3.Location = new Point(15, 380);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(153, 337);
            label6.Name = "label6";
            label6.Size = new Size(32, 25);
            label6.TabIndex = 4;
            label6.Text = "Or";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(191, 337);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 7;
            label5.Text = "──────────────";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(9, 337);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 4;
            label4.Text = "──────────────";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(15, 123);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(15, 33);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 4;
            label2.Text = "Correo Electrónico:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(25, 208);
            label1.Name = "label1";
            label1.Size = new Size(351, 32);
            label1.TabIndex = 3;
            label1.Text = "Community Security Network";
            label1.Click += label1_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderColor = Color.Gray;
            txtCorreo.BorderRadius = 15;
            txtCorreo.Location = new Point(15, 64);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(10, 7, 10, 7);
            txtCorreo.Size = new Size(304, 38);
            txtCorreo.TabIndex = 2;
            txtCorreo.TextWindow = "";
            txtCorreo.Load += txtCorreo_Load;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.White;
            txtContrasena.BorderColor = Color.Gray;
            txtContrasena.BorderRadius = 15;
            txtContrasena.Location = new Point(15, 154);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(10, 7, 10, 7);
            txtContrasena.Size = new Size(304, 38);
            txtContrasena.TabIndex = 3;
            txtContrasena.TextWindow = "";
            txtContrasena.Load += txtContraseña_Load;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.SteelBlue;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(39, 252);
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
            btnOlvidasteContraseña.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOlvidasteContraseña.ForeColor = Color.Blue;
            btnOlvidasteContraseña.Location = new Point(136, 123);
            btnOlvidasteContraseña.Name = "btnOlvidasteContraseña";
            btnOlvidasteContraseña.Size = new Size(193, 24);
            btnOlvidasteContraseña.TabIndex = 5;
            btnOlvidasteContraseña.Text = "¿Olvidaste tu contraseña?";
            btnOlvidasteContraseña.UseVisualStyleBackColor = false;
            btnOlvidasteContraseña.Click += btnOlvidasteContraseña_Click;
            // 
            // btnGoogle
            // 
            btnGoogle.BackColor = Color.WhiteSmoke;
            btnGoogle.FlatStyle = FlatStyle.Flat;
            btnGoogle.Location = new Point(15, 380);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(140, 34);
            btnGoogle.TabIndex = 6;
            btnGoogle.Text = "Google";
            btnGoogle.UseVisualStyleBackColor = false;
            btnGoogle.Click += btnGoogle_Click;
            // 
            // btnFacebook
            // 
            btnFacebook.BackColor = Color.WhiteSmoke;
            btnFacebook.FlatStyle = FlatStyle.Flat;
            btnFacebook.Location = new Point(178, 380);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Size = new Size(140, 34);
            btnFacebook.TabIndex = 7;
            btnFacebook.Text = "Facebook";
            btnFacebook.UseVisualStyleBackColor = false;
            btnFacebook.Click += btnFacebook_Click;
            // 
            // btnRegistrarte
            // 
            btnRegistrarte.BackColor = Color.WhiteSmoke;
            btnRegistrarte.FlatStyle = FlatStyle.Flat;
            btnRegistrarte.ForeColor = Color.Blue;
            btnRegistrarte.Location = new Point(57, 437);
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
            panelRedondeado1.Controls.Add(pictureBox3);
            panelRedondeado1.Controls.Add(btnRegistrarte);
            panelRedondeado1.Controls.Add(btnGoogle);
            panelRedondeado1.Controls.Add(label2);
            panelRedondeado1.Controls.Add(pictureBox4);
            panelRedondeado1.Controls.Add(txtCorreo);
            panelRedondeado1.Controls.Add(label3);
            panelRedondeado1.Controls.Add(btnOlvidasteContraseña);
            panelRedondeado1.Controls.Add(btnFacebook);
            panelRedondeado1.Controls.Add(label5);
            panelRedondeado1.Controls.Add(txtContrasena);
            panelRedondeado1.Controls.Add(label4);
            panelRedondeado1.Controls.Add(btnIniciar);
            panelRedondeado1.Controls.Add(label6);
            panelRedondeado1.Location = new Point(27, 243);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(341, 492);
            panelRedondeado1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(393, 789);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panelRedondeado1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
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
