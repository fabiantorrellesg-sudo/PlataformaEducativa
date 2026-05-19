using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PlataformaEducativa.Formularios
{
    public partial class EditorPreguntas : Form
    {
        private string cadenaConexion = "Server=localhost; Database=peducativa; Uid=root; Pwd=;";
        private int idPregunta; // -1 si es nueva, numero real si se edita

        public EditorPreguntas(int id)
        {
            InitializeComponent();
            this.idPregunta = id;
        }

        private void EditorPreguntas_Load(object sender, EventArgs e)
        {
            if (idPregunta == -1)
            {
                lblTitulo.Text = "Nueva pregunta";
                this.Text = "Nueva pregunta";
            }
            else
            {
                lblTitulo.Text = "Editar pregunta";
                this.Text = "Editar pregunta";
                CargarDatosPregunta();
            }
        }

        private void CargarDatosPregunta()
        {
            try
            {
                string consulta = "SELECT enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia FROM pregunta WHERE id = @id";

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idPregunta);
                    conexion.Open();

                    MySqlDataReader lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        txtEnunciado.Text = lector["enunciado"].ToString();
                        txtOpcionA.Text = lector["opcion_a"].ToString();
                        txtOpcionB.Text = lector["opcion_b"].ToString();
                        txtOpcionC.Text = lector["opcion_c"].ToString();
                        txtOpcionD.Text = lector["opcion_d"].ToString();
                        cmbRespuesta.SelectedItem = lector["respuesta_correcta"].ToString().ToUpper();
                        cmbMateria.SelectedItem = lector["materia"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la pregunta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEnunciado.Text) ||
                string.IsNullOrWhiteSpace(txtOpcionA.Text) ||
                string.IsNullOrWhiteSpace(txtOpcionB.Text) ||
                string.IsNullOrWhiteSpace(txtOpcionC.Text) ||
                string.IsNullOrWhiteSpace(txtOpcionD.Text))
            {
                MessageBox.Show("Hay campos vacios, rellena todo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRespuesta.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona la respuesta correcta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona la materia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string consulta;

                if (idPregunta == -1)
                    consulta = "INSERT INTO pregunta (enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia) VALUES (@enunciado, @a, @b, @c, @d, @respuesta, @materia)";
                else
                    consulta = "UPDATE pregunta SET enunciado=@enunciado, opcion_a=@a, opcion_b=@b, opcion_c=@c, opcion_d=@d, respuesta_correcta=@respuesta, materia=@materia WHERE id=@id";

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@enunciado", txtEnunciado.Text.Trim());
                    comando.Parameters.AddWithValue("@a", txtOpcionA.Text.Trim());
                    comando.Parameters.AddWithValue("@b", txtOpcionB.Text.Trim());
                    comando.Parameters.AddWithValue("@c", txtOpcionC.Text.Trim());
                    comando.Parameters.AddWithValue("@d", txtOpcionD.Text.Trim());
                    comando.Parameters.AddWithValue("@respuesta", cmbRespuesta.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@materia", cmbMateria.SelectedItem.ToString());

                    if (idPregunta != -1)
                        comando.Parameters.AddWithValue("@id", idPregunta);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Pregunta guardada con exito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
