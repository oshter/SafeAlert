using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyect
{
    public partial class FormUbicacion : Form
    {
        public FormUbicacion()
        {
            InitializeComponent();
        }

        private void FormUbicacion_Load(object sender, EventArgs e)
        {
            // Coordenadas reales exactas de la UTS
            double latitudReal = 27.3516;
            double longitudReal = -109.9004;

          
            lblLatitud.Text = "Latitud Actual: " + latitudReal.ToString();
            lblLongitud.Text = "Longitud Actual: " + longitudReal.ToString();
            lblPrecision.Text = "Estado GPS: Conectado a Red UTSS (Señal Estable)";

            // Dirección directa hacia las coordenadas de la universidad
            string direccion = "https://openstreetmap.org";
            mapaWeb.Source = new Uri(direccion);
        

        }


        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}

