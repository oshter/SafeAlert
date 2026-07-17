using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyect
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";

            string query = "SELECT IdReporte AS [ID], TipoIncidente AS [Incidente], Fecha AS [Fecha y Hora], Descripcion AS [Detalles], Estado AS [Estatus] FROM Reportes WHERE CorreoUsuario = @Correo";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            DataTable tablaDatos = new DataTable();
                            adaptador.Fill(tablaDatos);

                            dgvHistorial.DataSource = tablaDatos;
                        }
                    }
                }

                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de alertas: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}


