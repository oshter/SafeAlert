namespace proyect
{
    partial class FormRegistro
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
            botonRedondeado1 = new BotonRedondeado();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNuevoNombre = new TextBoxRedondeado();
            txtNuevoCorreo = new TextBoxRedondeado();
            txtNuevoTelefono = new TextBoxRedondeado();
            txtNuevaContraseña = new TextBoxRedondeado();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            botonRedondeado2 = new BotonRedondeado();
            pictureBox3 = new PictureBox();
            panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.White;
            panelRedondeado1.Controls.Add(pictureBox3);
            panelRedondeado1.Controls.Add(botonRedondeado2);
            panelRedondeado1.Controls.Add(label8);
            panelRedondeado1.Controls.Add(botonRedondeado1);
            panelRedondeado1.Controls.Add(label7);
            panelRedondeado1.Controls.Add(label6);
            panelRedondeado1.Controls.Add(pictureBox2);
            panelRedondeado1.Controls.Add(label5);
            panelRedondeado1.Controls.Add(label4);
            panelRedondeado1.Controls.Add(label3);
            panelRedondeado1.Controls.Add(label2);
            panelRedondeado1.Controls.Add(txtNuevoNombre);
            panelRedondeado1.Controls.Add(txtNuevoCorreo);
            panelRedondeado1.Controls.Add(txtNuevoTelefono);
            panelRedondeado1.Controls.Add(txtNuevaContraseña);
            panelRedondeado1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelRedondeado1.Location = new Point(28, 152);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(323, 471);
            panelRedondeado1.TabIndex = 0;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.FromArgb(0, 0, 192);
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(34, 350);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(250, 41);
            botonRedondeado1.TabIndex = 13;
            botonRedondeado1.Text = "Crear Cuenta ->";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += btnRegistrarUsuario_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 434);
            label7.Name = "label7";
            label7.Size = new Size(226, 12);
            label7.TabIndex = 12;
            label7.Text = "Valoramos tu privacidad y seguridad por encima de todo.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(77, 421);
            label6.Name = "label6";
            label6.Size = new Size(152, 12);
            label6.TabIndex = 3;
            label6.Text = "Tus datos estan cifrados y protegidos.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngtree_blue_shield_icon_with_checkmark_symbolizing_security_protection_and_verified_approval_png_image_16317361_removebg_preview;
            pictureBox2.Location = new Point(24, 414);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 179);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 10;
            label5.Text = "Crear Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 128);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 77);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 8;
            label3.Text = "Correo Electrónico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 26);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre Completo";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.BackColor = Color.White;
            txtNuevoNombre.BorderColor = Color.Gray;
            txtNuevoNombre.BorderRadius = 15;
            txtNuevoNombre.Location = new Point(34, 44);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Padding = new Padding(10, 7, 10, 7);
            txtNuevoNombre.Size = new Size(250, 30);
            txtNuevoNombre.TabIndex = 3;
            txtNuevoNombre.TextWindow = "";
            // 
            // txtNuevoCorreo
            // 
            txtNuevoCorreo.BackColor = Color.White;
            txtNuevoCorreo.BorderColor = Color.Gray;
            txtNuevoCorreo.BorderRadius = 15;
            txtNuevoCorreo.Location = new Point(34, 95);
            txtNuevoCorreo.Name = "txtNuevoCorreo";
            txtNuevoCorreo.Padding = new Padding(10, 7, 10, 7);
            txtNuevoCorreo.Size = new Size(250, 30);
            txtNuevoCorreo.TabIndex = 4;
            txtNuevoCorreo.TextWindow = "";
            // 
            // txtNuevoTelefono
            // 
            txtNuevoTelefono.BackColor = Color.White;
            txtNuevoTelefono.BorderColor = Color.Gray;
            txtNuevoTelefono.BorderRadius = 15;
            txtNuevoTelefono.Location = new Point(33, 146);
            txtNuevoTelefono.Name = "txtNuevoTelefono";
            txtNuevoTelefono.Padding = new Padding(10, 7, 10, 7);
            txtNuevoTelefono.Size = new Size(250, 30);
            txtNuevoTelefono.TabIndex = 5;
            txtNuevoTelefono.TextWindow = "";
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.BackColor = Color.White;
            txtNuevaContraseña.BorderColor = Color.Gray;
            txtNuevaContraseña.BorderRadius = 15;
            txtNuevaContraseña.Location = new Point(33, 197);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Padding = new Padding(10, 7, 10, 7);
            txtNuevaContraseña.Size = new Size(250, 30);
            txtNuevaContraseña.TabIndex = 6;
            txtNuevaContraseña.TextWindow = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_06_16_at_9_391;
            pictureBox1.Location = new Point(53, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(42, 101);
            label1.Name = "label1";
            label1.Size = new Size(282, 18);
            label1.TabIndex = 2;
            label1.Text = "Protegiendo a nuestra comunidad, juntos.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 322);
            label8.Name = "label8";
            label8.Size = new Size(272, 12);
            label8.TabIndex = 3;
            label8.Text = "Opcional: si no seleccionas ninguna, puedes continuar con el registro";
            // 
            // botonRedondeado2
            // 
            botonRedondeado2.BackColor = Color.WhiteSmoke;
            botonRedondeado2.FlatAppearance.BorderSize = 0;
            botonRedondeado2.FlatStyle = FlatStyle.Flat;
            botonRedondeado2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado2.Location = new Point(34, 261);
            botonRedondeado2.Name = "botonRedondeado2";
            botonRedondeado2.Size = new Size(97, 41);
            botonRedondeado2.TabIndex = 14;
            botonRedondeado2.Text = "Seleccionar Foto";
            botonRedondeado2.UseVisualStyleBackColor = false;
            botonRedondeado2.Click += botonRedondeado2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(153, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 78);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(383, 635);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panelRedondeado1);
            Name = "FormRegistro";
            Text = "FormRegistro";
            Load += FormRegistro_Load;
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PanelRedondeado panelRedondeado1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBoxRedondeado txtNuevoNombre;
        private TextBoxRedondeado txtNuevoCorreo;
        private TextBoxRedondeado txtNuevoTelefono;
        private TextBoxRedondeado txtNuevaContraseña;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private BotonRedondeado botonRedondeado1;
        private PictureBox pictureBox3;
        private BotonRedondeado botonRedondeado2;
        private Label label8;
    }
}