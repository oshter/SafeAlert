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
    public partial class FormRutas : Form
    {
        public FormRutas()
        {
            InitializeComponent();
        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRutas_Load(object sender, EventArgs e)
        {
            CargarRutas();
        }




        private void CargarRutas()
        {
            string cnx = "Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT IdUbicacion AS [ID], NombreRuta AS [Ruta], LatitudBase AS [Latitud], LongitudBase AS [Longitud], RadioTolerancia AS [Tolerancia (m)] FROM UbicacionesHabituales WHERE CorreoUsuario = @Correo";

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
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRuta.textBox.Text) ||
               string.IsNullOrWhiteSpace(txtLatitud.textBox.Text) ||
               string.IsNullOrWhiteSpace(txtLongitud.textBox.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos para poder registrar la ruta.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cnx = "Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string insertQuery = "INSERT INTO UbicacionesHabituales (CorreoUsuario, NombreRuta, LatitudBase, LongitudBase, RadioTolerancia) VALUES (@Correo, @Nombre, @Lat, @Lon, @Radio)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(insertQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", UsuarioSesion.Correo);
                        comando.Parameters.AddWithValue("@Nombre", txtNombreRuta.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Lat", Convert.ToDecimal(txtLatitud.textBox.Text.Trim()));
                        comando.Parameters.AddWithValue("@Lon", Convert.ToDecimal(txtLongitud.textBox.Text.Trim()));
                        comando.Parameters.AddWithValue("@Radio", Convert.ToInt32(nmcRadio.Value));

                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("¡Ruta habitual registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreRuta.textBox.Text = "";
                txtLatitud.textBox.Text = "";
                txtLongitud.textBox.Text = "";
                nmcRadio.Value = 0;
                CargarRutas();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }



        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona primero la ruta que deseas eliminar en la tabla.", "Ninguna Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idRuta = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            string nombreRuta = dataGridView1.CurrentRow.Cells["Ruta"].Value.ToString();

            DialogResult confirmar = MessageBox.Show($"¿Estás seguro de que deseas eliminar la ruta '{nombreRuta}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.No) return;

            string cnx = "Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string deleteQuery = "DELETE FROM UbicacionesHabituales WHERE IdUbicacion = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(deleteQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", idRuta);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ruta eliminada con éxito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRutas();
            }
            catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                txtNombreRuta.textBox.Text = dataGridView1.CurrentRow.Cells["Ruta"].Value.ToString();
                txtLatitud.textBox.Text = dataGridView1.CurrentRow.Cells["Latitud"].Value.ToString();
                txtLongitud.textBox.Text = dataGridView1.CurrentRow.Cells["Longitud"].Value.ToString();
                nmcRadio.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Tolerancia (m)"].Value);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            string idRuta = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            string cnx = "Data Source=AMBAR-LAP;Initial Catalog=SafeAlertDB;Integrated Security=True;TrustServerCertificate=True";
            string updateQuery = "UPDATE UbicacionesHabituales SET NombreRuta = @Nombre, LatitudBase = @Lat, LongitudBase = @Lon, RadioTolerancia = @Radio WHERE IdUbicacion = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnx))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(updateQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", idRuta);
                        comando.Parameters.AddWithValue("@Nombre", txtNombreRuta.textBox.Text.Trim());
                        comando.Parameters.AddWithValue("@Lat", Convert.ToDecimal(txtLatitud.textBox.Text.Trim()));
                        comando.Parameters.AddWithValue("@Lon", Convert.ToDecimal(txtLongitud.textBox.Text.Trim()));
                        comando.Parameters.AddWithValue("@Radio", Convert.ToInt32(nmcRadio.Value));
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("¡Ruta modificada con éxito!", "SafeAlert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRutas(); 
            }
            catch (Exception ex) { MessageBox.Show("Error al modificar: " + ex.Message); }
        }

    }
}



        

