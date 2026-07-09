namespace proyect
{
    partial class FormRutas
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
            txtNombreRuta = new TextBoxRedondeado();
            txtLatitud = new TextBoxRedondeado();
            txtLongitud = new TextBoxRedondeado();
            nmcRadio = new NumericUpDown();
            btnGuardar = new BotonRedondeado();
            btnEliminar = new BotonRedondeado();
            dataGridView1 = new DataGridView();
            panelRedondeado1 = new PanelRedondeado();
            label1 = new Label();
            botonRedondeado1 = new BotonRedondeado();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnModificar = new BotonRedondeado();
            ((System.ComponentModel.ISupportInitialize)nmcRadio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelRedondeado1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.BackColor = Color.White;
            txtNombreRuta.BorderColor = Color.Gray;
            txtNombreRuta.BorderRadius = 15;
            txtNombreRuta.Location = new Point(127, 82);
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Padding = new Padding(10, 7, 10, 7);
            txtNombreRuta.Size = new Size(239, 30);
            txtNombreRuta.TabIndex = 0;
            txtNombreRuta.TextWindow = "";
            // 
            // txtLatitud
            // 
            txtLatitud.BackColor = Color.White;
            txtLatitud.BorderColor = Color.Gray;
            txtLatitud.BorderRadius = 15;
            txtLatitud.Location = new Point(127, 122);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Padding = new Padding(10, 7, 10, 7);
            txtLatitud.Size = new Size(239, 30);
            txtLatitud.TabIndex = 1;
            txtLatitud.TextWindow = "";
            // 
            // txtLongitud
            // 
            txtLongitud.BackColor = Color.White;
            txtLongitud.BorderColor = Color.Gray;
            txtLongitud.BorderRadius = 15;
            txtLongitud.Location = new Point(127, 163);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Padding = new Padding(10, 7, 10, 7);
            txtLongitud.Size = new Size(239, 30);
            txtLongitud.TabIndex = 2;
            txtLongitud.TextWindow = "";
            // 
            // nmcRadio
            // 
            nmcRadio.Location = new Point(246, 209);
            nmcRadio.Name = "nmcRadio";
            nmcRadio.Size = new Size(120, 23);
            nmcRadio.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(12, 257);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 32);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Ruta";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(267, 257);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 32);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(354, 319);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.SteelBlue;
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Controls.Add(botonRedondeado1);
            panelRedondeado1.Location = new Point(0, -28);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(385, 90);
            panelRedondeado1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 47);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 9;
            label1.Text = "UBICACIONES HABITUALES";
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(0, 31);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(68, 56);
            botonRedondeado1.TabIndex = 9;
            botonRedondeado1.Text = " ←";
            botonRedondeado1.UseVisualStyleBackColor = true;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre de la Ruta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 170);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 10;
            label3.Text = "Latitud Base:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 11;
            label4.Text = "Longitud Base:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 209);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 12;
            label5.Text = "Radio Tolerancia (Metros):";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.OrangeRed;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(141, 257);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 32);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar ";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 645);
            Controls.Add(btnModificar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelRedondeado1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(nmcRadio);
            Controls.Add(txtLongitud);
            Controls.Add(txtLatitud);
            Controls.Add(txtNombreRuta);
            Name = "FormRutas";
            Text = "FormRutas";
            Load += FormRutas_Load;
            ((System.ComponentModel.ISupportInitialize)nmcRadio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBoxRedondeado txtNombreRuta;
        private TextBoxRedondeado txtLatitud;
        private TextBoxRedondeado txtLongitud;
        private NumericUpDown nmcRadio;
        private BotonRedondeado btnGuardar;
        private BotonRedondeado btnEliminar;
        private DataGridView dataGridView1;
        private PanelRedondeado panelRedondeado1;
        private BotonRedondeado botonRedondeado1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BotonRedondeado btnModificar;
    }
}