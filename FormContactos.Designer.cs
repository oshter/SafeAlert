namespace proyect
{
    partial class FormContactos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvContactos = new DataGridView();
            txtContacto = new TextBoxRedondeado();
            txtTelefono = new TextBoxRedondeado();
            btnAgregar = new BotonRedondeado();
            btnEliminar = new BotonRedondeado();
            btnModificarContactos = new BotonRedondeado();
            panelRedondeado2 = new PanelRedondeado();
            botonRedondeado3 = new BotonRedondeado();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            panelRedondeado2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 36);
            label1.TabIndex = 3;
            label1.Text = "CONTACTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 28);
            label2.TabIndex = 4;
            label2.Text = "Nombre del contacto:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 6;
            label3.Text = "Teléfono:";
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(24, 465);
            dgvContactos.Margin = new Padding(4, 5, 4, 5);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.RowHeadersWidth = 62;
            dgvContactos.Size = new Size(497, 592);
            dgvContactos.TabIndex = 9;
            dgvContactos.CellClick += dgvContactos_CellClick;
            // 
            // txtContacto
            // 
            txtContacto.BackColor = Color.White;
            txtContacto.BorderColor = Color.Gray;
            txtContacto.BorderRadius = 15;
            txtContacto.Location = new Point(259, 163);
            txtContacto.Margin = new Padding(4, 5, 4, 5);
            txtContacto.Name = "txtContacto";
            txtContacto.Padding = new Padding(14, 12, 14, 12);
            txtContacto.Size = new Size(262, 38);
            txtContacto.TabIndex = 5;
            txtContacto.TextWindow = "";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderColor = Color.Gray;
            txtTelefono.BorderRadius = 15;
            txtTelefono.Location = new Point(259, 225);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(14, 12, 14, 12);
            txtTelefono.Size = new Size(262, 38);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextWindow = "";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SteelBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(19, 335);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 50);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(380, 335);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 50);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificarContactos
            // 
            btnModificarContactos.BackColor = Color.FromArgb(255, 128, 0);
            btnModificarContactos.FlatStyle = FlatStyle.Flat;
            btnModificarContactos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarContactos.ForeColor = Color.White;
            btnModificarContactos.Location = new Point(184, 335);
            btnModificarContactos.Margin = new Padding(4, 5, 4, 5);
            btnModificarContactos.Name = "btnModificarContactos";
            btnModificarContactos.Size = new Size(174, 50);
            btnModificarContactos.TabIndex = 9;
            btnModificarContactos.Text = "Modificar";
            btnModificarContactos.UseVisualStyleBackColor = false;
            btnModificarContactos.Click += btnModificarContactos_Click;
            // 
            // panelRedondeado2
            // 
            panelRedondeado2.BackColor = Color.SteelBlue;
            panelRedondeado2.Controls.Add(botonRedondeado3);
            panelRedondeado2.Controls.Add(label1);
            panelRedondeado2.Location = new Point(0, -40);
            panelRedondeado2.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado2.Name = "panelRedondeado2";
            panelRedondeado2.Size = new Size(541, 150);
            panelRedondeado2.TabIndex = 11;
            // 
            // botonRedondeado3
            // 
            botonRedondeado3.FlatAppearance.BorderSize = 0;
            botonRedondeado3.FlatStyle = FlatStyle.Flat;
            botonRedondeado3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado3.ForeColor = Color.White;
            botonRedondeado3.Location = new Point(4, 45);
            botonRedondeado3.Margin = new Padding(4, 5, 4, 5);
            botonRedondeado3.Name = "botonRedondeado3";
            botonRedondeado3.Size = new Size(97, 100);
            botonRedondeado3.TabIndex = 14;
            botonRedondeado3.Text = " ←";
            botonRedondeado3.UseVisualStyleBackColor = true;
            botonRedondeado3.Click += botonRedondeado3_Click;
            // 
            // FormContactos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 1050);
            Controls.Add(label2);
            Controls.Add(txtContacto);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificarContactos);
            Controls.Add(dgvContactos);
            Controls.Add(panelRedondeado2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormContactos";
            Text = "FormContactos";
            Load += FormContactos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            panelRedondeado2.ResumeLayout(false);
            panelRedondeado2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PanelRedondeado panelRedondeado1;
        private TextBoxRedondeado txtContacto;
        private TextBoxRedondeado txtTelefono;
        private BotonRedondeado btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvContactos;
        private BotonRedondeado btnEliminar;
        private BotonRedondeado btnModificarContactos;
        private PanelRedondeado panelRedondeado2;
        private BotonRedondeado botonRedondeado3;
    }
}