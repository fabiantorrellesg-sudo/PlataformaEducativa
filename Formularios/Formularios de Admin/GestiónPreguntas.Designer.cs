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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            resources.ApplyResources(pictureBoxCat1, "pictureBoxCat1");
            pictureBoxCat1.Image = Properties.Resources.michiIcon;
            pictureBoxCat1.Name = "pictureBoxCat1";
            pictureBoxCat1.TabStop = false;
            // 
            // panelContenido
            // 
            resources.ApplyResources(panelContenido, "panelContenido");
            panelContenido.BackColor = Color.Transparent;
            panelContenido.Controls.Add(btnNuevaPregunta);
            panelContenido.Controls.Add(listBoxMaterias);
            panelContenido.Controls.Add(btnEditar);
            panelContenido.Controls.Add(lblFiltrar);
            panelContenido.Controls.Add(dgvGestionDePreguntas);
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
            resources.ApplyResources(listBoxMaterias, "listBoxMaterias");
            listBoxMaterias.AccessibleRole = AccessibleRole.MenuBar;
            listBoxMaterias.BackColor = Color.FromArgb(55, 55, 55);
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
            // dgvGestionDePreguntas
            // 
            resources.ApplyResources(dgvGestionDePreguntas, "dgvGestionDePreguntas");
            dgvGestionDePreguntas.AllowUserToAddRows = false;
            dgvGestionDePreguntas.AllowUserToResizeColumns = false;
            dgvGestionDePreguntas.AllowUserToResizeRows = false;
            dgvGestionDePreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionDePreguntas.BackgroundColor = Color.FromArgb(55, 55, 55);
            dgvGestionDePreguntas.BorderStyle = BorderStyle.None;
            dgvGestionDePreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGestionDePreguntas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGestionDePreguntas.EnableHeadersVisualStyles = false;
            dgvGestionDePreguntas.GridColor = Color.Gainsboro;
            dgvGestionDePreguntas.Name = "dgvGestionDePreguntas";
            dgvGestionDePreguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnVolverMenu
            // 
            //resources.ApplyResources(btnVolverMenu, "btnVolverMenu");
            //btnVolverMenu.FlatAppearance.BorderSize = 0;
            //btnVolverMenu.ForeColor = Color.White;
            //btnVolverMenu.Name = "btnVolverMenu";
            //btnVolverMenu.UseVisualStyleBackColor = true;
            //btnVolverMenu.Click += btnVolverMenu_Click;
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