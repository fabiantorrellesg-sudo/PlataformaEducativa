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
            pbMateriaIcon = new PictureBox();
            lblMateria = new Label();
            pBoxCat = new PictureBox();
            rbOpciónA = new RadioButton();
            rbOpciónB = new RadioButton();
            rbOpciónC = new RadioButton();
            rbOpciónD = new RadioButton();
            lblPreguntaEnunciado = new Label();
            label1 = new Label();
            lblContadorPreguntas = new Label();
            lblPuntaje = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            pBar = new ProgressBar();
            lblProgreso = new Label();
            lblPorcentaje = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMateriaIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCat).BeginInit();
            SuspendLayout();
            // 
            // pbMateriaIcon
            // 
            pbMateriaIcon.BackColor = Color.Transparent;
            pbMateriaIcon.Location = new Point(12, 25);
            pbMateriaIcon.Name = "pbMateriaIcon";
            pbMateriaIcon.Size = new Size(100, 82);
            pbMateriaIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbMateriaIcon.TabIndex = 0;
            pbMateriaIcon.TabStop = false;
            // 
            // lblMateria
            // 
            lblMateria.BackColor = Color.Transparent;
            lblMateria.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMateria.ForeColor = Color.White;
            lblMateria.Location = new Point(118, 31);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(206, 34);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia:";
            lblMateria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pBoxCat
            // 
            pBoxCat.BackColor = Color.Transparent;
            pBoxCat.Image = (Image)resources.GetObject("pBoxCat.Image");
            pBoxCat.Location = new Point(456, -28);
            pBoxCat.Margin = new Padding(3, 2, 3, 2);
            pBoxCat.Name = "pBoxCat";
            pBoxCat.Size = new Size(284, 208);
            pBoxCat.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxCat.TabIndex = 6;
            pBoxCat.TabStop = false;
            // 
            // rbOpciónA
            // 
            rbOpciónA.BackColor = Color.Transparent;
            rbOpciónA.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOpciónA.ForeColor = Color.White;
            rbOpciónA.Location = new Point(38, 208);
            rbOpciónA.Name = "rbOpciónA";
            rbOpciónA.Size = new Size(69, 24);
            rbOpciónA.TabIndex = 7;
            rbOpciónA.TabStop = true;
            rbOpciónA.Text = "a)";
            rbOpciónA.TextAlign = ContentAlignment.MiddleCenter;
            rbOpciónA.UseVisualStyleBackColor = false;
            // 
            // rbOpciónB
            // 
            rbOpciónB.BackColor = Color.Transparent;
            rbOpciónB.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOpciónB.ForeColor = Color.White;
            rbOpciónB.Location = new Point(38, 248);
            rbOpciónB.Name = "rbOpciónB";
            rbOpciónB.Size = new Size(69, 24);
            rbOpciónB.TabIndex = 8;
            rbOpciónB.TabStop = true;
            rbOpciónB.Text = "b)";
            rbOpciónB.TextAlign = ContentAlignment.MiddleCenter;
            rbOpciónB.UseVisualStyleBackColor = false;
            // 
            // rbOpciónC
            // 
            rbOpciónC.BackColor = Color.Transparent;
            rbOpciónC.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOpciónC.ForeColor = Color.White;
            rbOpciónC.Location = new Point(38, 289);
            rbOpciónC.Name = "rbOpciónC";
            rbOpciónC.Size = new Size(69, 24);
            rbOpciónC.TabIndex = 9;
            rbOpciónC.TabStop = true;
            rbOpciónC.Text = "c)";
            rbOpciónC.TextAlign = ContentAlignment.MiddleCenter;
            rbOpciónC.UseVisualStyleBackColor = false;
            // 
            // rbOpciónD
            // 
            rbOpciónD.BackColor = Color.Transparent;
            rbOpciónD.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOpciónD.ForeColor = Color.White;
            rbOpciónD.Location = new Point(38, 329);
            rbOpciónD.Name = "rbOpciónD";
            rbOpciónD.Size = new Size(69, 24);
            rbOpciónD.TabIndex = 10;
            rbOpciónD.TabStop = true;
            rbOpciónD.Text = "d)";
            rbOpciónD.TextAlign = ContentAlignment.MiddleCenter;
            rbOpciónD.UseVisualStyleBackColor = false;
            // 
            // lblPreguntaEnunciado
            // 
            lblPreguntaEnunciado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPreguntaEnunciado.BackColor = Color.Transparent;
            lblPreguntaEnunciado.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreguntaEnunciado.ForeColor = Color.White;
            lblPreguntaEnunciado.Location = new Point(31, 153);
            lblPreguntaEnunciado.Name = "lblPreguntaEnunciado";
            lblPreguntaEnunciado.Size = new Size(100, 23);
            lblPreguntaEnunciado.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 125);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 12;
            label1.Text = "Pregunta Actual";
            // 
            // lblContadorPreguntas
            // 
            lblContadorPreguntas.AutoSize = true;
            lblContadorPreguntas.BackColor = Color.Transparent;
            lblContadorPreguntas.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContadorPreguntas.ForeColor = Color.White;
            lblContadorPreguntas.Location = new Point(365, 50);
            lblContadorPreguntas.Name = "lblContadorPreguntas";
            lblContadorPreguntas.Size = new Size(112, 15);
            lblContadorPreguntas.TabIndex = 13;
            lblContadorPreguntas.Text = "Pregunta: 0 / 0";
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntaje.ForeColor = Color.White;
            lblPuntaje.Location = new Point(365, 72);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(63, 15);
            lblPuntaje.TabIndex = 14;
            lblPuntaje.Text = "Puntaje:";
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Courier New", 8F);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(461, 408);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(92, 23);
            btnAnterior.TabIndex = 15;
            btnAnterior.Text = "Anterior";
            btnAnterior.TextAlign = ContentAlignment.MiddleLeft;
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Courier New", 8F);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(556, 408);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(92, 23);
            btnSiguiente.TabIndex = 16;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // pBar
            // 
            pBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pBar.Location = new Point(472, 157);
            pBar.Name = "pBar";
            pBar.Size = new Size(166, 11);
            pBar.Style = ProgressBarStyle.Continuous;
            pBar.TabIndex = 17;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.BackColor = Color.Transparent;
            lblProgreso.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgreso.ForeColor = Color.White;
            lblProgreso.Location = new Point(469, 132);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(70, 15);
            lblProgreso.TabIndex = 18;
            lblProgreso.Text = "Progreso:";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.BackColor = Color.Transparent;
            lblPorcentaje.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPorcentaje.ForeColor = Color.White;
            lblPorcentaje.Location = new Point(615, 182);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(21, 15);
            lblPorcentaje.TabIndex = 19;
            lblPorcentaje.Text = "0%";
            lblPorcentaje.TextAlign = ContentAlignment.MiddleRight;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 47, 51);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(667, 472);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblProgreso);
            Controls.Add(pBar);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(lblPuntaje);
            Controls.Add(lblContadorPreguntas);
            Controls.Add(label1);
            Controls.Add(lblPreguntaEnunciado);
            Controls.Add(rbOpciónD);
            Controls.Add(rbOpciónC);
            Controls.Add(rbOpciónB);
            Controls.Add(rbOpciónA);
            Controls.Add(lblMateria);
            Controls.Add(pbMateriaIcon);
            Controls.Add(pBoxCat);
            Name = "QuizForm";
            Text = "QuizForm";
            ((System.ComponentModel.ISupportInitialize)pbMateriaIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMateriaIcon;
        private Label lblMateria;
        private PictureBox pBoxCat;
        private RadioButton rbOpciónA;
        private RadioButton rbOpciónB;
        private RadioButton rbOpciónC;
        private RadioButton rbOpciónD;
        private Label lblPreguntaEnunciado;
        private Label label1;
        private Label lblContadorPreguntas;
        private Label lblPuntaje;
        private Button btnAnterior;
        private Button btnSiguiente;
        private ProgressBar pBar;
        private Label lblProgreso;
        private Label lblPorcentaje;
    }
}