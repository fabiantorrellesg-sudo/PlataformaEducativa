using MySql.Data.MySqlClient;
using PlataformaEducativa.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace PlataformaEducativa.Formularios
{
    public partial class GestiónPreguntas : Form
    {
        string cadenaConexion = "Server=localhost; Database=peducativa; Uid = root; Pwd=;";

        public GestiónPreguntas()
        {
            InitializeComponent();
            CargarModulos();
            CargarPreguntas(0);
        }

        public GestiónPreguntas(int idModulo)
        {
            InitializeComponent();
            CargarModulos();
            CargarPreguntas(idModulo);
        }

        private void CargarModulos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT id, nombre_es FROM modulos";
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbFiltro.DataSource = dt;
                    cmbFiltro.DisplayMember = "nombre_es";
                    cmbFiltro.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar módulos: " + ex.Message);
            }
        }

        private void CargarPreguntas(int idModulo)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = @"SELECT id, 
                                pregunta_es AS 'Pregunta (ES)', pregunta_en AS 'Question (EN)', 
                                opcion_a_es AS 'A (ES)', opcion_a_en AS 'A (EN)',
                                opcion_b_es AS 'B (ES)', opcion_b_en AS 'B (EN)',
                                opcion_c_es AS 'C (ES)', opcion_c_en AS 'C (EN)',
                                opcion_d_es AS 'D (ES)', opcion_d_en AS 'D (EN)',
                                letra_correcta AS 'Correcta' 
                                FROM preguntas";

                    if (idModulo != 0)
                    {
                        consulta += " WHERE id_modulo = @id_modulo";
                    }

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        if (idModulo != 0)
                        {
                            comando.Parameters.AddWithValue("@id_modulo", idModulo);
                        }

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvPreguntas.DataSource = null;
                        dgvPreguntas.DataSource = tabla;
                        dgvPreguntas.Columns["id"].Visible = false;
                        dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenuForm volver = new AdminMenuForm();
            volver.Show();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedValue != null && cmbFiltro.SelectedValue is int)
            {
                int idSeleccionado = Convert.ToInt32(cmbFiltro.SelectedValue);
                CargarPreguntas(idSeleccionado);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvPreguntas.SelectedRows.Count > 0)
            {

                int idSeleccionado = Convert.ToInt32(dgvPreguntas.SelectedRows[0].Cells["id"].Value);


                EditorPreguntas editar = new EditorPreguntas(idSeleccionado);
                editar.ShowDialog();

                CargarPreguntas(0);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una pregunta de la tabla para editar.");
            }
        }

        private void btnNuevaPregunta_Click(object sender, EventArgs e)
        {
            this.Close();
            EditorPreguntas agregar = new EditorPreguntas(0);
            agregar.ShowDialog();

            CargarPreguntas(0);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el usuario haya seleccionado una fila válida en la tabla
            if (dgvPreguntas.CurrentRow == null || dgvPreguntas.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, seleccione la pregunta que desea eliminar de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el ID de la pregunta desde la celda seleccionada (ajusta "id" al nombre de tu columna)
            int idSeleccionado = Convert.ToInt32(dgvPreguntas.CurrentRow.Cells["id"].Value);

            // 3. Solicitar confirmación al usuario para evitar borrados accidentales
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la pregunta seleccionada de forma permanente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // 4. Conectarse a MySQL y ejecutar la sentencia DELETE
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string consulta = "DELETE FROM preguntas WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idSeleccionado);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Pregunta eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // 5. Refrescar la tabla pasando el idModulo que requiere tu método.
                                // Obtenemos el ID del módulo actual desde el ComboBox de la pantalla (ajusta "cmbMateria" a tu combo)
                                if (cmbFiltro.SelectedValue != null)
                                {
                                    int idModuloActual = Convert.ToInt32(
                                        cmbFiltro.SelectedValue);
                                    CargarPreguntas(idModuloActual);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar. Es posible que la pregunta ya no exista en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la pregunta: " + ex.Message, "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}