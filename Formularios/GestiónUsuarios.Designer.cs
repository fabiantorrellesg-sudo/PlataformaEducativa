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
            panelContenido.Location = new Point(12, 123);
            panelContenido.Margin = new Padding(3, 4, 3, 4);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(872, 417);
            panelContenido.TabIndex = 2;
            // 
            // pictureBoxCat1
            // 
            pictureBoxCat1.Image = Properties.Resources.michiLogin;
            pictureBoxCat1.Location = new Point(33, 261);
            pictureBoxCat1.Name = "pictureBoxCat1";
            pictureBoxCat1.Size = new Size(166, 145);
            pictureBoxCat1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCat1.TabIndex = 16;
            pictureBoxCat1.TabStop = false;
            // 
            // pictureBoxUsuarioLogin
            // 
            pictureBoxUsuarioLogin.BackColor = Color.Transparent;
            pictureBoxUsuarioLogin.Image = (Image)resources.GetObject("pictureBoxUsuarioLogin.Image");
            pictureBoxUsuarioLogin.ImeMode = ImeMode.NoControl;
            pictureBoxUsuarioLogin.Location = new Point(50, 78);
            pictureBoxUsuarioLogin.Name = "pictureBoxUsuarioLogin";
            pictureBoxUsuarioLogin.Size = new Size(33, 34);
            pictureBoxUsuarioLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuarioLogin.TabIndex = 15;
            pictureBoxUsuarioLogin.TabStop = false;
            // 
            // pictureBoxCandado
            // 
            pictureBoxCandado.BackColor = Color.Transparent;
            pictureBoxCandado.Image = (Image)resources.GetObject("pictureBoxCandado.Image");
            pictureBoxCandado.ImeMode = ImeMode.NoControl;
            pictureBoxCandado.Location = new Point(50, 127);
            pictureBoxCandado.Name = "pictureBoxCandado";
            pictureBoxCandado.Size = new Size(33, 34);
            pictureBoxCandado.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCandado.TabIndex = 14;
            pictureBoxCandado.TabStop = false;
            // 
            // textBoxClave
            // 
            textBoxClave.BackColor = Color.FromArgb(227, 214, 179);
            textBoxClave.Font = new Font("Courier New", 12F, FontStyle.Bold);
            textBoxClave.ForeColor = SystemColors.Info;
            textBoxClave.Location = new Point(100, 131);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.PlaceholderText = "CLAVE";
            textBoxClave.Size = new Size(207, 30);
            textBoxClave.TabIndex = 13;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(227, 214, 179);
            textBoxUsuario.Font = new Font("Courier New", 12F, FontStyle.Bold);
            textBoxUsuario.ForeColor = Color.IndianRed;
            textBoxUsuario.Location = new Point(100, 78);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "USUARIO";
            textBoxUsuario.Size = new Size(207, 30);
            textBoxUsuario.TabIndex = 12;
            // 
            // listBoxRol
            // 
            listBoxRol.AccessibleRole = AccessibleRole.MenuBar;
            listBoxRol.BackColor = Color.FromArgb(55, 55, 55);
            listBoxRol.Font = new Font("Courier New", 12F, FontStyle.Bold);
            listBoxRol.ForeColor = Color.White;
            listBoxRol.FormattingEnabled = true;
            listBoxRol.Items.AddRange(new object[] { "Jugador", "Administrador", "Todos" });
            listBoxRol.Location = new Point(393, 31);
            listBoxRol.Name = "listBoxRol";
            listBoxRol.Size = new Size(132, 27);
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
            btnCargar.Location = new Point(337, 352);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(112, 44);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Courier New", 12F, FontStyle.Bold);
            lblRol.ForeColor = SystemColors.ButtonHighlight;
            lblRol.Location = new Point(337, 35);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(70, 23);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol: ";
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
            dgvGestionDeUsuarios.Location = new Point(337, 78);
            dgvGestionDeUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvGestionDeUsuarios.Name = "dgvGestionDeUsuarios";
            dgvGestionDeUsuarios.RowHeadersWidth = 51;
            dgvGestionDeUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionDeUsuarios.Size = new Size(493, 257);
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
            btnLimpiar.Location = new Point(190, 187);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 44);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
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
            btnVolverMenu.Location = new Point(630, 352);
            btnVolverMenu.Margin = new Padding(3, 4, 3, 4);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(200, 44);
            btnVolverMenu.TabIndex = 9;
            btnVolverMenu.Text = "Volver al menú";
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
            btnGuardar.Location = new Point(52, 187);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 44);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
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
            btnEliminar.Location = new Point(467, 352);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 44);
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
            panel1.Controls.Add(lblGestionUsuarios);
            panel1.Location = new Point(-7, 10);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 115);
            panel1.TabIndex = 3;
            // 
            // lblGestionUsuarios
            // 
            lblGestionUsuarios.AutoSize = true;
            lblGestionUsuarios.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionUsuarios.ForeColor = Color.White;
            lblGestionUsuarios.Location = new Point(277, 44);
            lblGestionUsuarios.Name = "lblGestionUsuarios";
            lblGestionUsuarios.Size = new Size(397, 37);
            lblGestionUsuarios.TabIndex = 0;
            lblGestionUsuarios.Text = "Gestión de usuarios";
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoRocasLimpio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 548);
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "GestionUsuarios";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Gestión de usuarios";
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
        private TextBox textBoxUsuario;
        private PictureBox pictureBoxCat1;
    }
}