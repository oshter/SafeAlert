using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
// <--- CORRECCIÓN DE MOTOR DE BASE DE DATOS

namespace proyect
{
    public partial class FormRegistro : Form
    {
        //private string cadenaConexion = @"DataSource=DESKTOP-N752CIB;Initial Catalog=SafeAlertDB;Integrated Security=True;";

        private string cadenaConexion = @"Server=DESKTOP-N752CIB;Database=SafeAlertDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private string rutaFotoSeleccionada = "";

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNuevoNombre.TextWindow.Trim();
            string correo = txtNuevoCorreo.TextWindow.Trim();
            string telefono = txtNuevoTelefono.TextWindow.Trim();
            string contrasena = txtNuevaContraseña.TextWindow.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, rellene todos los campos para crear su cuenta.",
                                "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string checkQuery = "SELECT COUNT(1) FROM Usuarios WHERE Correo = @Correo";
                    using (SqlCommand checkComando = new SqlCommand(checkQuery, conexion))
                    {
                        checkComando.Parameters.AddWithValue("@Correo", correo);
                        if (Convert.ToInt32(checkComando.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Este correo electrónico ya se encuentra registrado.",
                                            "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string insertQuery = "INSERT INTO Usuarios (Correo, Password, Nombre, Telefono, RutaFoto) VALUES (@Correo, @Password, @Nombre, @Telefono, @RutaFoto)";
                    using (SqlCommand comando = new SqlCommand(insertQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Password", CalcularSHA256(contrasena));
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Telefono", telefono);

                        // Validación para omitir la foto al registrarse
                        if (string.IsNullOrWhiteSpace(rutaFotoSeleccionada))
                        {
                            comando.Parameters.AddWithValue("@RutaFoto", DBNull.Value);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@RutaFoto", rutaFotoSeleccionada);
                        }

                        comando.ExecuteNonQuery();

                        // === GUARDADO EN LA SESIÓN GLOBAL ===
                        UsuarioSesion.Nombre = nombre;
                        UsuarioSesion.Correo = correo;
                        UsuarioSesion.Telefono = telefono;

                        MessageBox.Show("¡Tu cuenta de SafeAlert ha sido creada con éxito!\nYa puedes iniciar sesión.",
                                        "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message,
                                    "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string CalcularSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder constructor = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    constructor.Append(bytes[i].ToString("x2"));
                }
                return constructor.ToString();
            }
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void botonRedondeado2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog buscarFoto = new OpenFileDialog())
            {
                buscarFoto.Filter = "Imágenes (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                buscarFoto.Title = "Selecciona tu foto de perfil para SafeAlert";

                if (buscarFoto.ShowDialog() == DialogResult.OK)
                {
                    // Guarda la ruta de la imagen en la variable que creamos arriba en la línea 16
                    rutaFotoSeleccionada = buscarFoto.FileName;
                    MessageBox.Show("¡Foto seleccionada correctamente! Se guardará al hacer clic en Crear Cuenta.", "Imagen Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
