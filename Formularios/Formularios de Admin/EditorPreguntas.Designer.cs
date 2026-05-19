namespace PlataformaEducativa.Formularios
{
    partial class EditorPreguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTitulo = new Panel();
            lblTitulo = new Label();
            panelContenido = new Panel();
            lblEnunciado = new Label();
            txtEnunciado = new TextBox();
            lblOpcionA = new Label();
            txtOpcionA = new TextBox();
            lblOpcionB = new Label();
            txtOpcionB = new TextBox();
            lblOpcionC = new Label();
            txtOpcionC = new TextBox();
            lblOpcionD = new Label();
            txtOpcionD = new TextBox();
            lblRespuesta = new Label();
            cmbRespuesta = new ComboBox();
            lblMateria = new Label();
            cmbMateria = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            panelTitulo.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(45, 45, 48);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(620, 70);
            panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Courier New", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(140, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Editor de preguntas";
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.Transparent;
            // panelContenido.BackgroundImage = Properties.Resources.FondoMaderaLimpio;
            panelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenido.Controls.Add(lblEnunciado);
            panelContenido.Controls.Add(txtEnunciado);
            panelContenido.Controls.Add(lblOpcionA);
            panelContenido.Controls.Add(txtOpcionA);
            panelContenido.Controls.Add(lblOpcionB);
            panelContenido.Controls.Add(txtOpcionB);
            panelContenido.Controls.Add(lblOpcionC);
            panelContenido.Controls.Add(txtOpcionC);
            panelContenido.Controls.Add(lblOpcionD);
            panelContenido.Controls.Add(txtOpcionD);
            panelContenido.Controls.Add(lblRespuesta);
            panelContenido.Controls.Add(cmbRespuesta);
            panelContenido.Controls.Add(lblMateria);
            panelContenido.Controls.Add(cmbMateria);
            panelContenido.Controls.Add(btnGuardar);
            panelContenido.Controls.Add(btnCancelar);
            panelContenido.Location = new Point(0, 70);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(620, 430);
            panelContenido.TabIndex = 1;
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.Font = new Font("Courier New", 11F, FontStyle.Bold);
            lblEnunciado.ForeColor = Color.White;
            lblEnunciado.Location = new Point(20, 20);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.BackColor = Color.FromArgb(227, 214, 179);
            txtEnunciado.Font = new Font("Courier New", 11F);
            txtEnunciado.ForeColor = Color.FromArgb(60, 40, 20);
            txtEnunciado.Location = new Point(20, 45);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(575, 60);
            txtEnunciado.TabIndex = 0;
            // 
            // lblOpcionA
            // 
            lblOpcionA.AutoSize = true;
            lblOpcionA.Font = new Font("Courier New", 11F, FontStyle.Bold);
            lblOpcionA.ForeColor = Color.White;
            lblOpcionA.Location = new Point(20, 120);
            lblOpcionA.Name = "lblOpcionA";
            lblOpcionA.Text = "Opci\u00f3n A:";
            // 
            // txtOpcionA
            // 
            txtOpcionA.BackColor = Color.FromArgb(227, 214, 179);
            txtOpcionA.Font = new Font("Courier New", 11F);
            txtOpcionA.ForeColor = Color.FromArgb(60, 40, 20);
            txtOpcionA.Location = new Point(130, 117);
            txtOpcionA.Name = "txtOpcionA";
            txtOpcionA.Size = new Size(465, 26);
            txtOpcionA.TabIndex = 1;
            // 
            // lblOpcionB
            // 
            lblOpcionB.AutoSize = true;
            lblOpcionB.Font = new Font("Courier New", 11F, FontStyle.Bold);
            lblOpcionB.ForeColor = Color.White;
            lblOpcionB.Location = new Point(20, 155);
            lblOpcionB.Name = "lblOpcionB";
            lblOpcionB.Text = "Opci\u00f3n B:";
            // 
            // txtOpcionB
            // 
            txtOpcionB.BackColor = Color.FromArgb(227, 214, 179);
            txtOpcionB.Font = new Font("Courier New", 11F);
            txtOpcionB.ForeColor = Color.FromArgb(60, 40, 20);
            txtOpcionB.Location = new Point(130, 152);
            txtOpcionB.Name = "txtOpcionB";
            txtOpcionB.Size = new Size(465, 26);
            txtOpcionB.TabIndex = 2;
            // 
            // lblOpcionC
            // 
            lblOpcionC.AutoSize = true;
            lblOpcionC.Font = new Font("Courier New", 11F, FontStyle.Bold);
            lblOpcionC.ForeColor = Color.White;
            lblOpcionC.Location = new Point(20, 190);
            lblOpcionC.Name = "lblOpcionC";
            lblOpcionC.Text = "Opci\u00f3n C:";
            // 
            // txtOpcionC
            // 
            txtOpcionC.BackColor = Color.FromArgb(227, 214, 179);
            txtOpcionC.Font = new Font("Courier New", 11F);
            txtOpcionC.ForeColor = Color.FromArgb(60, 40, 20);
            txtOpcionC.Location = new Point(130, 187);
            txtOpcionC.Name = "txtOpcionC";
            txtOpcionC.Size = new Size(465, 26);
            txtOpcionC.TabIndex = 3;
            // 
            // lblOpcionD
            // 
            lblOpcionD.AutoSize = true;
            lblOpcionD.Font = new Font("Courier New", 11F, FontStyle.Bold);
            lblOpcionD.ForeColor = Color.White;
            lblOpcionD.Location = new Point(20, 225);
            lblOpcionD.Name = "lblOpcionD";
            lblOpcionD.Text = "Opci\u00f3n D:";
            // 
            // txtOpcionD
            // 
            txtOpcionD.BackColor = Color.FromArgb(227, 214, 179);
            txtOpcionD.Font = new Font("Courier New", 11F);
            txtOpcionD.ForeColor = Color.FromArgb(60, 40, 20);
            txtOpcionD.Location = new Point(130, 222);
            txtOpcionD.Name = "txtOpcionD";
            txtOpcionD.Size = new Size(465, 26);
            txtOpcionD.TabIndex = 4;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Courier New", 11F, FontStyle.Bold);
            lblRespuesta.ForeColor = Color.White;
            lblRespuesta.Location = new Point(20, 265);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Text = "Respuesta correcta:";
            // 
            // cmbRespuesta
            // 
            cmbRespuesta.BackColor = Color.FromArgb(227, 214, 179);
            cmbRespuesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRespuesta.Font = new Font("Courier New", 11F);
            cmbRespuesta.ForeColor = Color.FromArgb(60, 40, 20);
            cmbRespuesta.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmbRespuesta.Location = new Point(240, 262);
            cmbRespuesta.Name = "cmbRespuesta";
            cmbRespuesta.Size = new Size(80, 27);
            cmbRespuesta.TabIndex = 5;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Courier New", 11F, FontStyle.Bold);
            lblMateria.ForeColor = Color.White;
            lblMateria.Location = new Point(20, 305);
            lblMateria.Name = "lblMateria";
            lblMateria.Text = "Materia:";
            // 
            // cmbMateria
            // 
            cmbMateria.BackColor = Color.FromArgb(227, 214, 179);
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.Font = new Font("Courier New", 11F);
            cmbMateria.ForeColor = Color.FromArgb(60, 40, 20);
            cmbMateria.Items.AddRange(new object[] {
                "Antropolog\u00eda filos\u00f3fica",
                "Arquitectura y estructura del computador",
                "C\u00e1lculo",
                "Deporte"
            });
            cmbMateria.Location = new Point(130, 302);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(350, 27);
            cmbMateria.TabIndex = 6;
            // 
            // btnGuardar
            // 
           // btnGuardar.BackgroundImage = Properties.Resources.MaderaPequena;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Courier New", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(100, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 44);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            // btnCancelar.BackgroundImage = Properties.Resources.MaderaPequena;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Courier New", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(340, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 44);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EditorPreguntas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 47, 51);
            BackgroundImage = Properties.Resources.FondoRocasLimpio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 500);
            Controls.Add(panelContenido);
            Controls.Add(panelTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditorPreguntas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editor de preguntas";
            Load += EditorPreguntas_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label lblTitulo;
        private Panel panelContenido;
        private Label lblEnunciado;
        private TextBox txtEnunciado;
        private Label lblOpcionA;
        private TextBox txtOpcionA;
        private Label lblOpcionB;
        private TextBox txtOpcionB;
        private Label lblOpcionC;
        private TextBox txtOpcionC;
        private Label lblOpcionD;
        private TextBox txtOpcionD;
        private Label lblRespuesta;
        private ComboBox cmbRespuesta;
        private Label lblMateria;
        private ComboBox cmbMateria;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}