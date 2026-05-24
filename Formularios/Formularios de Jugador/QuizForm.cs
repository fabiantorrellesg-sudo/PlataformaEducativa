using MySql.Data.MySqlClient;
using PlataformaEducativa.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PlataformaEducativa.Formularios
{
    public partial class QuizForm : Form
    {
        // Variables internas recibidas desde el Menú de Jugador
        private List<Pregunta> _preguntas;
        private int _idModulo;
        private int _idUsuario;

        // Variables de control del juego
        private int _indiceActual = 0;
        private int _puntosAcumulados = 0;
        // Guarda lo que respondió en cada pregunta para deshacer al volver
        private Dictionary<int, string> _respuestasGuardadas = new Dictionary<int, string>();
        public QuizForm(List<Pregunta> preguntasDelModulo, int idMod, int idUsuario)
        {
            InitializeComponent();

            this._preguntas = preguntasDelModulo;
            this._idModulo = idMod;
            this._idUsuario = idUsuario;

            ConfigurarEstilosIniciales();
            MostrarPregunta();
        }

        private void ConfigurarEstilosIniciales()
        {
            rbOpciónA.BackColor = System.Drawing.Color.Transparent;
            rbOpciónB.BackColor = System.Drawing.Color.Transparent;
            rbOpciónC.BackColor = System.Drawing.Color.Transparent;
            rbOpciónD.BackColor = System.Drawing.Color.Transparent;
        }

        private void MostrarPregunta()
        {
            // Verificamos si aún quedan preguntas por responder
            if (_indiceActual < _preguntas.Count)
            {
                Pregunta preguntaActual = _preguntas[_indiceActual];

                // Evaluamos el idioma global del juego
                if (ConfigIdiomas.IdiomaActual == "EN")
                {
                    lblPreguntaActual.Text = "Current Question:";
                    lblPreguntaEnunciado.Text = preguntaActual.PreguntaEn;
                    rbOpciónA.Text = "A) " + preguntaActual.OpcionAEn;
                    rbOpciónB.Text = "B) " + preguntaActual.OpcionBEn;
                    rbOpciónC.Text = "C) " + preguntaActual.OpcionCEn;
                    rbOpciónD.Text = "D) " + preguntaActual.OpcionDEn;
                    btnAnterior.Text = "Former";
                    btnSiguiente.Text = "Next";

                    // Actualiza el contador de progreso (Ej: "Question 1 of 10")
                    lblContadorPreguntas.Text = $"Question {_indiceActual + 1} of {_preguntas.Count}";
                    lblPuntaje.Text = $"Score: {_puntosAcumulados}";
                    lblProgreso.Text = "Progress:";
                }
                else
                {
                    lblPreguntaActual.Text = "Pregunta Actual:";
                    lblPreguntaEnunciado.Text = preguntaActual.PreguntaEs;
                    rbOpciónA.Text = "A) " + preguntaActual.OpcionAEs;
                    rbOpciónB.Text = "B) " + preguntaActual.OpcionBEs;
                    rbOpciónC.Text = "C) " + preguntaActual.OpcionCEs;
                    rbOpciónD.Text = "D) " + preguntaActual.OpcionDEs;
                    btnAnterior.Text = "Anterior";
                    btnSiguiente.Text = "Siguiente";

                    // Actualiza el contador de progreso (Ej: "Pregunta 1 de 10")
                    lblContadorPreguntas.Text = $"Pregunta {_indiceActual + 1} de {_preguntas.Count}";
                    lblPuntaje.Text = $"Puntaje: {_puntosAcumulados}";
                    lblProgreso.Text = "Progress:";
                }


                pBar.Minimum = 0;
                pBar.Maximum = _preguntas.Count;

                pBar.Value = _indiceActual;
                int porcentaje = (int)(((double)_indiceActual / _preguntas.Count) * 100);
                lblPorcentaje.Text = $"{porcentaje}%";

                try
                {
                    pbImagenPregunta.Image = Properties.Resources._default;
                    pbImagenPregunta.Visible = true;

                    string nombreImagen = "img_" + preguntaActual.Id;

                    object objetoRecurso = Properties.Resources.ResourceManager.GetObject(nombreImagen);

                    if (objetoRecurso != null)
                    {
                        pbImagenPregunta.Image = (System.Drawing.Image)objetoRecurso;
                    }
                }
                catch (Exception)
                {
                    pbImagenPregunta.Image = Properties.Resources._default;
                }

                // Desmarcar los botones para la nueva pregunta
                rbOpciónA.Checked = false;
                rbOpciónB.Checked = false;
                rbOpciónC.Checked = false;
                rbOpciónD.Checked = false;


            }
            else
            {
                // Si el índice supera la cantidad de preguntas, el juego termina
                FinalizarCuestionario();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string seleccionUsuario = "";
            if (rbOpciónA.Checked) seleccionUsuario = "A";
            else if (rbOpciónB.Checked) seleccionUsuario = "B";
            else if (rbOpciónC.Checked) seleccionUsuario = "C";
            else if (rbOpciónD.Checked) seleccionUsuario = "D";

            if (string.IsNullOrEmpty(seleccionUsuario))
            {
                string advertencia = ConfigIdiomas.IdiomaActual == "EN"
                    ? "Please select an answer before continuing!"
                    : "¡Por favor, selecciona una respuesta antes de continuar!";
                MessageBox.Show(advertencia, "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pregunta preguntaActual = _preguntas[_indiceActual];

            // Si ya había respondido esta pregunta antes, deshago su puntaje anterior
            if (_respuestasGuardadas.ContainsKey(_indiceActual))
            {
                string respuestaAnterior = _respuestasGuardadas[_indiceActual];
                if (respuestaAnterior.Equals(preguntaActual.LetraCorrecta, StringComparison.OrdinalIgnoreCase))
                    _puntosAcumulados -= 10;
                else
                    _puntosAcumulados += 5;
            }

            // Guardo la respuesta actual
            _respuestasGuardadas[_indiceActual] = seleccionUsuario;

            if (seleccionUsuario.Equals(preguntaActual.LetraCorrecta, StringComparison.OrdinalIgnoreCase))
                _puntosAcumulados += 10;
            else
            {
                _puntosAcumulados -= 5;
                if (_puntosAcumulados < 0) _puntosAcumulados = 0;
            }

            _indiceActual++;
            MostrarPregunta();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_indiceActual > 0)
            {
                _indiceActual--;
                MostrarPregunta();

                // Restauro la selección que tenía el jugador en esta pregunta
                if (_respuestasGuardadas.ContainsKey(_indiceActual))
                {
                    string previa = _respuestasGuardadas[_indiceActual];
                    rbOpciónA.Checked = previa == "A";
                    rbOpciónB.Checked = previa == "B";
                    rbOpciónC.Checked = previa == "C";
                    rbOpciónD.Checked = previa == "D";
                }
            }
        }

        private void FinalizarCuestionario()
        {
            // Guardamos el puntaje obtenido de forma segura en la base de datos
            GuardarHistorialEnBD();

            // Mensaje de éxito final
            if (ConfigIdiomas.IdiomaActual == "EN")
            {
                MessageBox.Show($"Quiz Completed!\nYour Score: {_puntosAcumulados} Pts", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"¡Cuestionario Completado!\nTu Puntuación: {_puntosAcumulados} Ptos", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cerramos este formulario para volver al Menú de Jugador
            this.Close();
        }

        private void GuardarHistorialEnBD()
        {
            if (_puntosAcumulados <= 0) return; // No guardamos si el puntaje es 0 o negativo

            // Insertamos los datos usando la estructura exacta de tu tabla 'historial'
            string queryInsert = "INSERT INTO historial (id_usuario, id_modulo, puntuacion) VALUES (@idUser, @idMod, @puntos)";

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryInsert, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUser", this._idUsuario);
                        cmd.Parameters.AddWithValue("@idMod", this._idModulo);
                        cmd.Parameters.AddWithValue("@puntos", this._puntosAcumulados);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el progreso: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPreguntaEnunciado_Click(object sender, EventArgs e) { }

        private void QuizForm_Load(object sender, EventArgs e) { }
    }
}
