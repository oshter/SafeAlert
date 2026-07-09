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
    public partial class FormGestorUsuarios : Form
    {
        public FormGestorUsuarios()
        {
            InitializeComponent();
        }

        private void FormGestorUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        // 1. READ: LISTAR TODOS LOS REGISTRROS EN LA TABLA
        private void ListarUsuarios()
        {
            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT Nombre, Correo, Telefono FROM Usuarios";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsuariosGestor.DataSource = dt;
                    }
                }
                dgvUsuariosGestor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show("Error al listar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // 2. CREATE: BOTÓN REGISTRAR (AZUL)
        private void btnRegistrar_Click(object sender, EventArgs e) // Asegúrate de hacer doble clic al botón azul en el diseño para enlazar este nombre
        {
            if (string.IsNullOrWhiteSpace(txtNombreGestor.textBox.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoGestor.textBox.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoGestor.textBox.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos para poder registrar al ciudadano.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "INSERT INTO Usuarios (Nombre, Correo, Telefono, Password) VALUES (@Nombre, @Correo, @Telefono, @Pass)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", txtNombreGestor.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Correo", txtCorreoGestor.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Telefono", txtTelefonoGestor.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Pass", Form1.CalcularSHA256("12345"));

                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ciudadano registrado exitosamente.", "SafeAlert Gestor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreGestor.textBox.Text = "";
                txtCorreoGestor.textBox.Text = "";
                txtTelefonoGestor.textBox.Text = "";
                ListarUsuarios();
            }
            catch (Exception ex) { MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // 3. EVENTO CELLCLICK: SUBIR DATOS DE LA TABLA A LAS CAJAS
        private void dgvUsuariosGestor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuariosGestor.CurrentRow != null && dgvUsuariosGestor.CurrentRow.Index >= 0)
            {
                txtNombreGestor.textBox.Text = dgvUsuariosGestor.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCorreoGestor.textBox.Text = dgvUsuariosGestor.CurrentRow.Cells["Correo"].Value.ToString();
                txtTelefonoGestor.textBox.Text = dgvUsuariosGestor.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreoGestor.Enabled = false;
            }
        }

        // 4. UPDATE: BOTÓN ACTUALIZAR (VERDE)
        private void btnActualizar_Click(object sender, EventArgs e) // Asegúrate de hacer doble clic al botón verde en el diseño
        {
            if (dgvUsuariosGestor.CurrentRow == null) return;

            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "UPDATE Usuarios SET Nombre = @Nombre, Telefono = @Telefono WHERE Correo = @Correo";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", txtCorreoGestor.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Nombre", txtNombreGestor.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Telefono", txtTelefonoGestor.textBox.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreGestor.textBox.Text = "";
                txtCorreoGestor.textBox.Text = "";
                txtTelefonoGestor.textBox.Text = "";
                txtCorreoGestor.Enabled = true;
                ListarUsuarios();
            }
            catch (Exception ex) { MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // 5. DELETE: BOTÓN DAR DE BAJA (ROJO)
        private void btnEliminar_Click(object sender, EventArgs e) // Asegúrate de hacer doble clic al botón rojo en el diseño
        {
            if (dgvUsuariosGestor.CurrentRow == null) return;
            string correoEliminar = dgvUsuariosGestor.CurrentRow.Cells["Correo"].Value.ToString();

            DialogResult confirmar = MessageBox.Show($"¿Está seguro de eliminar definitivamente al usuario {correoEliminar}?", "Baja Administrativa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.No) return;

            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "DELETE FROM Usuarios WHERE Correo = @Correo";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", correoEliminar);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuario removido con éxito.", "Baja Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreGestor.textBox.Text = "";
                txtCorreoGestor.textBox.Text = "";
                txtTelefonoGestor.textBox.Text = "";
                txtCorreoGestor.Enabled = true;
                ListarUsuarios();
            }
            catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // 6. BUSCAR POR FILTRADO DINÁMICO
        public void BuscarUsuario()
        {
            string cnx = "Data Source=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT Nombre, Correo, Telefono FROM Usuarios WHERE Correo LIKE @Buscar";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Buscar", "%" + txtCorreoGestor.textBox.Text.Trim() + "%");
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsuariosGestor.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
