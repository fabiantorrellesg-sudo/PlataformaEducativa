using System;
using System.Windows.Forms;

namespace PlataformaEducativa
{
    public partial class JugadorMenuForm : Form
    {
        private Jugador JugadorActual;

        public JugadorMenuForm(Jugador JugadorLogueado)
        {
            InitializeComponent();
            this.JugadorActual = JugadorLogueado;
        }

        private void JugadorMenuForm_Load(object sender, EventArgs e)
        {
        }

        private void JugadorMenuForm_Load_1(object sender, EventArgs e)
        {
            labelJugador.Text = JugadorActual.Nombre;
            labelNivel.Text = "Nivel " + JugadorActual.Nivel;
            int progreso = JugadorActual.Puntuacion % 100;
            progressBar1.Value = Math.Min(progreso, 100);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void JugadorMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonComenzarArquitectura_Click(object sender, EventArgs e)
        {
            AbrirQuiz("Arquitectura y estructura del computador");
        }

        private void buttonComenzarAntropologia_Click(object sender, EventArgs e)
        {
            AbrirQuiz("Antropología filosófica");
        }

        private void buttonComenzarDeporte_Click(object sender, EventArgs e)
        {
            AbrirQuiz("Deporte");
        }

        private void buttonComenzarCalculo_Click(object sender, EventArgs e)
        {
            AbrirQuiz("Cálculo");
        }

        private void AbrirQuiz(string materia)
        {
            JugadorActual.MateriaActual = materia;
            JugadorActual.ReiniciarSesion();

            QuizForm quiz = new QuizForm(JugadorActual);
            quiz.ShowDialog();

            // actualizo nivel al volver
            labelNivel.Text = "Nivel " + JugadorActual.Nivel;
            progressBar1.Value = Math.Min(JugadorActual.Puntuacion % 100, 100);
        }

        private void buttonProgresoArquitectura_Click(object sender, EventArgs e)
        {
            MostrarProgreso("Arquitectura y estructura del computador");
        }

        private void buttonProgresoAntropologia_Click(object sender, EventArgs e)
        {
            MostrarProgreso("Antropología filosófica");
        }

        private void buttonProgresoDeporte_Click(object sender, EventArgs e)
        {
            MostrarProgreso("Deporte");
        }

        private void buttonProgresoCalculo_Click(object sender, EventArgs e)
        {
            MostrarProgreso("Cálculo");
        }

        private void MostrarProgreso(string materia)
        {
            MessageBox.Show(
                $"Jugador: {JugadorActual.Nombre}\n" +
                $"Materia: {materia}\n" +
                $"Nivel actual: {JugadorActual.Nivel}\n" +
                $"Puntaje total: {JugadorActual.Puntuacion}",
                "Tu progreso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
