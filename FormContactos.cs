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
    public partial class FormContactos : Form
    {
        public FormContactos()
        {
            InitializeComponent();
        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void FormContactos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarContactos();
            }
            catch { } // Ignora cualquier retraso de inicialización de componentes
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Validar que las cajas no estén vacías
            if (string.IsNullOrWhiteSpace(txtContacto.textBox.Text) || string.IsNullOrWhiteSpace(txtTelefono.textBox.Text))
            {
                MessageBox.Show("Por favor, llena el nombre y el teléfono para poder registrar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string insertQuery = "INSERT INTO ContactosConfianza (CorreoUsuario, NombreContacto, TelefonoContacto) VALUES (@Correo, @Nombre, @Tel)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(insertQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        comando.Parameters.AddWithValue("@Nombre", txtContacto.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Tel", txtTelefono.textBox.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Contacto de confianza añadido con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los cuadros
                txtContacto.textBox.Text = "";
                txtTelefono.textBox.Text = "";

                CargarContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el contacto: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CargarContactos()
        {
            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT NombreContacto AS [Nombre Completo], TelefonoContacto AS [Teléfono Celular] FROM ContactosConfianza WHERE CorreoUsuario = @Correo";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);


                            dgvContactos.DataSource = dt;
                        }
                    }
                }
                dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los contactos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el usuario haya seleccionado una fila en la tabla
            if (dgvContactos.CurrentRow == null || dgvContactos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona primero el contacto que deseas eliminar haciendo clic sobre él en la tabla.",
                    "Ningún Contacto Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Recuperar el nombre y el teléfono de la fila seleccionada para la confirmación
            string nombreEliminar = dgvContactos.CurrentRow.Cells["Nombre Completo"].Value.ToString();
            string telefonoEliminar = dgvContactos.CurrentRow.Cells["Teléfono Celular"].Value.ToString();

            DialogResult confirmar = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {nombreEliminar} de tus contactos de confianza?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.No) return;

            // 3. Ejecutar el DELETE en SQL Server
            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string deleteQuery = "DELETE FROM ContactosConfianza WHERE CorreoUsuario = @Correo AND TelefonoContacto = @Tel";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(deleteQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        comando.Parameters.AddWithValue("@Tel", telefonoEliminar);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Contacto eliminado de tu red de confianza con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refrescamos la tabla automáticamente para que desaparezca visualmente
                            CargarContactos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el contacto: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContactos.CurrentRow != null && dgvContactos.CurrentRow.Index >= 0)
            {
                // Reasigna los valores a tus cajas de texto del diseño
                txtContacto.textBox.Text = dgvContactos.CurrentRow.Cells["Nombre Completo"].Value.ToString();
                txtTelefono.textBox.Text = dgvContactos.CurrentRow.Cells["Teléfono Celular"].Value.ToString();
            }
        }

        private void btnModificarContactos_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null) return;

            // Usamos el teléfono original guardado en la celda como llave primaria para buscarlo en la base de datos
            string telefonoOriginal = dgvContactos.CurrentRow.Cells["Teléfono Celular"].Value.ToString();

            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string updateQuery = "UPDATE ContactosConfianza SET NombreContacto = @Nombre, TelefonoContacto = @NuevoTel WHERE CorreoUsuario = @Correo AND TelefonoContacto = @TelOriginal";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(updateQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        comando.Parameters.AddWithValue("@TelOriginal", telefonoOriginal);
                        comando.Parameters.AddWithValue("@Nombre", txtContacto.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@NuevoTel", txtTelefono.textBox.Text.Trim());
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("¡Contacto actualizado con éxito!", "SafeAlert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarContactos(); // Refresca tu lista
            }
            catch (Exception ex) { MessageBox.Show("Error al actualizar contacto: " + ex.Message); }
        }

        private void botonRedondeado3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


