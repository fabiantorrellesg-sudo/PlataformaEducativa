namespace PlataformaEducativa.Formularios
{
    partial class GestiónPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiónPreguntas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBoxCat1 = new PictureBox();
            panelContenido = new Panel();
            btnNuevaPregunta = new Button();
            listBoxMaterias = new ListBox();
            btnEditar = new Button();
            lblFiltrar = new Label();
            dgvGestionDePreguntas = new DataGridView();
            btnVolverMenu = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            lblGestionPreguntas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).BeginInit();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDePreguntas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCat1
            // 
            pictureBoxCat1.Image = Properties.Resources.michiIcon;
            pictureBoxCat1.Location = new Point(671, -3);
            pictureBoxCat1.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCat1.Name = "pictureBoxCat1";
            pictureBoxCat1.Size = new Size(81, 69);
            pictureBoxCat1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCat1.TabIndex = 16;
            pictureBoxCat1.TabStop = false;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.Transparent;
            panelContenido.BackgroundImage = (Image)resources.GetObject("panelContenido.BackgroundImage");
            panelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenido.Controls.Add(btnNuevaPregunta);
            panelContenido.Controls.Add(listBoxMaterias);
            panelContenido.Controls.Add(btnEditar);
            panelContenido.Controls.Add(lblFiltrar);
            panelContenido.Controls.Add(dgvGestionDePreguntas);
            panelContenido.Controls.Add(btnVolverMenu);
            panelContenido.Controls.Add(btnEliminar);
            panelContenido.Location = new Point(8, 92);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(763, 313);
            panelContenido.TabIndex = 4;
            // 
            // btnNuevaPregunta
            // 
            btnNuevaPregunta.BackgroundImage = (Image)resources.GetObject("btnNuevaPregunta.BackgroundImage");
            btnNuevaPregunta.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevaPregunta.FlatAppearance.BorderSize = 0;
            btnNuevaPregunta.FlatStyle = FlatStyle.Flat;
            btnNuevaPregunta.Font = new Font("Courier New", 12F);
            btnNuevaPregunta.ForeColor = Color.White;
            btnNuevaPregunta.Location = new Point(33, 264);
            btnNuevaPregunta.Name = "btnNuevaPregunta";
            btnNuevaPregunta.Size = new Size(210, 33);
            btnNuevaPregunta.TabIndex = 12;
            btnNuevaPregunta.Text = "Nueva pregunta";
            btnNuevaPregunta.UseVisualStyleBackColor = true;
            // 
            // listBoxMaterias
            // 
            listBoxMaterias.AccessibleRole = AccessibleRole.MenuBar;
            listBoxMaterias.BackColor = Color.FromArgb(55, 55, 55);
            listBoxMaterias.Font = new Font("Courier New", 12F, FontStyle.Bold);
            listBoxMaterias.ForeColor = Color.White;
            listBoxMaterias.FormattingEnabled = true;
            listBoxMaterias.Items.AddRange(new object[] { "Antropología filosófica", "Arquitectura y estructura del computador ", "Cálculo", "Deporte", "" });
            listBoxMaterias.Location = new Point(131, 26);
            listBoxMaterias.Margin = new Padding(3, 2, 3, 2);
            listBoxMaterias.Name = "listBoxMaterias";
            listBoxMaterias.Size = new Size(594, 22);
            listBoxMaterias.TabIndex = 11;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Courier New", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(249, 264);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 33);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar ";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Courier New", 12F, FontStyle.Bold);
            lblFiltrar.ForeColor = SystemColors.ButtonHighlight;
            lblFiltrar.Location = new Point(33, 29);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(88, 18);
            lblFiltrar.TabIndex = 10;
            lblFiltrar.Text = "Filtrar:";
            // 
            // dgvGestionDePreguntas
            // 
            dgvGestionDePreguntas.AllowUserToAddRows = false;
            dgvGestionDePreguntas.AllowUserToResizeColumns = false;
            dgvGestionDePreguntas.AllowUserToResizeRows = false;
            dgvGestionDePreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionDePreguntas.BackgroundColor = Color.FromArgb(55, 55, 55);
            dgvGestionDePreguntas.BorderStyle = BorderStyle.None;
            dgvGestionDePreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvGestionDePreguntas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionDePreguntas.EnableHeadersVisualStyles = false;
            dgvGestionDePreguntas.GridColor = Color.Gainsboro;
            dgvGestionDePreguntas.Location = new Point(33, 58);
            dgvGestionDePreguntas.Name = "dgvGestionDePreguntas";
            dgvGestionDePreguntas.RowHeadersWidth = 51;
            dgvGestionDePreguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionDePreguntas.Size = new Size(691, 193);
            dgvGestionDePreguntas.TabIndex = 7;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackgroundImage = (Image)resources.GetObject("btnVolverMenu.BackgroundImage");
            btnVolverMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverMenu.FlatAppearance.BorderSize = 0;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Courier New", 12F);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Location = new Point(528, 264);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(196, 33);
            btnVolverMenu.TabIndex = 9;
            btnVolverMenu.Text = "Volver al menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Courier New", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(376, 264);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(148, 33);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBoxCat1);
            panel1.Controls.Add(lblGestionPreguntas);
            panel1.Location = new Point(-9, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 86);
            panel1.TabIndex = 5;
            // 
            // lblGestionPreguntas
            // 
            lblGestionPreguntas.AutoSize = true;
            lblGestionPreguntas.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionPreguntas.ForeColor = Color.White;
            lblGestionPreguntas.Location = new Point(206, 32);
            lblGestionPreguntas.Name = "lblGestionPreguntas";
            lblGestionPreguntas.Size = new Size(334, 31);
            lblGestionPreguntas.TabIndex = 0;
            lblGestionPreguntas.Text = "Gestión de preguntas";
            // 
            // GestiónPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources.FondoRocasLimpio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 411);
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestiónPreguntas";
            Text = "Gestión de preguntas";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).EndInit();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDePreguntas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCat1;
        private Panel panelContenido;
        private PictureBox pictureBoxUsuarioLogin;
        private PictureBox pictureBoxCandado;
        private TextBox textBoxClave;
        private TextBox textBoxUsuario;
        private ListBox listBoxMaterias;
        private Button btnEditar;
        private Label lblFiltrar;
        private DataGridView dgvGestionDePreguntas;
        private Button btnLimpiar;
        private Button btnVolverMenu;
        private Button btnGuardar;
        private Button btnEliminar;
        private Panel panel1;
        private Label lblGestionPreguntas;
        private Button btnNuevaPregunta;
    }
}