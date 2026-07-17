namespace proyect
{
    partial class FormHistorial
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
            label1 = new Label();
            dgvHistorial = new DataGridView();
            panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.SteelBlue;
            panelRedondeado1.Controls.Add(botonRedondeado1);
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Location = new Point(0, -30);
            panelRedondeado1.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(531, 133);
            panelRedondeado1.TabIndex = 2;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(0, 28);
            botonRedondeado1.Margin = new Padding(4, 5, 4, 5);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(97, 93);
            botonRedondeado1.TabIndex = 2;
            botonRedondeado1.Text = " ←";
            botonRedondeado1.UseVisualStyleBackColor = true;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 36);
            label1.TabIndex = 3;
            label1.Text = "HISTORIAL DE REPORTES";
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(17, 113);
            dgvHistorial.Margin = new Padding(4, 5, 4, 5);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.Size = new Size(493, 922);
            dgvHistorial.TabIndex = 3;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 1050);
            Controls.Add(dgvHistorial);
            Controls.Add(panelRedondeado1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHistorial";
            Text = "FormHistorial";
            Load += FormHistorial_Load;
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelRedondeado panelRedondeado1;
        private BotonRedondeado botonRedondeado1;
        private Label label1;
        private DataGridView dgvHistorial;
    }
}