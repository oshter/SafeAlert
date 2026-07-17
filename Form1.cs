using Microsoft.Data.SqlClient;

namespace proyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.textBox.Text.Trim();
            string contrasena = txtContrasena.textBox.Text.Trim();



            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, introduce tu correo y contraseña para continuar.",
                                "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contrasenaEncriptada = CalcularSHA256(contrasena);

            string cadenaConexion = @"Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";

            string query = "SELECT ID, Nombre, Correo, Telefono, RutaFoto FROM Usuarios WHERE Correo = @Correo AND Password = @Pass";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Correo ", correo); //
                    comando.Parameters.AddWithValue("@Pass", contrasenaEncriptada);

                    try
                    {
                        conexion.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                UsuarioSesion.Nombre = lector["Nombre"].ToString();
                                UsuarioSesion.Correo = lector["Correo"].ToString();
                                UsuarioSesion.Telefono = lector["Telefono"].ToString();
                                UsuarioSesion.RutaFoto = lector["RutaFoto"].ToString();

                                MessageBox.Show("¡Bienvenido al sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FormDashboard dashboard = new FormDashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Correo o contraseña incorrectos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }







        private void btnOlvidasteContraseña_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Se ha enviado un enlace de recuperación a tu dirección de correo electrónico vinculada.",
                                "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conectando con la API de Google... Por favor, inicia sesión en la ventana emergente de tu navegador.",
                            "Autenticación con Google", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conectando con Facebook Login... Redirigiendo de forma segura.",
                            "Autenticación con Facebook", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try

            {
                if (txtContrasena != null && txtContrasena.textBox != null)
                {
                    txtContrasena.textBox.PasswordChar = '•';
                    this.Size = new System.Drawing.Size(420, 780); // Le damos más ancho y mucha más altura
                    this.StartPosition = FormStartPosition.CenterScreen;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }

            catch { }
        }


        public static string CalcularSHA256(string texto)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(texto));
                System.Text.StringBuilder constructor = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    constructor.Append(bytes[i].ToString("x2"));
                }
                return constructor.ToString();
            }
        }

        private void btnRegistrarte_Click(object sender, EventArgs e)
        {
            FormRegistro ventanaRegistro = new FormRegistro();
            ventanaRegistro.ShowDialog(); // Abre la ventana de registro

        }

        private void txtCorreo_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

}
