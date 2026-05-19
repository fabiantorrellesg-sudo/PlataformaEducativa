using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PlataformaEducativa.Formularios
{
    public partial class QuizForm : Form
    {
        private string cadena = "Server=localhost; Database=peducativa; Uid=root; Pwd=;";
        private Jugador jugador;
        private List<DataRow> preguntas = new List<DataRow>();
        private int indiceActual = 0;

        public QuizForm(Jugador jugadorActivo)
        {
            InitializeComponent();
            this.jugador = jugadorActivo;
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            CargarPreguntas();
            if (preguntas.Count > 0)
                MostrarPregunta(0);
            else
                MessageBox.Show("No hay preguntas para esta materia todavia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarPreguntas()
        {
            try
            {
                string sql = "SELECT * FROM pregunta WHERE materia = @mat ORDER BY RAND() LIMIT 10";
                using (MySqlConnection con = new MySqlConnection(cadena))
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@mat", jugador.MateriaActual);
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow fila in dt.Rows)
                        preguntas.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando preguntas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarPregunta(int indice)
        {
            if (indice < 0 || indice >= preguntas.Count) return;

            DataRow p = preguntas[indice];
            lblMateria.Text = jugador.MateriaActual;
            lblPreguntaEnunciado.Text = p["enunciado"].ToString();
            rbOpciónA.Text = "A) " + p["opcion_a"].ToString();
            radioButton1.Text = "B) " + p["opcion_b"].ToString();
            radioButton2.Text = "C) " + p["opcion_c"].ToString();
            radioButton3.Text = "D) " + p["opcion_d"].ToString();

            rbOpciónA.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            lblContadorPreguntas.Text = $"Pregunta {indice + 1} de {preguntas.Count}";
            lblPuntaje.Text = "Puntaje: " + jugador.Puntuacion;

            int porcentaje = (int)((indice + 1) * 100.0 / preguntas.Count);
            pBar.Value = Math.Min(porcentaje, 100);
            lblPorcentaje.Text = porcentaje + "%";

            btnAnterior.Enabled = indice > 0;
        }

        private string ObtenerRespuestaSeleccionada()
        {
            if (rbOpciónA.Checked) return "A";
            if (radioButton1.Checked) return "B";
            if (radioButton2.Checked) return "C";
            if (radioButton3.Checked) return "D";
            return "";
        }

        private void EvaluarRespuesta()
        {
            string seleccion = ObtenerRespuestaSeleccionada();
            if (string.IsNullOrEmpty(seleccion)) return;

            string correcta = preguntas[indiceActual]["respuesta_correcta"].ToString().ToUpper();
            if (seleccion == correcta)
                jugador.RegistrarCorrecta();
            else
                jugador.RegistrarIncorrecta();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ObtenerRespuestaSeleccionada() == "")
            {
                MessageBox.Show("Selecciona una opcion antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EvaluarRespuesta();

            if (indiceActual < preguntas.Count - 1)
            {
                indiceActual++;
                MostrarPregunta(indiceActual);
            }
            else
            {
                MostrarResultado();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarPregunta(indiceActual);
            }
        }

        private void MostrarResultado()
        {
            string resumen = jugador.ObtenerResumen();
            DialogResult r = MessageBox.Show(
                $"Quiz terminado!\n\n{resumen}\n\n¿Quieres jugar otra vez?",
                "Resultado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (r == DialogResult.Yes)
            {
                jugador.ReiniciarSesion();
                preguntas.Clear();
                indiceActual = 0;
                CargarPreguntas();
                MostrarPregunta(0);
            }
            else
            {
                this.Close();
            }
        }
    }
}
