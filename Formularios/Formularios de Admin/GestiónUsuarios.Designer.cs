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
            lblGestionUsuarios = new Label();
            pictureBoxCat1 = new PictureBox();
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
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.Transparent;
            panelContenido.BackgroundImage = (Image)resources.GetObject("panelContenido.BackgroundImage");
            panelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenido.Controls.Add(button1);
            panelContenido.Controls.Add(pictureBoxUsuarioLogin);
            panelContenido.Controls.Add(pictureBoxCandado);
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
            panelContenido.Location = new Point(10, 92);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(763, 313);
            panelContenido.TabIndex = 2;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 217);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 17;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBoxUsuarioLogin
            // 
            pictureBoxUsuarioLogin.BackColor = Color.Transparent;
            pictureBoxUsuarioLogin.Image = (Image)resources.GetObject("pictureBoxUsuarioLogin.Image");
            pictureBoxUsuarioLogin.ImeMode = ImeMode.NoControl;
            pictureBoxUsuarioLogin.Location = new Point(43, 30);
            pictureBoxUsuarioLogin.Margin = new Padding(3, 2, 3, 2);
            pictureBoxUsuarioLogin.Name = "pictureBoxUsuarioLogin";
            pictureBoxUsuarioLogin.Size = new Size(29, 26);
            pictureBoxUsuarioLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuarioLogin.TabIndex = 15;
            pictureBoxUsuarioLogin.TabStop = false;
            // 
            // pictureBoxCandado
            // 
            pictureBoxCandado.BackColor = Color.Transparent;
            pictureBoxCandado.Image = (Image)resources.GetObject("pictureBoxCandado.Image");
            pictureBoxCandado.ImeMode = ImeMode.NoControl;
            pictureBoxCandado.Location = new Point(43, 67);
            pictureBoxCandado.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCandado.Name = "pictureBoxCandado";
            pictureBoxCandado.Size = new Size(29, 26);
            pictureBoxCandado.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCandado.TabIndex = 14;
            pictureBoxCandado.TabStop = false;
            // 
            // textBoxClave
            // 
            textBoxClave.BackColor = Color.FromArgb(227, 214, 179);
            textBoxClave.Font = new Font("Courier New", 12F, FontStyle.Bold);
            textBoxClave.ForeColor = Color.IndianRed;
            textBoxClave.Location = new Point(87, 70);
            textBoxClave.Margin = new Padding(3, 2, 3, 2);
            textBoxClave.MaxLength = 50;
            textBoxClave.Name = "textBoxClave";
            textBoxClave.PlaceholderText = "CLAVE";
            textBoxClave.Size = new Size(182, 26);
            textBoxClave.TabIndex = 13;
            textBoxClave.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(227, 214, 179);
            textBoxUsuario.Font = new Font("Courier New", 12F, FontStyle.Bold);
            textBoxUsuario.ForeColor = Color.IndianRed;
            textBoxUsuario.Location = new Point(87, 30);
            textBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "USUARIO";
            textBoxUsuario.Size = new Size(182, 26);
            textBoxUsuario.TabIndex = 12;
            // 
            // listBoxRol
            // 
            listBoxRol.AccessibleRole = AccessibleRole.MenuBar;
            listBoxRol.BackColor = Color.FromArgb(55, 55, 55);
            listBoxRol.Font = new Font("Courier New", 12F, FontStyle.Bold);
            listBoxRol.ForeColor = Color.White;
            listBoxRol.FormattingEnabled = true;
            listBoxRol.Items.AddRange(new object[] { "Jugador", "Administrador" });
            listBoxRol.Location = new Point(96, 118);
            listBoxRol.Margin = new Padding(3, 2, 3, 2);
            listBoxRol.Name = "listBoxRol";
            listBoxRol.Size = new Size(166, 22);
            listBoxRol.TabIndex = 11;
            // 
            // btnCargar
            // 
            btnCargar.BackgroundImage = (Image)resources.GetObject("btnCargar.BackgroundImage");
            btnCargar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Courier New", 12F);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(167, 167);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(109, 33);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Courier New", 12F, FontStyle.Bold);
            lblRol.ForeColor = SystemColors.ButtonHighlight;
            lblRol.Location = new Point(48, 120);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(58, 18);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol: ";
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
            dgvGestionDeUsuarios.Location = new Point(296, 25);
            dgvGestionDeUsuarios.Name = "dgvGestionDeUsuarios";
            dgvGestionDeUsuarios.RowHeadersVisible = false;
            dgvGestionDeUsuarios.RowHeadersWidth = 51;
            dgvGestionDeUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionDeUsuarios.Size = new Size(431, 225);
            dgvGestionDeUsuarios.TabIndex = 7;
            dgvGestionDeUsuarios.CellFormatting += dgvGestionDeUsuarios_CellFormatting;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Courier New", 12F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(96, 264);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 33);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackgroundImage = (Image)resources.GetObject("btnVolverMenu.BackgroundImage");
            btnVolverMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverMenu.FlatAppearance.BorderSize = 0;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Courier New", 12F);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Location = new Point(552, 264);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(175, 33);
            btnVolverMenu.TabIndex = 9;
            btnVolverMenu.Text = "Volver al menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Courier New", 12F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(37, 167);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 33);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Courier New", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(167, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 33);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBoxCat1);
            panel1.Controls.Add(lblGestionUsuarios);
            panel1.Location = new Point(-6, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 86);
            panel1.TabIndex = 3;
            // 
            // lblGestionUsuarios
            // 
            lblGestionUsuarios.AutoSize = true;
            lblGestionUsuarios.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionUsuarios.ForeColor = Color.White;
            lblGestionUsuarios.Location = new Point(242, 33);
            lblGestionUsuarios.Name = "lblGestionUsuarios";
            lblGestionUsuarios.Size = new Size(318, 31);
            lblGestionUsuarios.TabIndex = 0;
            lblGestionUsuarios.Text = "Gestión de usuarios";
            // 
            // pictureBoxCat1
            // 
            pictureBoxCat1.Image = Properties.Resources.michiIcon;
            pictureBoxCat1.Location = new Point(672, -5);
            pictureBoxCat1.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCat1.Name = "pictureBoxCat1";
            pictureBoxCat1.Size = new Size(81, 69);
            pictureBoxCat1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCat1.TabIndex = 18;
            pictureBoxCat1.TabStop = false;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoRocasLimpio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 411);
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionUsuarios";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de usuarios";
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
        private TextBox textBoxUsuario;
        private Button button1;
        private PictureBox pictureBoxCat1;
    }
}