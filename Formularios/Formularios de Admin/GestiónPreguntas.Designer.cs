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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBoxCat1 = new PictureBox();
            panelContenido = new Panel();
            btnNuevaPregunta = new Button();
            listBoxMaterias = new ListBox();
            btnEditar = new Button();
            lblFiltrar = new Label();
            btnVolverMenu = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            lblGestionPreguntas = new Label();
            dgvDatosGestionModulos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).BeginInit();
            panelContenido.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosGestionModulos).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCat1
            // 
            pictureBoxCat1.Image = Properties.Resources.michiIcon;
            resources.ApplyResources(pictureBoxCat1, "pictureBoxCat1");
            pictureBoxCat1.Name = "pictureBoxCat1";
            pictureBoxCat1.TabStop = false;
            // 
            // panelContenido
            // 
            resources.ApplyResources(panelContenido, "panelContenido");
            panelContenido.BackColor = Color.Transparent;
            panelContenido.Controls.Add(dgvDatosGestionModulos);
            panelContenido.Controls.Add(btnNuevaPregunta);
            panelContenido.Controls.Add(listBoxMaterias);
            panelContenido.Controls.Add(btnEditar);
            panelContenido.Controls.Add(lblFiltrar);
            panelContenido.Controls.Add(btnVolverMenu);
            panelContenido.Controls.Add(btnEliminar);
            panelContenido.Name = "panelContenido";
            // 
            // btnNuevaPregunta
            // 
            resources.ApplyResources(btnNuevaPregunta, "btnNuevaPregunta");
            btnNuevaPregunta.FlatAppearance.BorderSize = 0;
            btnNuevaPregunta.ForeColor = Color.White;
            btnNuevaPregunta.Name = "btnNuevaPregunta";
            btnNuevaPregunta.UseVisualStyleBackColor = true;
            // 
            // listBoxMaterias
            // 
            listBoxMaterias.AccessibleRole = AccessibleRole.MenuBar;
            listBoxMaterias.BackColor = Color.FromArgb(55, 55, 55);
            resources.ApplyResources(listBoxMaterias, "listBoxMaterias");
            listBoxMaterias.ForeColor = Color.White;
            listBoxMaterias.FormattingEnabled = true;
            listBoxMaterias.Items.AddRange(new object[] { resources.GetString("listBoxMaterias.Items"), resources.GetString("listBoxMaterias.Items1"), resources.GetString("listBoxMaterias.Items2"), resources.GetString("listBoxMaterias.Items3") });
            listBoxMaterias.Name = "listBoxMaterias";
            // 
            // btnEditar
            // 
            resources.ApplyResources(btnEditar, "btnEditar");
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.ForeColor = Color.White;
            btnEditar.Name = "btnEditar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblFiltrar
            // 
            resources.ApplyResources(lblFiltrar, "lblFiltrar");
            lblFiltrar.ForeColor = SystemColors.ButtonHighlight;
            lblFiltrar.Name = "lblFiltrar";
            // 
            // btnVolverMenu
            // 
            resources.ApplyResources(btnVolverMenu, "btnVolverMenu");
            btnVolverMenu.FlatAppearance.BorderSize = 0;
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // btnEliminar
            // 
            resources.ApplyResources(btnEliminar, "btnEliminar");
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBoxCat1);
            panel1.Controls.Add(lblGestionPreguntas);
            panel1.Name = "panel1";
            // 
            // lblGestionPreguntas
            // 
            resources.ApplyResources(lblGestionPreguntas, "lblGestionPreguntas");
            lblGestionPreguntas.ForeColor = Color.White;
            lblGestionPreguntas.Name = "lblGestionPreguntas";
            // 
            // dgvDatosGestionModulos
            // 
            dgvDatosGestionModulos.AllowUserToAddRows = false;
            dgvDatosGestionModulos.AllowUserToResizeColumns = false;
            dgvDatosGestionModulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 43, 39);
            dgvDatosGestionModulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosGestionModulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatosGestionModulos.BackgroundColor = Color.FromArgb(43, 34, 28);
            dgvDatosGestionModulos.BorderStyle = BorderStyle.None;
            dgvDatosGestionModulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 26, 22);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatosGestionModulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatosGestionModulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(56, 50, 45);
            dataGridViewCellStyle3.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(238, 223, 190);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 40, 35);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDatosGestionModulos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDatosGestionModulos.EnableHeadersVisualStyles = false;
            dgvDatosGestionModulos.GridColor = Color.FromArgb(75, 63, 54);
            resources.ApplyResources(dgvDatosGestionModulos, "dgvDatosGestionModulos");
            dgvDatosGestionModulos.Name = "dgvDatosGestionModulos";
            dgvDatosGestionModulos.RowHeadersVisible = false;
            dgvDatosGestionModulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // GestiónPreguntas
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources.FondoRocasLimpio;
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "GestiónPreguntas";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).EndInit();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosGestionModulos).EndInit();
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
        private Button btnLimpiar;
        private Button btnVolverMenu;
        private Button btnGuardar;
        private Button btnEliminar;
        private Panel panel1;
        private Label lblGestionPreguntas;
        private Button btnNuevaPregunta;
        private DataGridView dgvDatosGestionModulos;
    }
}