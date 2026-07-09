using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyect
{
    public partial class FormReportar : Form
    {
        public FormReportar()
        {
            InitializeComponent();
        }

        private void botonRedondeado2_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            buscador.Title = "Seleccionar evidencia del incidente";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                // Carga la foto en el PictureBox grande que pusiste al centro
                picPreview.Image = Image.FromFile(buscador.FileName);
            }
        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Close();
        }

        private void botonRedondeado3_Click(object sender, EventArgs e)
        {
            // 1. Mostrar un aviso de éxito profesional al ciudadano
            MessageBox.Show("¡Tu reporte ha sido enviado con éxito a la central!\n\n" +
                            "Las autoridades revisarán la descripción y la evidencia fotográfica adjunta.",
                            "REPORTE CIUDADANO RECIBIDO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // 2. Regresar al Dashboard principal de forma limpia
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Close(); // Cierra esta ventana de reporte por completo

        }
    }
}
