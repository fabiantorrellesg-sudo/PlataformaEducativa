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
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(45, 47, 51);

            Label lblTitulo = new Label();
            lblTitulo.Text = ConfigIdiomas.IdiomaActual == "EN" ? "Quiz Completed!" : "¡Cuestionario Completado!";
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(50, 30);
            this.Controls.Add(lblTitulo);

            Label lblPuntaje = new Label();
            lblPuntaje.Text = (ConfigIdiomas.IdiomaActual == "EN" ? "Total Score: " : "Puntaje Total: ") + puntaje + " pts";
            lblPuntaje.Font = new Font("Segoe UI", 14F);
            lblPuntaje.ForeColor = Color.LightGreen;
            lblPuntaje.AutoSize = true;
            lblPuntaje.Location = new Point(50, 90);
            this.Controls.Add(lblPuntaje);

            Label lblCorrectas = new Label();
            int correctas = puntaje / 10; 
            int incorrectas = totalPreguntas - correctas;
            if (incorrectas < 0) incorrectas = 0;

            lblCorrectas.Text = ConfigIdiomas.IdiomaActual == "EN" ? 
                $"Correct: {correctas}\nIncorrect: {incorrectas}" : 
                $"Correctas: {correctas}\nIncorrectas: {incorrectas}";
            lblCorrectas.Font = new Font("Segoe UI", 12F);
            lblCorrectas.ForeColor = Color.White;
            lblCorrectas.AutoSize = true;
            lblCorrectas.Location = new Point(50, 140);
            this.Controls.Add(lblCorrectas);

            Button btnCerrar = new Button();
            btnCerrar.Text = ConfigIdiomas.IdiomaActual == "EN" ? "Continue" : "Continuar";
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrar.BackColor = Color.FromArgb(0, 150, 136);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Size = new Size(150, 40);
            btnCerrar.Location = new Point(120, 200);
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
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Name = "ResultadoForm";
            this.Text = "Resultado";
            this.ResumeLayout(false);
        }
    }
}
