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
    public partial class FormPerfil : Form
    {
        private string cnxPerfil;

        public FormPerfil(string cadena)
        {
            InitializeComponent();
            cnxPerfil = cadena; 
            txtNombreCompleto1.textBox.Text = string.IsNullOrWhiteSpace(UsuarioSesion.Nombre) ? "Registra tu nombre aquí" : UsuarioSesion.Nombre;
            txtCorreo1.textBox.Text = UsuarioSesion.Correo;
            txtTelefono1.textBox.Text = string.IsNullOrWhiteSpace(UsuarioSesion.Telefono) ? "Registra tu teléfono aquí" : UsuarioSesion.Telefono;



        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            pictureBox2.Width = 100;
            pictureBox2.Height = 100;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new System.Drawing.Region(path);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!string.IsNullOrWhiteSpace(UsuarioSesion.RutaFoto) && System.IO.File.Exists(UsuarioSesion.RutaFoto))
            {
                pictureBox2.Image = Image.FromFile(UsuarioSesion.RutaFoto);
            }
            else
            {
                pictureBox2.Image = null;
                pictureBox2.BackColor = Color.LightGray;
            }

        }




        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCompleto1.textBox.Text) || string.IsNullOrEmpty(txtCorreo1.textBox.Text))
            {
                MessageBox.Show("El nombre y el correo son campos obligatorios.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cadenaConexion = cnxPerfil;
            string updateQuery = "UPDATE Usuarios SET Nombre = @Nombre, Telefono = @Telefono WHERE Correo = @CorreoActual";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(updateQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", txtNombreCompleto1.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono1.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@CorreoActual", UsuarioSesion.Correo); 

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            UsuarioSesion.Nombre = txtNombreCompleto1.textBox.Text.Trim();
                            UsuarioSesion.Telefono = txtTelefono1.textBox.Text.Trim();

                            MessageBox.Show("¡Tus datos de perfil han sido actualizados con éxito!", "Perfil Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void botonRedondeado3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtNombreCompleto1_Load(object sender, EventArgs e)
        {

        }

        private void botonRedondeado2_Click(object sender, EventArgs e)
        {
            string passActual = Microsoft.VisualBasic.Interaction.InputBox("Introduce tu contraseña actual:", "Verificación de Seguridad", "");
            if (string.IsNullOrWhiteSpace(passActual)) return;

            string passActualEncriptada = Form1.CalcularSHA256(passActual);

            string queryVerificar = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo AND Password = @Pass";

            using (SqlConnection conexion = new SqlConnection(cnxPerfil))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comandoVerificar = new SqlCommand(queryVerificar, conexion))
                    {
                        comandoVerificar.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        comandoVerificar.Parameters.AddWithValue("@Pass", passActualEncriptada);

                        int existe = (int)comandoVerificar.ExecuteScalar();

                        if (existe == 0)
                        {
                            MessageBox.Show("La contraseña actual introducida es incorrecta.", "Error de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string nuevaPass = Microsoft.VisualBasic.Interaction.InputBox("Introduce tu NUEVA contraseña:", "Nueva Contraseña", "");
                    if (string.IsNullOrWhiteSpace(nuevaPass)) return;

                    string confirmarPass = Microsoft.VisualBasic.Interaction.InputBox("Confirma tu NUEVA contraseña:", "Confirmar Nueva Contraseña", "");
                    if (string.IsNullOrWhiteSpace(confirmarPass)) return;

                    if (nuevaPass != confirmarPass)
                    {
                        MessageBox.Show("Las nuevas contraseñas no coinciden. Inténtalo de nuevo.", "Error de Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string nuevaPassEncriptada = Form1.CalcularSHA256(nuevaPass);

                    string queryUpdate = "UPDATE Usuarios SET Password = @NuevaPass WHERE Correo = @Correo";
                    using (SqlCommand comandoUpdate = new SqlCommand(queryUpdate, conexion))
                    {
                        comandoUpdate.Parameters.AddWithValue("@NuevaPass", nuevaPassEncriptada);
                        comandoUpdate.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);

                        comandoUpdate.ExecuteNonQuery();
                        MessageBox.Show("¡Tu contraseña ha sido actualizada con éxito!", "Seguridad Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la contraseña: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show(
                "¡ADVERTENCIA CRÍTICA!\n\n¿Está completamente seguro de eliminar su cuenta de SafeAlert de forma permanente?\nEsta acción no se puede deshacer y perderá todo su historial de reportes y contactos.",
                "ELIMINAR CUENTA DEFINITIVAMENTE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (confirmar == DialogResult.No) return;

            string perfil = "Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string deleteQuery = "DELETE FROM Usuarios WHERE Correo = @Correo";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnxPerfil))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(deleteQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        comando.ExecuteNonQuery();
                    }
                }

                // 3. Notificar el éxito de la baja
                MessageBox.Show("Tu cuenta ha sido eliminada correctamente del sistema SafeAlert. Gracias por tu tiempo.", "Cuenta Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UsuarioSesion.Correo = "";
                UsuarioSesion.Nombre = "";
                UsuarioSesion.Telefono = "";
                UsuarioSesion.RutaFoto = "";

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar dar de baja la cuenta: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}






