using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyect
{
    public partial class FormLlamar : Form
    {
        public FormLlamar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPolicia_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play(); // Simula el sonido de marcado
            MessageBox.Show("Marcando a servicios de emergencia (Policía Local)...\nConectando con el operador más cercano.",
                            "Llamada en Progreso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btnBomberos_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show("Marcando a la central de Bomberos de la ciudad...\nEstableciendo enlace de audio.",
                            "Llamada en Progreso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void botonRedondeado2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show("Marcando a la Cruz Roja...\nSolicitando asignación de unidad de ambulancia.",
                            "Llamada en Progreso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Close();
        }

        private void FormLlamar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

