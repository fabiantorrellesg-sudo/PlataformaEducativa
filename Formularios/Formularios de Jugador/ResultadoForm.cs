using System;
using System.Drawing;
using System.Windows.Forms;
using PlataformaEducativa.Clases;

namespace PlataformaEducativa.Formularios
{
    public partial class ResultadoForm : Form
    {
        public ResultadoForm(int puntaje, int totalPreguntas)
        {
            InitializeComponent();
            ConfigurarFormulario(puntaje, totalPreguntas);
        }

        private void ConfigurarFormulario(int puntaje, int totalPreguntas)
        {
            this.Text = ConfigIdiomas.IdiomaActual == "EN" ? "Quiz Result" : "Resultado del Quiz";
            this.Size = new Size(420, 320);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(30, 30, 30); // Fondo oscuro app

            Label lblTitulo = new Label();
            lblTitulo.Text = ConfigIdiomas.IdiomaActual == "EN" ? "🏆 Quiz Completed!" : "🏆 ¡Cuestionario Completado!";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 122, 204); // Azul título
            lblTitulo.AutoSize = false;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Size = new Size(380, 40);
            lblTitulo.Location = new Point(10, 20);
            this.Controls.Add(lblTitulo);

            Panel separador = new Panel();
            separador.BackColor = Color.FromArgb(75, 75, 80);
            separador.Size = new Size(360, 1);
            separador.Location = new Point(20, 70);
            this.Controls.Add(separador);

            Label lblPuntaje = new Label();
            lblPuntaje.Text = (ConfigIdiomas.IdiomaActual == "EN" ? "Total Score: " : "Puntaje Total: ") + puntaje + " pts";
            lblPuntaje.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPuntaje.ForeColor = Color.FromArgb(46, 204, 113); // Verde esmeralda claro
            lblPuntaje.AutoSize = false;
            lblPuntaje.TextAlign = ContentAlignment.MiddleCenter;
            lblPuntaje.Size = new Size(380, 35);
            lblPuntaje.Location = new Point(10, 90);
            this.Controls.Add(lblPuntaje);

            Label lblCorrectas = new Label();
            int correctas = puntaje / 10; 
            int incorrectas = totalPreguntas - correctas;
            if (incorrectas < 0) incorrectas = 0;

            lblCorrectas.Text = ConfigIdiomas.IdiomaActual == "EN" ? 
                $"✅ Correct: {correctas}      ❌ Incorrect: {incorrectas}" : 
                $"✅ Correctas: {correctas}      ❌ Incorrectas: {incorrectas}";
            lblCorrectas.Font = new Font("Segoe UI", 12F);
            lblCorrectas.ForeColor = Color.FromArgb(220, 220, 220); // Gris claro
            lblCorrectas.AutoSize = false;
            lblCorrectas.TextAlign = ContentAlignment.MiddleCenter;
            lblCorrectas.Size = new Size(380, 30);
            lblCorrectas.Location = new Point(10, 145);
            this.Controls.Add(lblCorrectas);

            Button btnCerrar = new Button();
            btnCerrar.Text = ConfigIdiomas.IdiomaActual == "EN" ? "Continue" : "Continuar";
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrar.BackColor = Color.FromArgb(0, 122, 204); // Azul app
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Size = new Size(160, 45);
            btnCerrar.Location = new Point(120, 210);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Click += (s, e) => this.Close();
            this.Controls.Add(btnCerrar);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ResultadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Name = "ResultadoForm";
            this.Text = "Resultado";
            this.ResumeLayout(false);
        }
    }
}
