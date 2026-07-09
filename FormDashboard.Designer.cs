namespace proyect
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            botonCircular1 = new BotonCircular();
            panelRedondeado1 = new PanelRedondeado();
            label1 = new Label();
            panelRedondeado2 = new PanelRedondeado();
            label2 = new Label();
            panelRedondeado3 = new PanelRedondeado();
            label3 = new Label();
            panelRedondeado4 = new PanelRedondeado();
            label4 = new Label();
            btnMenú = new BotonRedondeado();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            inicioToolStripMenuItem = new ToolStripMenuItem();
            miPerfilToolStripMenuItem = new ToolStripMenuItem();
            contactosToolStripMenuItem = new ToolStripMenuItem();
            ubicacionesHabitualesToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            historialDeReportesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            panelRedondeado1.SuspendLayout();
            panelRedondeado2.SuspendLayout();
            panelRedondeado3.SuspendLayout();
            panelRedondeado4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // botonCircular1
            // 
            botonCircular1.BackColor = Color.Red;
            botonCircular1.FlatAppearance.BorderSize = 0;
            botonCircular1.FlatStyle = FlatStyle.Flat;
            botonCircular1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonCircular1.ForeColor = Color.White;
            botonCircular1.Image = (Image)resources.GetObject("botonCircular1.Image");
            botonCircular1.Location = new Point(70, 87);
            botonCircular1.Name = "botonCircular1";
            botonCircular1.Size = new Size(225, 227);
            botonCircular1.TabIndex = 0;
            botonCircular1.UseVisualStyleBackColor = false;
            botonCircular1.Click += botonCircular1_Click;
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.White;
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Location = new Point(70, 346);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(225, 34);
            panelRedondeado1.TabIndex = 1;
            panelRedondeado1.Click += panelRedondeado1_Click;
            panelRedondeado1.Paint += panelRedondeado1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Reportar Incidente";
            // 
            // panelRedondeado2
            // 
            panelRedondeado2.BackColor = Color.White;
            panelRedondeado2.Controls.Add(label2);
            panelRedondeado2.Location = new Point(70, 417);
            panelRedondeado2.Name = "panelRedondeado2";
            panelRedondeado2.Size = new Size(225, 34);
            panelRedondeado2.TabIndex = 2;
            panelRedondeado2.Click += panelRedondeado2_Click;
            panelRedondeado2.Paint += panelRedondeado2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(45, 10);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "Llamar a Emergencias";
            // 
            // panelRedondeado3
            // 
            panelRedondeado3.BackColor = Color.White;
            panelRedondeado3.Controls.Add(label3);
            panelRedondeado3.Location = new Point(70, 496);
            panelRedondeado3.Name = "panelRedondeado3";
            panelRedondeado3.Size = new Size(225, 34);
            panelRedondeado3.TabIndex = 3;
            panelRedondeado3.Click += panelRedondeado3_Click;
            panelRedondeado3.Paint += panelRedondeado3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(77, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Ubicación";
            // 
            // panelRedondeado4
            // 
            panelRedondeado4.BackColor = Color.SteelBlue;
            panelRedondeado4.Controls.Add(label4);
            panelRedondeado4.Controls.Add(btnMenú);
            panelRedondeado4.Location = new Point(-3, -12);
            panelRedondeado4.Name = "panelRedondeado4";
            panelRedondeado4.Size = new Size(362, 76);
            panelRedondeado4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 27);
            label4.Name = "label4";
            label4.Size = new Size(313, 25);
            label4.TabIndex = 0;
            label4.Text = "PANEL DE CONTROL CIUDADANO";
            // 
            // btnMenú
            // 
            btnMenú.FlatAppearance.BorderSize = 0;
            btnMenú.FlatStyle = FlatStyle.Flat;
            btnMenú.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenú.ForeColor = Color.White;
            btnMenú.Location = new Point(3, 14);
            btnMenú.Name = "btnMenú";
            btnMenú.Size = new Size(72, 49);
            btnMenú.TabIndex = 5;
            btnMenú.Text = "≡";
            btnMenú.UseVisualStyleBackColor = true;
            btnMenú.Click += botonRedondeado1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, miPerfilToolStripMenuItem, contactosToolStripMenuItem, ubicacionesHabitualesToolStripMenuItem, configuraciónToolStripMenuItem, historialDeReportesToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(198, 158);
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(197, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // miPerfilToolStripMenuItem
            // 
            miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            miPerfilToolStripMenuItem.Size = new Size(197, 22);
            miPerfilToolStripMenuItem.Text = "Mi perfil";
            miPerfilToolStripMenuItem.Click += miPerfilToolStripMenuItem_Click;
            // 
            // contactosToolStripMenuItem
            // 
            contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            contactosToolStripMenuItem.Size = new Size(197, 22);
            contactosToolStripMenuItem.Text = "Contactos";
            contactosToolStripMenuItem.Click += contactosToolStripMenuItem_Click;
            // 
            // ubicacionesHabitualesToolStripMenuItem
            // 
            ubicacionesHabitualesToolStripMenuItem.Name = "ubicacionesHabitualesToolStripMenuItem";
            ubicacionesHabitualesToolStripMenuItem.Size = new Size(197, 22);
            ubicacionesHabitualesToolStripMenuItem.Text = "Ubicaciones Habituales";
            ubicacionesHabitualesToolStripMenuItem.Click += ubicacionesHabitualesToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(197, 22);
            configuraciónToolStripMenuItem.Text = "Configuración";
            configuraciónToolStripMenuItem.Click += configuraciónToolStripMenuItem_Click_1;
            // 
            // historialDeReportesToolStripMenuItem
            // 
            historialDeReportesToolStripMenuItem.Name = "historialDeReportesToolStripMenuItem";
            historialDeReportesToolStripMenuItem.Size = new Size(197, 22);
            historialDeReportesToolStripMenuItem.Text = "Historial De Reportes";
            historialDeReportesToolStripMenuItem.Click += historialDeReportesToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(197, 22);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(356, 600);
            Controls.Add(panelRedondeado4);
            Controls.Add(panelRedondeado3);
            Controls.Add(panelRedondeado2);
            Controls.Add(panelRedondeado1);
            Controls.Add(botonCircular1);
            Name = "FormDashboard";
            Text = "FormDashboard";
            FormClosed += FormDashboard_FormClosed;
            Load += FormDashboard_Load;
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            panelRedondeado2.ResumeLayout(false);
            panelRedondeado2.PerformLayout();
            panelRedondeado3.ResumeLayout(false);
            panelRedondeado3.PerformLayout();
            panelRedondeado4.ResumeLayout(false);
            panelRedondeado4.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private BotonCircular botonCircular1;
        private PanelRedondeado panelRedondeado1;
        private Label label1;
        private PanelRedondeado panelRedondeado2;
        private Label label2;
        private PanelRedondeado panelRedondeado3;
        private Label label3;
        private PanelRedondeado panelRedondeado4;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private BotonRedondeado btnMenú;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem miPerfilToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem historialDeReportesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem contactosToolStripMenuItem;
        private ToolStripMenuItem ubicacionesHabitualesToolStripMenuItem;
    }
}