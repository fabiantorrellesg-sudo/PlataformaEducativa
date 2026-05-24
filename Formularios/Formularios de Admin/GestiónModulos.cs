using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlataformaEducativa.Formularios
{
    public partial class GestiónModulos : Form
    {
        string cadenaConexion = "Server=localhost; Database=peducativa; Uid = root; Pwd=;";
        public GestiónModulos()
        {
            InitializeComponent();
            CargarModulos();
        }

        public void CargarModulos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string Consulta = "SELECT id,nombre_es,name_en FROM modulos";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(Consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvDatosGestionModulos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenuForm regreso = new AdminMenuForm();
            regreso.Show();
        }

        private void btnCargarEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatosGestionModulos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un módulo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtNombreES.Text = dgvDatosGestionModulos.CurrentRow.Cells["nombre_es"].Value.ToString();
            txtNombreEN.Text = dgvDatosGestionModulos.CurrentRow.Cells["name_en"].Value.ToString();
        }

        // Confirmar edición de módulo
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDatosGestionModulos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un módulo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSeleccionado = Convert.ToInt32(dgvDatosGestionModulos.CurrentRow.Cells["id"].Value);
            string moduloSeleccionado = dgvDatosGestionModulos.CurrentRow.Cells["nombre_es"].Value.ToString();
            string moduloSeleccionado_EN = dgvDatosGestionModulos.CurrentRow.Cells["name_en"].Value.ToString();

            DialogResult advertencia = MessageBox.Show(
                $"¿Está seguro de editar los datos del módulo '{moduloSeleccionado}' / '{moduloSeleccionado_EN}'?",
                "Advertencia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (advertencia == DialogResult.Yes)
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consultaVerificar = "SELECT COUNT(*) FROM modulos WHERE (nombre_es = @nombre_es OR name_en = @name_en) AND id != @id";
                    int conteo = 0;

                    using (MySqlCommand verificar = new MySqlCommand(consultaVerificar, conexion))
                    {
                        verificar.Parameters.AddWithValue("@nombre_es", txtNombreES.Text.Trim());
                        verificar.Parameters.AddWithValue("@name_en", txtNombreEN.Text.Trim());
                        verificar.Parameters.AddWithValue("@id", idSeleccionado);
                        conteo = Convert.ToInt32(verificar.ExecuteScalar());
                    }

                    if (conteo > 0)
                    {
                        MessageBox.Show("No puedes usar ese nombre porque ya le pertenece a otro módulo.", "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string consultaUpdate = "UPDATE modulos SET nombre_es = @nombre_es, name_en = @name_en WHERE id = @id";
                    using (MySqlCommand Update = new MySqlCommand(consultaUpdate, conexion))
                    {
                        Update.Parameters.AddWithValue("@nombre_es", txtNombreES.Text.Trim());
                        Update.Parameters.AddWithValue("@name_en", txtNombreEN.Text.Trim());
                        Update.Parameters.AddWithValue("@id", idSeleccionado);
                        Update.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Módulo editado exitosamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreES.Clear();
                txtNombreEN.Clear();
                CargarModulos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatosGestionModulos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un módulo de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string consulta = "DELETE FROM modulos WHERE id = @id";
            int idModulo = Convert.ToInt32(dgvDatosGestionModulos.CurrentRow.Cells["id"].Value);
            string nombreES = dgvDatosGestionModulos.CurrentRow.Cells["nombre_es"].Value.ToString();
            string nameEN = dgvDatosGestionModulos.CurrentRow.Cells["name_en"].Value.ToString();

            DialogResult advertencia = MessageBox.Show(
                $"¿Está seguro de eliminar el módulo '{nombreES}' / '{nameEN}'?\n\n¡Se eliminará de forma permanente!",
                "Confirmar / Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (advertencia == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    using (MySqlCommand orden = new MySqlCommand(consulta, conexion))
                    {
                        orden.Parameters.AddWithValue("@id", idModulo);
                        conexion.Open();
                        orden.ExecuteNonQuery();
                    }

                    MessageBox.Show("Módulo eliminado exitosamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreES.Clear();
                    txtNombreEN.Clear();
                    CargarModulos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
