namespace proyect
{
    partial class FormGestorUsuarios
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
            panelRedondeado4 = new PanelRedondeado();
            label4 = new Label();
            btnMenú = new BotonRedondeado();
            txtNombreGestor = new TextBoxRedondeado();
            txtCorreoGestor = new TextBoxRedondeado();
            txtTelefonoGestor = new TextBoxRedondeado();
            btnRegistrar = new BotonRedondeado();
            btnActualizar = new BotonRedondeado();
            btnDarBaja = new BotonRedondeado();
            dgvUsuariosGestor = new DataGridView();
            txtBuscador = new TextBoxRedondeado();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panelRedondeado4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosGestor).BeginInit();
            SuspendLayout();
            // 
            // panelRedondeado4
            // 
            panelRedondeado4.BackColor = Color.SteelBlue;
            panelRedondeado4.Controls.Add(label4);
            panelRedondeado4.Controls.Add(btnMenú);
            panelRedondeado4.Location = new Point(0, -20);
            panelRedondeado4.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado4.Name = "panelRedondeado4";
            panelRedondeado4.Size = new Size(517, 130);
            panelRedondeado4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(115, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(290, 36);
            label4.TabIndex = 0;
            label4.Text = "GESTOR DE USUARIOS";
            // 
            // btnMenú
            // 
            btnMenú.FlatAppearance.BorderSize = 0;
            btnMenú.FlatStyle = FlatStyle.Flat;
            btnMenú.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenú.ForeColor = Color.White;
            btnMenú.Location = new Point(4, 23);
            btnMenú.Margin = new Padding(4, 5, 4, 5);
            btnMenú.Name = "btnMenú";
            btnMenú.Size = new Size(103, 82);
            btnMenú.TabIndex = 5;
            btnMenú.Text = " ←";
            btnMenú.UseVisualStyleBackColor = true;
            btnMenú.Click += btnMenú_Click;
            // 
            // txtNombreGestor
            // 
            txtNombreGestor.BackColor = Color.White;
            txtNombreGestor.BorderColor = Color.Gray;
            txtNombreGestor.BorderRadius = 15;
            txtNombreGestor.Location = new Point(34, 172);
            txtNombreGestor.Margin = new Padding(4, 5, 4, 5);
            txtNombreGestor.Name = "txtNombreGestor";
            txtNombreGestor.Padding = new Padding(14, 12, 14, 12);
            txtNombreGestor.Size = new Size(357, 38);
            txtNombreGestor.TabIndex = 6;
            txtNombreGestor.TextWindow = "";
            // 
            // txtCorreoGestor
            // 
            txtCorreoGestor.BackColor = Color.White;
            txtCorreoGestor.BorderColor = Color.Gray;
            txtCorreoGestor.BorderRadius = 15;
            txtCorreoGestor.Location = new Point(34, 255);
            txtCorreoGestor.Margin = new Padding(4, 5, 4, 5);
            txtCorreoGestor.Name = "txtCorreoGestor";
            txtCorreoGestor.Padding = new Padding(14, 12, 14, 12);
            txtCorreoGestor.Size = new Size(357, 38);
            txtCorreoGestor.TabIndex = 7;
            txtCorreoGestor.TextWindow = "";
            // 
            // txtTelefonoGestor
            // 
            txtTelefonoGestor.BackColor = Color.White;
            txtTelefonoGestor.BorderColor = Color.Gray;
            txtTelefonoGestor.BorderRadius = 15;
            txtTelefonoGestor.Location = new Point(34, 340);
            txtTelefonoGestor.Margin = new Padding(4, 5, 4, 5);
            txtTelefonoGestor.Name = "txtTelefonoGestor";
            txtTelefonoGestor.Padding = new Padding(14, 12, 14, 12);
            txtTelefonoGestor.Size = new Size(357, 38);
            txtTelefonoGestor.TabIndex = 8;
            txtTelefonoGestor.TextWindow = "";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SteelBlue;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(34, 433);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(141, 53);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Green;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(184, 433);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(141, 53);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.Firebrick;
            btnDarBaja.FlatAppearance.BorderSize = 0;
            btnDarBaja.FlatStyle = FlatStyle.Flat;
            btnDarBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja.ForeColor = Color.White;
            btnDarBaja.Location = new Point(340, 433);
            btnDarBaja.Margin = new Padding(4, 5, 4, 5);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(141, 53);
            btnDarBaja.TabIndex = 11;
            btnDarBaja.Text = "Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // dgvUsuariosGestor
            // 
            dgvUsuariosGestor.BackgroundColor = Color.White;
            dgvUsuariosGestor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosGestor.Location = new Point(34, 615);
            dgvUsuariosGestor.Margin = new Padding(4, 5, 4, 5);
            dgvUsuariosGestor.Name = "dgvUsuariosGestor";
            dgvUsuariosGestor.RowHeadersWidth = 62;
            dgvUsuariosGestor.Size = new Size(447, 409);
            dgvUsuariosGestor.TabIndex = 12;
            dgvUsuariosGestor.CellClick += dgvUsuariosGestor_CellClick;
            dgvUsuariosGestor.CellContentClick += dgvUsuariosGestor_CellContentClick;
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.White;
            txtBuscador.BorderColor = Color.Gray;
            txtBuscador.BorderRadius = 15;
            txtBuscador.Location = new Point(34, 555);
            txtBuscador.Margin = new Padding(4, 5, 4, 5);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Padding = new Padding(14, 12, 14, 12);
            txtBuscador.Size = new Size(447, 38);
            txtBuscador.TabIndex = 13;
            txtBuscador.TextWindow = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 14;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 15;
            label2.Text = "Correo Electrónico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 310);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 16;
            label3.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 522);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 17;
            label5.Text = "Buscar por Correo";
            // 
            // FormGestorUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 1050);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(dgvUsuariosGestor);
            Controls.Add(btnDarBaja);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTelefonoGestor);
            Controls.Add(txtCorreoGestor);
            Controls.Add(txtNombreGestor);
            Controls.Add(panelRedondeado4);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGestorUsuarios";
            Text = "FormGestorUsuarios";
            Load += FormGestorUsuarios_Load_1;
            panelRedondeado4.ResumeLayout(false);
            panelRedondeado4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosGestor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PanelRedondeado panelRedondeado4;
        private Label label4;
        private BotonRedondeado btnMenú;
        private TextBoxRedondeado txtNombreGestor;
        private TextBoxRedondeado txtCorreoGestor;
        private TextBoxRedondeado txtTelefonoGestor;
        private BotonRedondeado btnRegistrar;
        private BotonRedondeado btnActualizar;
        private BotonRedondeado btnDarBaja;
        private DataGridView dgvUsuariosGestor;
        private TextBoxRedondeado txtBuscador;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}