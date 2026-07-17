namespace proyect
{
    partial class FormUbicacion
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
            lblLatitud = new Label();
            panelRedondeado1 = new PanelRedondeado();
            botonRedondeado1 = new BotonRedondeado();
            label1 = new Label();
            lblLongitud = new Label();
            lblPrecision = new Label();
            mapaWeb = new Microsoft.Web.WebView2.WinForms.WebView2();
            panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mapaWeb).BeginInit();
            SuspendLayout();
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Font = new Font("Segoe UI", 11.25F);
            lblLatitud.Location = new Point(17, 110);
            lblLatitud.Margin = new Padding(4, 0, 4, 0);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(259, 31);
            lblLatitud.TabIndex = 0;
            lblLatitud.Text = "Latitud: Cargando GPS...";
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.SteelBlue;
            panelRedondeado1.Controls.Add(botonRedondeado1);
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Location = new Point(0, -28);
            panelRedondeado1.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(531, 133);
            panelRedondeado1.TabIndex = 1;
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
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 40);
            label1.TabIndex = 3;
            label1.Text = "UBICACIÓN";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Font = new Font("Segoe UI", 11.25F);
            lblLongitud.Location = new Point(17, 143);
            lblLongitud.Margin = new Padding(4, 0, 4, 0);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(279, 31);
            lblLongitud.TabIndex = 2;
            lblLongitud.Text = "Longitud: Cargando GPS...";
            // 
            // lblPrecision
            // 
            lblPrecision.AutoSize = true;
            lblPrecision.Font = new Font("Segoe UI", 11.25F);
            lblPrecision.Location = new Point(17, 177);
            lblPrecision.Margin = new Padding(4, 0, 4, 0);
            lblPrecision.Name = "lblPrecision";
            lblPrecision.Size = new Size(355, 31);
            lblPrecision.TabIndex = 4;
            lblPrecision.Text = "Estado: Conectando con satélite...";
            // 
            // mapaWeb
            // 
            mapaWeb.AllowExternalDrop = true;
            mapaWeb.CreationProperties = null;
            mapaWeb.DefaultBackgroundColor = Color.White;
            mapaWeb.Location = new Point(17, 215);
            mapaWeb.Margin = new Padding(4, 5, 4, 5);
            mapaWeb.Name = "mapaWeb";
            mapaWeb.Size = new Size(487, 801);
            mapaWeb.TabIndex = 5;
            mapaWeb.ZoomFactor = 1D;
            // 
            // FormUbicacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 1050);
            Controls.Add(mapaWeb);
            Controls.Add(lblPrecision);
            Controls.Add(lblLongitud);
            Controls.Add(panelRedondeado1);
            Controls.Add(lblLatitud);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormUbicacion";
            Text = "FormUbicacion";
            Load += FormUbicacion_Load;
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mapaWeb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLatitud;
        private PanelRedondeado panelRedondeado1;
        private Label label1;
        private BotonRedondeado botonRedondeado1;
        private Label lblLongitud;
        private Label lblPrecision;
        private Microsoft.Web.WebView2.WinForms.WebView2 mapaWeb;
    }
}