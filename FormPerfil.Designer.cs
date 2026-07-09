namespace proyect
{
    partial class FormPerfil
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
            botonRedondeado3 = new BotonRedondeado();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            NombreC = new Label();
            CorreoE = new Label();
            Telefono1 = new Label();
            txtNombreCompleto1 = new TextBoxRedondeado();
            txtCorreo1 = new TextBoxRedondeado();
            txtTelefono1 = new TextBoxRedondeado();
            botonRedondeado1 = new BotonRedondeado();
            botonRedondeado2 = new BotonRedondeado();
            btnEliminarCuenta = new BotonRedondeado();
            panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.SteelBlue;
            panelRedondeado1.Controls.Add(botonRedondeado3);
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Location = new Point(0, -20);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(365, 84);
            panelRedondeado1.TabIndex = 1;
            // 
            // botonRedondeado3
            // 
            botonRedondeado3.FlatAppearance.BorderSize = 0;
            botonRedondeado3.FlatStyle = FlatStyle.Flat;
            botonRedondeado3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado3.ForeColor = Color.White;
            botonRedondeado3.Location = new Point(3, 22);
            botonRedondeado3.Name = "botonRedondeado3";
            botonRedondeado3.Size = new Size(68, 60);
            botonRedondeado3.TabIndex = 13;
            botonRedondeado3.Text = " ←";
            botonRedondeado3.UseVisualStyleBackColor = true;
            botonRedondeado3.Click += botonRedondeado3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 38);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 2;
            label1.Text = "Mi Perfil";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._15791af5a4f75157cdecf1bc752088e4;
            pictureBox2.Location = new Point(115, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 208);
            label2.Name = "label2";
            label2.Size = new Size(169, 18);
            label2.TabIndex = 3;
            label2.Text = "Información Personal";
            // 
            // NombreC
            // 
            NombreC.AutoSize = true;
            NombreC.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NombreC.Location = new Point(12, 251);
            NombreC.Name = "NombreC";
            NombreC.Size = new Size(124, 17);
            NombreC.TabIndex = 4;
            NombreC.Text = "Nombre Completo:";
            // 
            // CorreoE
            // 
            CorreoE.AutoSize = true;
            CorreoE.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CorreoE.Location = new Point(12, 294);
            CorreoE.Name = "CorreoE";
            CorreoE.Size = new Size(122, 17);
            CorreoE.TabIndex = 5;
            CorreoE.Text = "Correo Electrónico:";
            // 
            // Telefono1
            // 
            Telefono1.AutoSize = true;
            Telefono1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Telefono1.Location = new Point(12, 342);
            Telefono1.Name = "Telefono1";
            Telefono1.Size = new Size(62, 17);
            Telefono1.TabIndex = 6;
            Telefono1.Text = "Teléfono:";
            // 
            // txtNombreCompleto1
            // 
            txtNombreCompleto1.BackColor = Color.White;
            txtNombreCompleto1.BorderColor = Color.Gray;
            txtNombreCompleto1.BorderRadius = 15;
            txtNombreCompleto1.Location = new Point(133, 247);
            txtNombreCompleto1.Name = "txtNombreCompleto1";
            txtNombreCompleto1.Padding = new Padding(10, 7, 10, 7);
            txtNombreCompleto1.Size = new Size(223, 30);
            txtNombreCompleto1.TabIndex = 8;
            txtNombreCompleto1.TextWindow = "";
            txtNombreCompleto1.Load += txtNombreCompleto1_Load;
            // 
            // txtCorreo1
            // 
            txtCorreo1.BackColor = Color.White;
            txtCorreo1.BorderColor = Color.Gray;
            txtCorreo1.BorderRadius = 15;
            txtCorreo1.Location = new Point(133, 290);
            txtCorreo1.Name = "txtCorreo1";
            txtCorreo1.Padding = new Padding(10, 7, 10, 7);
            txtCorreo1.Size = new Size(223, 30);
            txtCorreo1.TabIndex = 9;
            txtCorreo1.TextWindow = "";
            // 
            // txtTelefono1
            // 
            txtTelefono1.BackColor = Color.White;
            txtTelefono1.BorderColor = Color.Gray;
            txtTelefono1.BorderRadius = 15;
            txtTelefono1.Location = new Point(133, 336);
            txtTelefono1.Name = "txtTelefono1";
            txtTelefono1.Padding = new Padding(10, 7, 10, 7);
            txtTelefono1.Size = new Size(223, 30);
            txtTelefono1.TabIndex = 10;
            txtTelefono1.TextWindow = "";
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.SteelBlue;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(12, 433);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(133, 33);
            botonRedondeado1.TabIndex = 11;
            botonRedondeado1.Text = "Guardar";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // botonRedondeado2
            // 
            botonRedondeado2.BackColor = Color.SteelBlue;
            botonRedondeado2.FlatAppearance.BorderSize = 0;
            botonRedondeado2.FlatStyle = FlatStyle.Flat;
            botonRedondeado2.ForeColor = Color.White;
            botonRedondeado2.Location = new Point(208, 433);
            botonRedondeado2.Name = "botonRedondeado2";
            botonRedondeado2.Size = new Size(132, 33);
            botonRedondeado2.TabIndex = 12;
            botonRedondeado2.Text = "Cambiar contraseña";
            botonRedondeado2.UseVisualStyleBackColor = false;
            botonRedondeado2.Click += botonRedondeado2_Click;
            // 
            // btnEliminarCuenta
            // 
            btnEliminarCuenta.BackColor = Color.Red;
            btnEliminarCuenta.FlatAppearance.BorderSize = 0;
            btnEliminarCuenta.FlatStyle = FlatStyle.Flat;
            btnEliminarCuenta.ForeColor = Color.White;
            btnEliminarCuenta.Location = new Point(124, 548);
            btnEliminarCuenta.Name = "btnEliminarCuenta";
            btnEliminarCuenta.Size = new Size(104, 23);
            btnEliminarCuenta.TabIndex = 13;
            btnEliminarCuenta.Text = "Eliminar Cuenta";
            btnEliminarCuenta.UseVisualStyleBackColor = false;
            btnEliminarCuenta.Click += btnEliminarCuenta_Click;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 628);
            Controls.Add(btnEliminarCuenta);
            Controls.Add(botonRedondeado2);
            Controls.Add(botonRedondeado1);
            Controls.Add(txtTelefono1);
            Controls.Add(txtCorreo1);
            Controls.Add(txtNombreCompleto1);
            Controls.Add(Telefono1);
            Controls.Add(CorreoE);
            Controls.Add(NombreC);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panelRedondeado1);
            Name = "FormPerfil";
            Text = "FormPerfil";
            Load += FormPerfil_Load;
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PanelRedondeado panelRedondeado1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label NombreC;
        private Label CorreoE;
        private Label Telefono1;
        private TextBoxRedondeado txtNombreCompleto1;
        private TextBoxRedondeado txtCorreo1;
        private TextBoxRedondeado txtTelefono1;
        private BotonRedondeado botonRedondeado1;
        private BotonRedondeado botonRedondeado2;
        private BotonRedondeado botonRedondeado3;
        private BotonRedondeado btnEliminarCuenta;
    }
}