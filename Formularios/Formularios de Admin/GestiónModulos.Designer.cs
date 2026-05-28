namespace PlataformaEducativa.Formularios
{
    partial class GestiónModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiónModulos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelContenido = new Panel();
            gbModulos = new GroupBox();
            txtNombreES = new TextBox();
            dgvDatosGestionModulos = new DataGridView();
            button1 = new Button();
            btnVolverMenu = new Button();
            btnEliminar = new Button();
            btnCargarEditar = new Button();
            txtNombreEN = new TextBox();
            lblNombreEN = new Label();
            lblNombreES = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblGestionModulos = new Label();
            panelContenido.SuspendLayout();
            gbModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosGestionModulos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            resources.ApplyResources(panelContenido, "panelContenido");
            panelContenido.BackColor = Color.Transparent;
            panelContenido.Controls.Add(gbModulos);
            panelContenido.Name = "panelContenido";
            // 
            // gbModulos
            // 
            gbModulos.Controls.Add(txtNombreES);
            gbModulos.Controls.Add(dgvDatosGestionModulos);
            gbModulos.Controls.Add(button1);
            gbModulos.Controls.Add(btnVolverMenu);
            gbModulos.Controls.Add(btnEliminar);
            gbModulos.Controls.Add(btnCargarEditar);
            gbModulos.Controls.Add(txtNombreEN);
            gbModulos.Controls.Add(lblNombreEN);
            gbModulos.Controls.Add(lblNombreES);
            resources.ApplyResources(gbModulos, "gbModulos");
            gbModulos.Name = "gbModulos";
            gbModulos.TabStop = false;
            // 
            // txtNombreES
            // 
            txtNombreES.BackColor = Color.FromArgb(55, 55, 55);
            resources.ApplyResources(txtNombreES, "txtNombreES");
            txtNombreES.ForeColor = Color.White;
            txtNombreES.Name = "txtNombreES";
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
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargarEditar
            // 
            resources.ApplyResources(btnCargarEditar, "btnCargarEditar");
            btnCargarEditar.FlatAppearance.BorderSize = 0;
            btnCargarEditar.ForeColor = Color.White;
            btnCargarEditar.Name = "btnCargarEditar";
            btnCargarEditar.UseVisualStyleBackColor = true;
            btnCargarEditar.Click += btnCargarEditar_Click;
            // 
            // txtNombreEN
            // 
            txtNombreEN.BackColor = Color.FromArgb(55, 55, 55);
            resources.ApplyResources(txtNombreEN, "txtNombreEN");
            txtNombreEN.ForeColor = Color.White;
            txtNombreEN.Name = "txtNombreEN";
            // 
            // lblNombreEN
            // 
            resources.ApplyResources(lblNombreEN, "lblNombreEN");
            lblNombreEN.ForeColor = Color.White;
            lblNombreEN.Name = "lblNombreEN";
            // 
            // lblNombreES
            // 
            resources.ApplyResources(lblNombreES, "lblNombreES");
            lblNombreES.ForeColor = Color.White;
            lblNombreES.Name = "lblNombreES";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblGestionModulos);
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblGestionModulos
            // 
            resources.ApplyResources(lblGestionModulos, "lblGestionModulos");
            lblGestionModulos.ForeColor = Color.White;
            lblGestionModulos.Name = "lblGestionModulos";
            // 
            // GestiónModulos
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panelContenido);
            DoubleBuffered = true;
            Name = "GestiónModulos";
            panelContenido.ResumeLayout(false);
            gbModulos.ResumeLayout(false);
            gbModulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosGestionModulos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private GroupBox gbModulos;
        private Panel panel1;
        private Label lblGestionModulos;
        private PictureBox pictureBox1;
        private Label lblNombreEN;
        private Label lblNombreES;
        private TextBox txtNombreEN;
        private Button btnVolverMenu;
        private Button btnEliminar;
        private Button btnCargarEditar;
        private Button button1;
        private TextBox txtNombreES;
        private DataGridView dgvDatosGestionModulos;
    }
}