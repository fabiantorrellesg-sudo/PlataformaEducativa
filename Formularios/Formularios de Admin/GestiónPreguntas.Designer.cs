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
            BtnVolver = new Button();
            dgvPreguntas = new DataGridView();
            btnNuevaPregunta = new Button();
            cmbFiltro = new ListBox();
            btnEditar = new Button();
            lblFiltrar = new Label();
            btnEliminar = new Button();
            panel1 = new Panel();
            lblGestionPreguntas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).BeginInit();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            panel1.SuspendLayout();
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
            panelContenido.Controls.Add(BtnVolver);
            panelContenido.Controls.Add(dgvPreguntas);
            panelContenido.Controls.Add(btnNuevaPregunta);
            panelContenido.Controls.Add(cmbFiltro);
            panelContenido.Controls.Add(btnEditar);
            panelContenido.Controls.Add(lblFiltrar);
            panelContenido.Controls.Add(btnEliminar);
            panelContenido.Name = "panelContenido";
            // 
            // BtnVolver
            // 
            resources.ApplyResources(BtnVolver, "BtnVolver");
            BtnVolver.FlatAppearance.BorderSize = 0;
            BtnVolver.ForeColor = Color.White;
            BtnVolver.Name = "BtnVolver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += btnVolverMenu_Click;
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.AllowUserToAddRows = false;
            dgvPreguntas.AllowUserToResizeColumns = false;
            dgvPreguntas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 43, 39);
            dgvPreguntas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreguntas.BackgroundColor = Color.FromArgb(43, 34, 28);
            dgvPreguntas.BorderStyle = BorderStyle.None;
            dgvPreguntas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 26, 22);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(56, 50, 45);
            dataGridViewCellStyle3.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(238, 223, 190);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 40, 35);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPreguntas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPreguntas.EnableHeadersVisualStyles = false;
            dgvPreguntas.GridColor = Color.FromArgb(75, 63, 54);
            resources.ApplyResources(dgvPreguntas, "dgvPreguntas");
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.RowHeadersVisible = false;
            dgvPreguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnNuevaPregunta
            // 
            resources.ApplyResources(btnNuevaPregunta, "btnNuevaPregunta");
            btnNuevaPregunta.FlatAppearance.BorderSize = 0;
            btnNuevaPregunta.ForeColor = Color.White;
            btnNuevaPregunta.Name = "btnNuevaPregunta";
            btnNuevaPregunta.UseVisualStyleBackColor = true;
            btnNuevaPregunta.Click += btnNuevaPregunta_Click;
            // 
            // cmbFiltro
            // 
            cmbFiltro.AccessibleRole = AccessibleRole.MenuBar;
            cmbFiltro.BackColor = Color.FromArgb(55, 55, 55);
            resources.ApplyResources(cmbFiltro, "cmbFiltro");
            cmbFiltro.ForeColor = Color.White;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Items.AddRange(new object[] { resources.GetString("cmbFiltro.Items"), resources.GetString("cmbFiltro.Items1"), resources.GetString("cmbFiltro.Items2"), resources.GetString("cmbFiltro.Items3") });
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            // 
            // btnEditar
            // 
            resources.ApplyResources(btnEditar, "btnEditar");
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.ForeColor = Color.White;
            btnEditar.Name = "btnEditar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblFiltrar
            // 
            resources.ApplyResources(lblFiltrar, "lblFiltrar");
            lblFiltrar.ForeColor = SystemColors.ButtonHighlight;
            lblFiltrar.Name = "lblFiltrar";
            // 
            // btnEliminar
            // 
            resources.ApplyResources(btnEliminar, "btnEliminar");
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
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
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
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
        private Button btnEditar;
        private Label lblFiltrar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Panel panel1;
        private Label lblGestionPreguntas;
        private Button btnNuevaPregunta;
        private DataGridView dgvPreguntas;
        private Button BtnVolver;
        private ListBox cmbFiltro;
    }
}