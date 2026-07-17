using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyect
{
    public partial class FormDashboard : Form
    {
        private int intensidadRojo = 255;
        private bool disminuyendo = true;

        private string cadenaConexion = @"Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True;";

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
          


          
        }




        private void panelRedondeado1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (botonCircular1 != null)
            {
                if (disminuyendo)
                {
                    intensidadRojo -= 8;
                    if (intensidadRojo <= 130) disminuyendo = false;
                }
                else
                {
                    intensidadRojo += 8;
                    if (intensidadRojo >= 255) disminuyendo = true;
                }

                botonCircular1.BackColor = Color.FromArgb(intensidadRojo, 0, 0);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {

           
            Control botonAsociado = (Control)sender;
            contextMenuStrip1.Show(botonAsociado, new Point(0, botonAsociado.Height));
        }






        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerfil perfil = new FormPerfil(cadenaConexion);

            perfil.ShowDialog(); 

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)

        {
            Form1 login = new Form1();
            login.Show();

            login.Show();
            this.Close(); 
        }



        private void historialDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorial historial = new FormHistorial();
            historial.ShowDialog();

        }



        private void configuraciónToolStripMenuItem_Click_1(object sender, EventArgs e)

        {
            MessageBox.Show("Sección en mantenimiento. Próximamente podrás cambiar el idioma y activar notificaciones.",
                            "Configuración",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }



        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                FormPerfil perfil = new FormPerfil(cadenaConexion);

               
                perfil.ShowDialog();
            }

        }



        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void botonCircular1_Click(object sender, EventArgs e)
        {

           
            System.Media.SystemSounds.Asterisk.Play();

           
            MessageBox.Show("¡ALERTA ENVIADA CON ÉXITO!\n\n" +
                            "Se ha enviado tu señal de auxilio a la central de policía.\n" +
                            "Enviando coordenadas de GPS actuales...",
                            "SISTEMA DE EMERGENCIA CITIZEN",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            string cadenaConexion = "Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string insertQuery = "INSERT INTO Reportes (CorreoUsuario, TipoIncidente, Descripcion, Estado) VALUES (@Correo, @Tipo, @Descripcion, @Estado)";
            string detallesEmergencia = "¡BOTÓN DE PÁNICO ACTIVADO! Ubicación simulada: Universidad Tecnológica del Sur de Sonora (UTSS). Coordenadas GPS fijas: Latitud 27.3516, Longitud -109.9004.";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();


                    using (SqlCommand comando = new SqlCommand(insertQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        comando.Parameters.AddWithValue("@Tipo", "ALERTA S.O.S.");
                        comando.Parameters.AddWithValue("@Descripcion", detallesEmergencia);
                        comando.Parameters.AddWithValue("@Estado", "Pendiente");
                        comando.ExecuteNonQuery();
                    }


                    string queryContactos = "SELECT NombreContacto, TelefonoContacto FROM ContactosConfianza WHERE CorreoUsuario = @Correo";
                    List<string> listaContactosNotificados = new List<string>();

                    using (SqlCommand comandoContactos = new SqlCommand(queryContactos, conexion))
                    {
                        comandoContactos.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        using (SqlDataReader lector = comandoContactos.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string nombreC = lector["NombreContacto"].ToString();
                                string telC = lector["TelefonoContacto"].ToString();

                                listaContactosNotificados.Add($"- {nombreC} ({telC})");
                            }
                        }
                    }


                    if (listaContactosNotificados.Count > 0)
                    {
                        string listaTexto = string.Join("\n", listaContactosNotificados);
                        MessageBox.Show($"¡S.O.S. COMPARTIDO CON TU RED DE APOYO!\n\nSe han enviado tus coordenadas GPS fijas (Lat: 27.3516, Lon: -109.9004) de la UTSS de forma automática a tus contactos de confianza:\n\n{listaTexto}",
                            "NOTIFICACIÓN DE EMERGENCIA ENVIADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de red al despachar en base de datos: " + ex.Message, "Error de Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
            botonCircular1.Text = "ENVIANDO AUXILIO...";
            botonCircular1.BackColor = Color.DarkRed;


            timer1.Start();
        }

        private void panelRedondeado1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelRedondeado1_Click(object sender, EventArgs e)
        {
            FormReportar ventanaReporte = new FormReportar();
            ventanaReporte.Show();
            this.Hide();

        }

        private void panelRedondeado2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRedondeado2_Click(object sender, EventArgs e)
        {
            FormLlamar ventanaLlamar = new FormLlamar();
            ventanaLlamar.Show();
            this.Hide();
        }

        private void panelRedondeado3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelRedondeado3_Click(object sender, EventArgs e)
        {
            FormUbicacion ventanaUbicacion = new FormUbicacion();
            ventanaUbicacion.Show();
            this.Hide();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContactos ventanaContactos = new FormContactos();
            ventanaContactos.ShowDialog();

        }

        private void ubicacionesHabitualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRutas ventanaRutas = new FormRutas();
            ventanaRutas.ShowDialog();

        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {

        }

        private void gestorDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestorUsuarios ventanaGestor = new FormGestorUsuarios();
            ventanaGestor.ShowDialog(); // Abre el panel de control administrativo encima sin ocultar el Dashboard

        }
    }
}

