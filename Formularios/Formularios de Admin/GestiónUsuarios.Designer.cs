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
            panelContenido = new Panel();
            pictureBoxCat1 = new PictureBox();
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
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeUsuarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.Transparent;
            panelContenido.BackgroundImage = (Image)resources.GetObject("panelContenido.BackgroundImage");
            panelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenido.Controls.Add(pictureBoxCat1);
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
            panelContenido.Location = new Point(10, 92);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(763, 313);
            panelContenido.TabIndex = 2;
            // 
            // pictureBoxCat1
            // 
            pictureBoxCat1.Image = Properties.Resources.michiLogin;
            pictureBoxCat1.Location = new Point(29, 196);
            pictureBoxCat1.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCat1.Name = "pictureBoxCat1";
            pictureBoxCat1.Size = new Size(145, 109);
            pictureBoxCat1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCat1.TabIndex = 16;
            pictureBoxCat1.TabStop = false;
            // 
            // pictureBoxUsuarioLogin
            // 
            pictureBoxUsuarioLogin.BackColor = Color.Transparent;
            pictureBoxUsuarioLogin.Image = (Image)resources.GetObject("pictureBoxUsuarioLogin.Image");
            pictureBoxUsuarioLogin.ImeMode = ImeMode.NoControl;
            pictureBoxUsuarioLogin.Location = new Point(44, 58);
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
            pictureBoxCandado.Location = new Point(44, 95);
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
            textBoxClave.ForeColor = SystemColors.Info;
            textBoxClave.Location = new Point(88, 98);
            textBoxClave.Margin = new Padding(3, 2, 3, 2);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.PlaceholderText = "CLAVE";
            textBoxClave.Size = new Size(182, 26);
            textBoxClave.TabIndex = 13;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(227, 214, 179);
            textBoxUsuario.Font = new Font("Courier New", 12F, FontStyle.Bold);
            textBoxUsuario.ForeColor = Color.IndianRed;
            textBoxUsuario.Location = new Point(88, 58);
            textBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "USUARIO";
            textBoxUsuario.Size = new Size(182, 26);
            textBoxUsuario.TabIndex = 12;
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
            listBoxRol.Font = new Font("Courier New", 12F, FontStyle.Bold);
            listBoxRol.ForeColor = Color.White;
            listBoxRol.FormattingEnabled = true;
            listBoxRol.Items.AddRange(new object[] { "Jugador", "Administrador", "Todos" });
            listBoxRol.Location = new Point(344, 23);
            listBoxRol.Margin = new Padding(3, 2, 3, 2);
            listBoxRol.Name = "listBoxRol";
            listBoxRol.Size = new Size(116, 4);
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
            btnCargar.Location = new Point(295, 264);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(98, 33);
            btnCargar.TabIndex = 8;
            resources.ApplyResources(btnCargar, "btnCargar");
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Courier New", 12F, FontStyle.Bold);
            lblRol.ForeColor = SystemColors.ButtonHighlight;
            lblRol.Location = new Point(295, 26);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(58, 18);
            lblRol.TabIndex = 10;
            resources.ApplyResources(lblRol, "lblRol");
            // 
            // dgvGestionDeUsuarios
            // 
            dgvGestionDeUsuarios.AllowUserToAddRows = false;
            dgvGestionDeUsuarios.AllowUserToResizeColumns = false;
            dgvGestionDeUsuarios.AllowUserToResizeRows = false;
            dgvGestionDeUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionDeUsuarios.BackgroundColor = Color.FromArgb(55, 55, 55);
            dgvGestionDeUsuarios.BorderStyle = BorderStyle.None;
            dgvGestionDeUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvGestionDeUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionDeUsuarios.EnableHeadersVisualStyles = false;
            dgvGestionDeUsuarios.GridColor = Color.Gainsboro;
            dgvGestionDeUsuarios.Location = new Point(295, 58);
            dgvGestionDeUsuarios.Name = "dgvGestionDeUsuarios";
            dgvGestionDeUsuarios.RowHeadersWidth = 51;
            dgvGestionDeUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionDeUsuarios.Size = new Size(431, 193);
            dgvGestionDeUsuarios.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Courier New", 12F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(166, 140);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 33);
            btnLimpiar.TabIndex = 5;
            resources.ApplyResources(btnLimpiar, "btnLimpiar");
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackgroundImage = (Image)resources.GetObject("btnVolverMenu.BackgroundImage");
            btnVolverMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverMenu.FlatAppearance.BorderSize = 0;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Courier New", 12F);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Location = new Point(551, 264);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(175, 33);
            btnVolverMenu.TabIndex = 9;
            resources.ApplyResources(btnVolverMenu, "btnVolverMenu");
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Courier New", 12F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(46, 140);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 33);
            btnGuardar.TabIndex = 4;
            resources.ApplyResources(btnGuardar, "btnGuardar");
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Courier New", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(409, 264);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 33);
            btnEliminar.TabIndex = 8;
            resources.ApplyResources(btnEliminar, "btnEliminar");
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
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
            resources.ApplyResources(lblGestionUsuarios, "lblGestionUsuarios");
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
            Load += GestionUsuarios_Load;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            resources.ApplyResources(this, "$this");
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private PictureBox pictureBoxCat1;
    }
}