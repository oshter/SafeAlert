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
            gestorDToolStripMenuItem = new ToolStripMenuItem();
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
            botonCircular1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botonCircular1.BackColor = Color.Transparent;
            botonCircular1.BackgroundImageLayout = ImageLayout.Stretch;
            botonCircular1.FlatAppearance.BorderSize = 0;
            botonCircular1.FlatStyle = FlatStyle.Flat;
            botonCircular1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonCircular1.ForeColor = Color.Transparent;
            botonCircular1.Image = (Image)resources.GetObject("botonCircular1.Image");
            botonCircular1.Location = new Point(107, 153);
            botonCircular1.Margin = new Padding(4, 5, 4, 5);
            botonCircular1.Name = "botonCircular1";
            botonCircular1.Size = new Size(306, 306);
            botonCircular1.TabIndex = 0;
            botonCircular1.UseVisualStyleBackColor = false;
            botonCircular1.Click += botonCircular1_Click;
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRedondeado1.BackColor = Color.White;
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Location = new Point(92, 537);
            panelRedondeado1.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Size = new Size(321, 57);
            panelRedondeado1.TabIndex = 1;
            panelRedondeado1.Click += panelRedondeado1_Click;
            panelRedondeado1.Paint += panelRedondeado1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(83, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Reportar Incidente";
            // 
            // panelRedondeado2
            // 
            panelRedondeado2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRedondeado2.BackColor = Color.White;
            panelRedondeado2.Controls.Add(label2);
            panelRedondeado2.Location = new Point(92, 655);
            panelRedondeado2.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado2.Name = "panelRedondeado2";
            panelRedondeado2.Size = new Size(321, 57);
            panelRedondeado2.TabIndex = 2;
            panelRedondeado2.Click += panelRedondeado2_Click;
            panelRedondeado2.Paint += panelRedondeado2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(64, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 0;
            label2.Text = "Llamar a Emergencias";
            // 
            // panelRedondeado3
            // 
            panelRedondeado3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRedondeado3.BackColor = Color.White;
            panelRedondeado3.Controls.Add(label3);
            panelRedondeado3.Location = new Point(92, 769);
            panelRedondeado3.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado3.Name = "panelRedondeado3";
            panelRedondeado3.Size = new Size(321, 57);
            panelRedondeado3.TabIndex = 3;
            panelRedondeado3.Click += panelRedondeado3_Click;
            panelRedondeado3.Paint += panelRedondeado3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(110, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 0;
            label3.Text = "Ubicación";
            // 
            // panelRedondeado4
            // 
            panelRedondeado4.BackColor = Color.SteelBlue;
            panelRedondeado4.Controls.Add(label4);
            panelRedondeado4.Controls.Add(btnMenú);
            panelRedondeado4.Location = new Point(-4, -20);
            panelRedondeado4.Margin = new Padding(4, 5, 4, 5);
            panelRedondeado4.Name = "panelRedondeado4";
            panelRedondeado4.Size = new Size(517, 127);
            panelRedondeado4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(71, 49);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(429, 36);
            label4.TabIndex = 0;
            label4.Text = "PANEL DE CONTROL CIUDADANO";
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
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, miPerfilToolStripMenuItem, contactosToolStripMenuItem, ubicacionesHabitualesToolStripMenuItem, configuraciónToolStripMenuItem, historialDeReportesToolStripMenuItem, gestorDToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(267, 260);
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(266, 32);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // miPerfilToolStripMenuItem
            // 
            miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            miPerfilToolStripMenuItem.Size = new Size(266, 32);
            miPerfilToolStripMenuItem.Text = "Mi perfil";
            miPerfilToolStripMenuItem.Click += miPerfilToolStripMenuItem_Click;
            // 
            // contactosToolStripMenuItem
            // 
            contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            contactosToolStripMenuItem.Size = new Size(266, 32);
            contactosToolStripMenuItem.Text = "Contactos";
            contactosToolStripMenuItem.Click += contactosToolStripMenuItem_Click;
            // 
            // ubicacionesHabitualesToolStripMenuItem
            // 
            ubicacionesHabitualesToolStripMenuItem.Name = "ubicacionesHabitualesToolStripMenuItem";
            ubicacionesHabitualesToolStripMenuItem.Size = new Size(266, 32);
            ubicacionesHabitualesToolStripMenuItem.Text = "Ubicaciones Habituales";
            ubicacionesHabitualesToolStripMenuItem.Click += ubicacionesHabitualesToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(266, 32);
            configuraciónToolStripMenuItem.Text = "Configuración";
            configuraciónToolStripMenuItem.Click += configuraciónToolStripMenuItem_Click_1;
            // 
            // historialDeReportesToolStripMenuItem
            // 
            historialDeReportesToolStripMenuItem.Name = "historialDeReportesToolStripMenuItem";
            historialDeReportesToolStripMenuItem.Size = new Size(266, 32);
            historialDeReportesToolStripMenuItem.Text = "Historial De Reportes";
            historialDeReportesToolStripMenuItem.Click += historialDeReportesToolStripMenuItem_Click;
            // 
            // gestorDToolStripMenuItem
            // 
            gestorDToolStripMenuItem.Name = "gestorDToolStripMenuItem";
            gestorDToolStripMenuItem.Size = new Size(266, 32);
            gestorDToolStripMenuItem.Text = "Gestor de Usuarios";
            gestorDToolStripMenuItem.Click += gestorDToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(266, 32);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // FormDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(509, 913);
            Controls.Add(panelRedondeado4);
            Controls.Add(panelRedondeado3);
            Controls.Add(panelRedondeado2);
            Controls.Add(panelRedondeado1);
            Controls.Add(botonCircular1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(531, 969);
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
        private ToolStripMenuItem gestorDToolStripMenuItem;
    }
}