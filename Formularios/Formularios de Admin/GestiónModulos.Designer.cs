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
            txtNombreEN = new TextBox();
            dgvDatosGestionModulos = new DataGridView();
            button1 = new Button();
            btnVolverMenu = new Button();
            btnEliminar = new Button();
            btnCargarEditar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtNombreES = new TextBox();
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
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.Transparent;
            panelContenido.BackgroundImage = (Image)resources.GetObject("panelContenido.BackgroundImage");
            panelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenido.Controls.Add(gbModulos);
            panelContenido.Location = new Point(13, 85);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(758, 313);
            panelContenido.TabIndex = 0;
            // 
            // gbModulos
            // 
            gbModulos.Controls.Add(txtNombreEN);
            gbModulos.Controls.Add(dgvDatosGestionModulos);
            gbModulos.Controls.Add(button1);
            gbModulos.Controls.Add(btnVolverMenu);
            gbModulos.Controls.Add(btnEliminar);
            gbModulos.Controls.Add(btnCargarEditar);
            gbModulos.Controls.Add(btnLimpiar);
            gbModulos.Controls.Add(btnGuardar);
            gbModulos.Controls.Add(txtNombreES);
            gbModulos.Controls.Add(lblNombreEN);
            gbModulos.Controls.Add(lblNombreES);
            gbModulos.Location = new Point(27, 23);
            gbModulos.Name = "gbModulos";
            gbModulos.Size = new Size(703, 267);
            gbModulos.TabIndex = 0;
            gbModulos.TabStop = false;
            // 
            // txtNombreEN
            // 
            txtNombreEN.BackColor = Color.FromArgb(55, 55, 55);
            txtNombreEN.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEN.ForeColor = Color.White;
            txtNombreEN.Location = new Point(416, 27);
            txtNombreEN.Name = "txtNombreEN";
            txtNombreEN.Size = new Size(174, 21);
            txtNombreEN.TabIndex = 12;
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
            dgvDatosGestionModulos.Location = new Point(22, 54);
            dgvDatosGestionModulos.Name = "dgvDatosGestionModulos";
            dgvDatosGestionModulos.RowHeadersVisible = false;
            dgvDatosGestionModulos.RowHeadersWidth = 51;
            dgvDatosGestionModulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosGestionModulos.Size = new Size(657, 164);
            dgvDatosGestionModulos.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(271, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackgroundImage = (Image)resources.GetObject("btnVolverMenu.BackgroundImage");
            btnVolverMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverMenu.FlatAppearance.BorderSize = 0;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Location = new Point(568, 228);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(113, 23);
            btnVolverMenu.TabIndex = 9;
            btnVolverMenu.Text = "Volver al Menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(361, 228);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargarEditar
            // 
            btnCargarEditar.BackgroundImage = (Image)resources.GetObject("btnCargarEditar.BackgroundImage");
            btnCargarEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCargarEditar.FlatAppearance.BorderSize = 0;
            btnCargarEditar.FlatStyle = FlatStyle.Flat;
            btnCargarEditar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarEditar.ForeColor = Color.White;
            btnCargarEditar.Location = new Point(121, 228);
            btnCargarEditar.Name = "btnCargarEditar";
            btnCargarEditar.Size = new Size(141, 23);
            btnCargarEditar.TabIndex = 7;
            btnCargarEditar.Text = "Cargar para Editar";
            btnCargarEditar.UseVisualStyleBackColor = true;
            btnCargarEditar.Click += btnCargarEditar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(602, 27);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(27, 228);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombreES
            // 
            txtNombreES.BackColor = Color.FromArgb(55, 55, 55);
            txtNombreES.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreES.ForeColor = Color.White;
            txtNombreES.Location = new Point(120, 26);
            txtNombreES.Name = "txtNombreES";
            txtNombreES.Size = new Size(201, 21);
            txtNombreES.TabIndex = 2;
            // 
            // lblNombreEN
            // 
            lblNombreEN.AutoSize = true;
            lblNombreEN.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEN.ForeColor = Color.White;
            lblNombreEN.Location = new Point(334, 29);
            lblNombreEN.Name = "lblNombreEN";
            lblNombreEN.Size = new Size(77, 15);
            lblNombreEN.TabIndex = 1;
            lblNombreEN.Text = "Name (EN):";
            // 
            // lblNombreES
            // 
            lblNombreES.AutoSize = true;
            lblNombreES.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreES.ForeColor = Color.White;
            lblNombreES.Location = new Point(23, 29);
            lblNombreES.Name = "lblNombreES";
            lblNombreES.Size = new Size(91, 15);
            lblNombreES.TabIndex = 0;
            lblNombreES.Text = "Nombre (ES):";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblGestionModulos);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 86);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(701, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 37);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblGestionModulos
            // 
            lblGestionModulos.AutoSize = true;
            lblGestionModulos.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionModulos.ForeColor = Color.White;
            lblGestionModulos.Location = new Point(242, 33);
            lblGestionModulos.Name = "lblGestionModulos";
            lblGestionModulos.Size = new Size(302, 31);
            lblGestionModulos.TabIndex = 0;
            lblGestionModulos.Text = "Gestión de Modulos";
            // 
            // GestiónModulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 411);
            Controls.Add(panel1);
            Controls.Add(panelContenido);
            DoubleBuffered = true;
            Name = "GestiónModulos";
            Padding = new Padding(10, 40, 10, 10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionModulos";
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
        private TextBox txtNombreES;
        private Button button2;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnVolverMenu;
        private Button btnEliminar;
        private Button btnCargarEditar;
        private Button button1;
        private DataGridView dgvDatosGestionModulos;
        private TextBox txtNombreEN;
    }
}