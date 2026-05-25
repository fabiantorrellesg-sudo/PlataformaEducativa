using MySql.Data.MySqlClient;
using PlataformaEducativa.Clases;
using PlataformaEducativa.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlataformaEducativa
{
    public partial class JugadorMenuForm : Form
    {
        private int idUsuarioLogueado;
        private string nombreUsuario;

        public JugadorMenuForm(int idUsuario, string nombre)
        {
            InitializeComponent();

            this.idUsuarioLogueado = idUsuario;
            this.nombreUsuario = nombre;

            AplicarIdiomaInterfaz();
            CalcularNivelJugador();

            this.Load += (s, e) => AgregarBotonHistorial();
        }

        private void AgregarBotonHistorial()
        {
            string textoHistorial = ConfigIdiomas.IdiomaActual == "EN" ? "My History" : "Mi Historial";

            int altoBoton = 40;
            int anchoPanel = panel1.ClientSize.Width;
            int margen = 10;
            int anchoBoton = (anchoPanel - (margen * 3)) / 2;
            int yBotones = pictureBoxUsuario.Bottom + 15;

            int altoRequerido = yBotones + altoBoton + margen;

            // Asegurar que el panel tenga suficiente altura para mostrar los botones y empujar lo demás
            if (panel1.Height < altoRequerido)
            {
                int deltaY = altoRequerido - panel1.Height;
                panel1.Height = altoRequerido;

                panel2.Top += deltaY;
                panel3.Top += deltaY;
                panel4.Top += deltaY;
                panel5.Top += deltaY;

                this.Height += deltaY;
            }

            // Eliminar anclajes que puedan aplastar los botones al redimensionar
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            Button btnHistorial = new Button();
            btnHistorial.Text = textoHistorial;
            btnHistorial.Size = new Size(anchoBoton, altoBoton);
            btnHistorial.Location = new Point(margen, yBotones);
            btnHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnHistorial.BackColor = btnCerrarSesion.BackColor;
            btnHistorial.ForeColor = Color.White;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += (s, e) =>
            {
                HistorialForm historial = new HistorialForm(idUsuarioLogueado);
                historial.ShowDialog();
            };

            btnCerrarSesion.Size = new Size(anchoBoton, altoBoton);
            btnCerrarSesion.Location = new Point(margen * 2 + anchoBoton, yBotones);

            panel1.Controls.Add(btnHistorial);
            btnHistorial.BringToFront();
            btnCerrarSesion.BringToFront();
        }

        private void CalcularNivelJugador()
        {
            int puntosTotales = 0;
            int nivel = 1;
            int puntosMinimosNivelSiguiente = 50;
            string textoNivel = textoNivel = ConfigIdiomas.IdiomaActual == "EN" ? "Level: " : "Nivel: "; ;

            string consulta = "SELECT SUM(puntuacion) FROM historial WHERE id_usuario = @idUsuario";

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", this.idUsuarioLogueado);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            puntosTotales = Convert.ToInt32(resultado);
                        }
                    }
                }

                if (puntosTotales < 0)
                {
                    puntosTotales = 0;
                }

                if (puntosTotales >= 300)
                {
                    nivel = 5;
                    puntosMinimosNivelSiguiente = 300;
                }
                else if (puntosTotales >= 200) { nivel = 4; puntosMinimosNivelSiguiente = 300; }
                else if (puntosTotales >= 100) { nivel = 3; puntosMinimosNivelSiguiente = 200; }
                else if (puntosTotales >= 50) { nivel = 2; puntosMinimosNivelSiguiente = 100; }
                else { nivel = 1; puntosMinimosNivelSiguiente = 50; }


                labelNivel.Text = textoNivel + nivel;

                progressBar.Minimum = 0;
                progressBar.Maximum = puntosMinimosNivelSiguiente;
                progressBar.Value = Math.Min(puntosTotales, puntosMinimosNivelSiguiente);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el nivel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarIdiomaInterfaz()
        {
            if (ConfigIdiomas.IdiomaActual == "EN")
            {
                this.Text = "Educational Platform - Player Menu";
                labelJugador.Text = "Player: " + nombreUsuario;
                btnCerrarSesion.Text = "Log Out";

                // Títulos de los Modulos
                labelArquitectura.Text = "Computer Architecture";
                labelAntropologia.Text = "Philosophical Anthropology";
                labelCalculo.Text = "Calculus";
                labelDeporte.Text = "Sports";

                // Botones de las tarjetas
                buttonComenzarArquitectura.Text = "Start";
                buttonComenzarAntropologia.Text = "Start";
                buttonComenzarCalculo.Text = "Start";
                buttonComenzarDeporte.Text = "Start";
            }
            else
            {
                this.Text = "Plataforma Educativa - ¡Bienvenido Jugador!";
                labelJugador.Text = "Jugador: " + nombreUsuario;
                btnCerrarSesion.Text = "Cerrar Sesión";

                labelArquitectura.Text = "Arquitectura del Computador";
                labelAntropologia.Text = "Antropología Filosófica";
                labelCalculo.Text = "Calculo";
                labelDeporte.Text = "Deporte";

                buttonComenzarArquitectura.Text = "Comenzar";
                buttonComenzarAntropologia.Text = "Comenzar";
                buttonComenzarCalculo.Text = "Comenzar";
                buttonComenzarDeporte.Text = "Comenzar";
            }
        }

        private List<Pregunta> ObtenerPreguntasDeModulo(int idModulo)
        {
            List<Pregunta> listaPreguntas = new List<Pregunta>();

            // Consulta SQL filtrando por módulo y trayendo 10 preguntas aleatorias
            string query = "SELECT * FROM preguntas WHERE id_modulo = @idMod ORDER BY RAND() LIMIT 10";

            try
            {
                using (MySqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idMod", idModulo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pregunta p = new Pregunta
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    IdModulo = Convert.ToInt32(reader["id_modulo"]),
                                    PreguntaEs = reader["pregunta_es"].ToString()!,
                                    PreguntaEn = reader["pregunta_en"].ToString()!,
                                    OpcionAEs = reader["opcion_a_es"].ToString()!,
                                    OpcionAEn = reader["opcion_a_en"].ToString()!,
                                    OpcionBEs = reader["opcion_b_es"].ToString()!,
                                    OpcionBEn = reader["opcion_b_en"].ToString()!,
                                    OpcionCEs = reader["opcion_c_es"].ToString()!,
                                    OpcionCEn = reader["opcion_c_en"].ToString()!,
                                    OpcionDEs = reader["opcion_d_es"].ToString()!,
                                    OpcionDEn = reader["opcion_d_en"].ToString()!,
                                    LetraCorrecta = reader["letra_correcta"].ToString()!
                                };
                                listaPreguntas.Add(p);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ConfigIdiomas.IdiomaActual == "EN")
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
                else
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message);
                }
            }

            return listaPreguntas;
        }

        private void IniciarCuestionario(int idModulo)
        {
            List<Pregunta> preguntas = ObtenerPreguntasDeModulo(idModulo);

            if (preguntas.Count > 0)
            {
                // Abre el formulario QuizForm pasándole las preguntas y el ID de usuario para guardar el récord al final
                QuizForm ventanaQuiz = new QuizForm(preguntas, idModulo, idUsuarioLogueado);
                ventanaQuiz.ShowDialog();
                CalcularNivelJugador();
            }
            else
            {
                string aviso = ConfigIdiomas.IdiomaActual == "EN"
                    ? "No questions available for this module yet."
                    : "No hay preguntas disponibles para este módulo todavía.";
                MessageBox.Show(aviso, "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm regreso = new LoginForm();
            regreso.Show();
        }

        private int ObtenerIdModuloPorPalabraClave(string palabraClave)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT id FROM modulos WHERE nombre_es LIKE @palabra LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@palabra", "%" + palabraClave + "%");
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null && resultado != DBNull.Value)
                            return Convert.ToInt32(resultado);
                    }
                }
            }
            catch { }
            return -1; // No encontrado
        }

        private void LanzarCuestionarioSeguro(string palabraClave)
        {
            int idModulo = ObtenerIdModuloPorPalabraClave(palabraClave);
            if (idModulo != -1)
                IniciarCuestionario(idModulo);
            else
            {
                string aviso = ConfigIdiomas.IdiomaActual == "EN" ? "Module not found in Database." : "Módulo no encontrado en la Base de Datos.";
                MessageBox.Show(aviso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonComenzarArquitectura_Click_1(object sender, EventArgs e)
        {
            LanzarCuestionarioSeguro("Arquitectura");
        }

        private void buttonComenzarAntropologia_Click_1(object sender, EventArgs e)
        {
            LanzarCuestionarioSeguro("Antropolog");
        }

        private void buttonComenzarCalculo_Click_1(object sender, EventArgs e)
        {
            LanzarCuestionarioSeguro("Cálculo");
        }

        private void buttonComenzarDeporte_Click_1(object sender, EventArgs e)
        {
            LanzarCuestionarioSeguro("Deporte");
        }


    }
}
