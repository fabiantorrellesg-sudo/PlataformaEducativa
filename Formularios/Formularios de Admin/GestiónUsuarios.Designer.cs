namespace PlataformaEducativa.Formularios
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelContenido = new Panel();
            button1 = new Button();
            pictureBoxUsuarioLogin = new PictureBox();
            pictureBoxCandado = new PictureBox();
            textBoxClave = new TextBox();
            textBoxUsuario = new TextBox();
            listBoxRol = new ListBox();
            btnCargar = new Button();
            lblRol = new Label();
            dgvGestionDeUsuarios = new DataGridView();
            btnLimpiar = new Button();
            btnVolverMenu = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            pictureBoxCat1 = new PictureBox();
            lblGestionUsuarios = new Label();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeUsuarios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            resources.ApplyResources(panelContenido, "panelContenido");
            panelContenido.BackColor = Color.Transparent;
            panelContenido.Controls.Add(button1);
            panelContenido.Controls.Add(pictureBoxUsuarioLogin);
            panelContenido.Controls.Add(pictureBoxCandado);
            panelContenido.Controls.Add(btnVerClave);
            panelContenido.Controls.Add(textBoxClave);
            panelContenido.Controls.Add(textBoxUsuario);
            panelContenido.Controls.Add(listBoxRol);
            panelContenido.Controls.Add(btnCargar);
            panelContenido.Controls.Add(lblRol);
            panelContenido.Controls.Add(dgvGestionDeUsuarios);
            panelContenido.Controls.Add(btnLimpiar);
            panelContenido.Controls.Add(btnVolverMenu);
            panelContenido.Controls.Add(btnGuardar);
            panelContenido.Controls.Add(btnEliminar);
            panelContenido.Name = "panelContenido";
            panelContenido.Paint += panelContenido_Paint;
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
            // pictureBoxUsuarioLogin
            // 
            pictureBoxUsuarioLogin.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxUsuarioLogin, "pictureBoxUsuarioLogin");
            pictureBoxUsuarioLogin.Name = "pictureBoxUsuarioLogin";
            pictureBoxUsuarioLogin.TabStop = false;
            // 
            // pictureBoxCandado
            // 
            pictureBoxCandado.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxCandado, "pictureBoxCandado");
            pictureBoxCandado.Name = "pictureBoxCandado";
            pictureBoxCandado.TabStop = false;
            // 
            // textBoxClave
            // 
            textBoxClave.BackColor = Color.FromArgb(227, 214, 179);
            resources.ApplyResources(textBoxClave, "textBoxClave");
            textBoxClave.ForeColor = Color.IndianRed;
            textBoxClave.Name = "textBoxClave";
            textBoxClave.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(227, 214, 179);
            resources.ApplyResources(textBoxUsuario, "textBoxUsuario");
            textBoxUsuario.ForeColor = Color.IndianRed;
            textBoxUsuario.Name = "textBoxUsuario";
            // 
            // btnVerClave
            // 
            btnVerClave = new Button();
            btnVerClave.BackColor = Color.FromArgb(227, 214, 179);
            btnVerClave.FlatStyle = FlatStyle.Flat;
            btnVerClave.FlatAppearance.BorderSize = 0;
            btnVerClave.Text = "👁";
            btnVerClave.Cursor = Cursors.Hand;
            btnVerClave.Click += btnVerClave_Click;
            btnVerClave.Name = "btnVerClave";
            // 
            // listBoxRol
            // 
            listBoxRol.AccessibleRole = AccessibleRole.MenuBar;
            listBoxRol.BackColor = Color.FromArgb(55, 55, 55);
            resources.ApplyResources(listBoxRol, "listBoxRol");
            listBoxRol.ForeColor = Color.White;
            listBoxRol.FormattingEnabled = true;
            listBoxRol.Items.AddRange(new object[] { resources.GetString("listBoxRol.Items"), resources.GetString("listBoxRol.Items1") });
            listBoxRol.Name = "listBoxRol";
            // 
            // btnCargar
            // 
            resources.ApplyResources(btnCargar, "btnCargar");
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.ForeColor = Color.White;
            btnCargar.Name = "btnCargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblRol
            // 
            resources.ApplyResources(lblRol, "lblRol");
            lblRol.ForeColor = SystemColors.ButtonHighlight;
            lblRol.Name = "lblRol";
            // 
            // dgvGestionDeUsuarios
            // 
            dgvGestionDeUsuarios.AllowUserToAddRows = false;
            dgvGestionDeUsuarios.AllowUserToResizeColumns = false;
            dgvGestionDeUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 43, 39);
            dgvGestionDeUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionDeUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionDeUsuarios.BackgroundColor = Color.FromArgb(43, 34, 28);
            dgvGestionDeUsuarios.BorderStyle = BorderStyle.None;
            dgvGestionDeUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 26, 22);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGestionDeUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGestionDeUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(56, 50, 45);
            dataGridViewCellStyle3.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(238, 223, 190);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 40, 35);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGestionDeUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGestionDeUsuarios.EnableHeadersVisualStyles = false;
            dgvGestionDeUsuarios.GridColor = Color.FromArgb(75, 63, 54);
            resources.ApplyResources(dgvGestionDeUsuarios, "dgvGestionDeUsuarios");
            dgvGestionDeUsuarios.Name = "dgvGestionDeUsuarios";
            dgvGestionDeUsuarios.RowHeadersVisible = false;
            dgvGestionDeUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionDeUsuarios.CellFormatting += dgvGestionDeUsuarios_CellFormatting;
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(btnLimpiar, "btnLimpiar");
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
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
            // btnGuardar
            // 
            resources.ApplyResources(btnGuardar, "btnGuardar");
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            panel1.Controls.Add(lblGestionUsuarios);
            panel1.Name = "panel1";
            // 
            // pictureBoxCat1
            // 
            pictureBoxCat1.Image = Properties.Resources.michiIcon;
            resources.ApplyResources(pictureBoxCat1, "pictureBoxCat1");
            pictureBoxCat1.Name = "pictureBoxCat1";
            pictureBoxCat1.TabStop = false;
            // 
            // lblGestionUsuarios
            // 
            resources.ApplyResources(lblGestionUsuarios, "lblGestionUsuarios");
            lblGestionUsuarios.ForeColor = Color.White;
            lblGestionUsuarios.Name = "lblGestionUsuarios";
            // 
            // GestionUsuarios
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoRocasLimpio;
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "GestionUsuarios";
            Load += GestionUsuarios_Load;
            SizeGripStyle = SizeGripStyle.Show;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private GroupBox gbModulos;
        private Button btnVolverMenu;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Panel panel1;
        private Label lblGestionUsuarios;
        private ListBox listBoxRol;
        private Label lblRol;
        private Button btnCargar;
        private DataGridView dgvGestionDeUsuarios;
        private PictureBox pictureBoxUsuarioLogin;
        private PictureBox pictureBoxCandado;
        private TextBox textBoxClave;
        private Button btnVerClave;
        private TextBox textBoxUsuario;
        private Button button1;
        private PictureBox pictureBoxCat1;
    }
}