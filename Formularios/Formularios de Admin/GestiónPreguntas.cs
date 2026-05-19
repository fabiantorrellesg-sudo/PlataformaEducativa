using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PlataformaEducativa.Formularios
{
    public partial class GestiónPreguntas : Form
    {
        private string cadenaConexion = "Server=localhost; Database=peducativa; Uid=root; Pwd=;";

        public GestiónPreguntas()
        {
            InitializeComponent();
        }

        private void GestiónPreguntas_Load(object sender, EventArgs e)
        {
            // arranca sin filtro, carga todo
            CargarPreguntas("Todas");
            listBoxMaterias.SelectedIndex = -1;
        }

        // trae las preguntas de la bd segun la materia seleccionada
        private void CargarPreguntas(string materia)
        {
            try
            {
                string consulta;
                if (materia == "Todas" || string.IsNullOrEmpty(materia))
                    consulta = "SELECT id, enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia FROM pregunta ORDER BY materia";
                else
                    consulta = "SELECT id, enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia FROM pregunta WHERE materia = @materia ORDER BY id";

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    if (materia != "Todas")
                        comando.Parameters.AddWithValue("@materia", materia);

                    conexion.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    dgvGestionDePreguntas.DataSource = tabla;

                    // nombres mas legibles en las columnas
                    dgvGestionDePreguntas.Columns["id"].HeaderText = "ID";
                    dgvGestionDePreguntas.Columns["enunciado"].HeaderText = "Pregunta";
                    dgvGestionDePreguntas.Columns["opcion_a"].HeaderText = "Opción A";
                    dgvGestionDePreguntas.Columns["opcion_b"].HeaderText = "Opción B";
                    dgvGestionDePreguntas.Columns["opcion_c"].HeaderText = "Opción C";
                    dgvGestionDePreguntas.Columns["opcion_d"].HeaderText = "Opción D";
                    dgvGestionDePreguntas.Columns["respuesta_correcta"].HeaderText = "Respuesta";
                    dgvGestionDePreguntas.Columns["materia"].HeaderText = "Materia";
                    dgvGestionDePreguntas.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar preguntas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cuando seleccionan una materia del listbox filtra
        private void listBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string materiaSeleccionada = listBoxMaterias.SelectedItem?.ToString() ?? "Todas";
            CargarPreguntas(materiaSeleccionada);
        }

        // boton editar: abre el editor con la pregunta elegida
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvGestionDePreguntas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una pregunta para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow fila = ((DataRowView)dgvGestionDePreguntas.SelectedRows[0].DataBoundItem).Row;
            int idPregunta = Convert.ToInt32(fila["id"]);

            EditorPreguntas editor = new EditorPreguntas(idPregunta);
            editor.ShowDialog();
            // recarga despues de editar
            CargarPreguntas(listBoxMaterias.SelectedItem?.ToString() ?? "Todas");
        }

        // boton eliminar con confirmacion
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGestionDePreguntas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una pregunta para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow fila = ((DataRowView)dgvGestionDePreguntas.SelectedRows[0].DataBoundItem).Row;
            int idPregunta = Convert.ToInt32(fila["id"]);
            string enunciado = fila["enunciado"].ToString();

            DialogResult confirmacion = MessageBox.Show(
                $"¿Seguro que quieres eliminar esta pregunta?\n\n\"{enunciado}\"",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    using (MySqlCommand comando = new MySqlCommand("DELETE FROM pregunta WHERE id = @id", conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idPregunta);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Pregunta eliminada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPreguntas(listBoxMaterias.SelectedItem?.ToString() ?? "Todas");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // boton nueva pregunta: abre el editor vacio (id = -1 significa nuevo)
        private void btnNuevaPregunta_Click(object sender, EventArgs e)
        {
            EditorPreguntas editor = new EditorPreguntas(-1);
            editor.ShowDialog();
            CargarPreguntas(listBoxMaterias.SelectedItem?.ToString() ?? "Todas");
        }

        // volver al menu del admin
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
