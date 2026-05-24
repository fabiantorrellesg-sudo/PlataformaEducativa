namespace PlataformaEducativa.Formularios
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            lblPreguntaEnunciado = new Label();
            lblPreguntaActual = new Label();
            lblContadorPreguntas = new Label();
            lblPuntaje = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            pbImagenPregunta = new PictureBox();
            pictureBoxMichiLogin = new PictureBox();
            rbOpciónB = new RadioButton();
            rbOpciónC = new RadioButton();
            rbOpciónD = new RadioButton();
            lblPorcentaje = new Label();
            pBar = new ProgressBar();
            lblProgreso = new Label();
            lblQuiz = new Label();
            rbOpciónA = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pbImagenPregunta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).BeginInit();
            SuspendLayout();
            // 
            // lblPreguntaEnunciado
            // 
            resources.ApplyResources(lblPreguntaEnunciado, "lblPreguntaEnunciado");
            lblPreguntaEnunciado.BackColor = Color.Transparent;
            lblPreguntaEnunciado.ForeColor = Color.White;
            lblPreguntaEnunciado.Name = "lblPreguntaEnunciado";
            lblPreguntaEnunciado.Click += lblPreguntaEnunciado_Click;
            // 
            // lblPreguntaActual
            // 
            resources.ApplyResources(lblPreguntaActual, "lblPreguntaActual");
            lblPreguntaActual.BackColor = Color.Transparent;
            lblPreguntaActual.ForeColor = Color.White;
            lblPreguntaActual.Name = "lblPreguntaActual";
            // 
            // lblContadorPreguntas
            // 
            resources.ApplyResources(lblContadorPreguntas, "lblContadorPreguntas");
            lblContadorPreguntas.BackColor = Color.Transparent;
            lblContadorPreguntas.ForeColor = Color.White;
            lblContadorPreguntas.Name = "lblContadorPreguntas";
            // 
            // lblPuntaje
            // 
            resources.ApplyResources(lblPuntaje, "lblPuntaje");
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.ForeColor = Color.White;
            lblPuntaje.Name = "lblPuntaje";
            // 
            // btnAnterior
            // 
            resources.ApplyResources(btnAnterior, "btnAnterior");
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Name = "btnAnterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            resources.ApplyResources(btnSiguiente, "btnSiguiente");
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // pbImagenPregunta
            // 
            pbImagenPregunta.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(pbImagenPregunta, "pbImagenPregunta");
            pbImagenPregunta.Name = "pbImagenPregunta";
            pbImagenPregunta.TabStop = false;
            // 
            // pictureBoxMichiLogin
            // 
            pictureBoxMichiLogin.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxMichiLogin, "pictureBoxMichiLogin");
            pictureBoxMichiLogin.Name = "pictureBoxMichiLogin";
            pictureBoxMichiLogin.TabStop = false;
            // 
            // rbOpciónB
            // 
            resources.ApplyResources(rbOpciónB, "rbOpciónB");
            rbOpciónB.BackColor = Color.Transparent;
            rbOpciónB.FlatAppearance.BorderSize = 0;
            rbOpciónB.ForeColor = Color.White;
            rbOpciónB.Name = "rbOpciónB";
            rbOpciónB.TabStop = true;
            rbOpciónB.UseVisualStyleBackColor = false;
            // 
            // rbOpciónC
            // 
            resources.ApplyResources(rbOpciónC, "rbOpciónC");
            rbOpciónC.BackColor = Color.Transparent;
            rbOpciónC.FlatAppearance.BorderSize = 0;
            rbOpciónC.ForeColor = Color.White;
            rbOpciónC.Name = "rbOpciónC";
            rbOpciónC.TabStop = true;
            rbOpciónC.UseVisualStyleBackColor = false;
            // 
            // rbOpciónD
            // 
            resources.ApplyResources(rbOpciónD, "rbOpciónD");
            rbOpciónD.BackColor = Color.Transparent;
            rbOpciónD.FlatAppearance.BorderSize = 0;
            rbOpciónD.ForeColor = Color.White;
            rbOpciónD.Name = "rbOpciónD";
            rbOpciónD.TabStop = true;
            rbOpciónD.UseVisualStyleBackColor = false;
            // 
            // lblPorcentaje
            // 
            resources.ApplyResources(lblPorcentaje, "lblPorcentaje");
            lblPorcentaje.BackColor = Color.Transparent;
            lblPorcentaje.ForeColor = Color.White;
            lblPorcentaje.Name = "lblPorcentaje";
            // 
            // pBar
            // 
            resources.ApplyResources(pBar, "pBar");
            pBar.Name = "pBar";
            pBar.Style = ProgressBarStyle.Continuous;
            // 
            // lblProgreso
            // 
            resources.ApplyResources(lblProgreso, "lblProgreso");
            lblProgreso.BackColor = Color.Transparent;
            lblProgreso.ForeColor = Color.White;
            lblProgreso.Name = "lblProgreso";
            // 
            // lblQuiz
            // 
            resources.ApplyResources(lblQuiz, "lblQuiz");
            lblQuiz.BackColor = Color.Transparent;
            lblQuiz.ForeColor = SystemColors.ButtonHighlight;
            lblQuiz.Name = "lblQuiz";
            // 
            // rbOpciónA
            // 
            resources.ApplyResources(rbOpciónA, "rbOpciónA");
            rbOpciónA.BackColor = Color.Transparent;
            rbOpciónA.FlatAppearance.BorderSize = 0;
            rbOpciónA.ForeColor = Color.White;
            rbOpciónA.Name = "rbOpciónA";
            rbOpciónA.TabStop = true;
            rbOpciónA.UseVisualStyleBackColor = false;
            // 
            // QuizForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 47, 51);
            Controls.Add(lblQuiz);
            Controls.Add(rbOpciónD);
            Controls.Add(rbOpciónC);
            Controls.Add(rbOpciónB);
            Controls.Add(rbOpciónA);
            Controls.Add(pictureBoxMichiLogin);
            Controls.Add(pbImagenPregunta);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblProgreso);
            Controls.Add(pBar);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(lblPuntaje);
            Controls.Add(lblContadorPreguntas);
            Controls.Add(lblPreguntaActual);
            Controls.Add(lblPreguntaEnunciado);
            Name = "QuizForm";
            Load += QuizForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagenPregunta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPreguntaEnunciado;
        private Label lblPreguntaActual;
        private Label lblContadorPreguntas;
        private Label lblPuntaje;
        private Button btnAnterior;
        private Button btnSiguiente;
        private PictureBox pbImagenPregunta;
        private PictureBox pictureBoxMichiLogin;
        private RadioButton rbOpciónB;
        private RadioButton rbOpciónC;
        private RadioButton rbOpciónD;
        private Label lblPorcentaje;
        private ProgressBar pBar;
        private Label lblProgreso;
        private Label lblQuiz;
        private RadioButton rbOpciónA;
    }
}