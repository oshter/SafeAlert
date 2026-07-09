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
            // 1. Cadena de conexión oficial a tu base de datos SafeAlertDB
            string cadenaConexion = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";

            // 2. Consulta SQL exacta apuntando a la tabla Reportes que acabas de crear
            string query = "SELECT IdReporte AS [ID], TipoIncidente AS [Incidente], Fecha AS [Fecha y Hora], Descripcion AS [Detalles], Estado AS [Estatus] FROM Reportes WHERE CorreoUsuario = @Correo";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Filtramos utilizando la sesión en memoria RAM del ciudadano activo
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            DataTable tablaDatos = new DataTable();
                            adaptador.Fill(tablaDatos);

                            // Cargamos los renglones directamente en tu control visual
                            dgvHistorial.DataSource = tablaDatos;
                        }
                    }
                }

                // Formato estético: las columnas se estiran automáticamente para llenar toda la pantalla
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de alertas: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}


