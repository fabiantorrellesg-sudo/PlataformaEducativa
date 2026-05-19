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
            panelContenido = new Panel();
            gbModulos = new GroupBox();
            btnVolverMenu = new Button();
            btnEliminar = new Button();
            btnCargarEditar = new Button();
            dgvDatosGestionModulos = new DataGridView();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtNombreEN = new TextBox();
            txtNombreES = new TextBox();
            lblNombreEN = new Label();
            lblNombreES = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblGestionModulos = new Label();
            button1 = new Button();
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
            gbModulos.Controls.Add(button1);
            gbModulos.Controls.Add(btnVolverMenu);
            gbModulos.Controls.Add(btnEliminar);
            gbModulos.Controls.Add(btnCargarEditar);
            gbModulos.Controls.Add(dgvDatosGestionModulos);
            gbModulos.Controls.Add(btnLimpiar);
            gbModulos.Controls.Add(btnGuardar);
            gbModulos.Controls.Add(txtNombreEN);
            gbModulos.Controls.Add(txtNombreES);
            gbModulos.Controls.Add(lblNombreEN);
            gbModulos.Controls.Add(lblNombreES);
            gbModulos.Location = new Point(27, 23);
            gbModulos.Name = "gbModulos";
            gbModulos.Size = new Size(703, 267);
            gbModulos.TabIndex = 0;
            gbModulos.TabStop = false;
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
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(265, 228);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCargarEditar
            // 
            btnCargarEditar.BackgroundImage = (Image)resources.GetObject("btnCargarEditar.BackgroundImage");
            btnCargarEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCargarEditar.FlatAppearance.BorderSize = 0;
            btnCargarEditar.FlatStyle = FlatStyle.Flat;
            btnCargarEditar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarEditar.ForeColor = Color.White;
            btnCargarEditar.Location = new Point(24, 228);
            btnCargarEditar.Name = "btnCargarEditar";
            btnCargarEditar.Size = new Size(141, 23);
            btnCargarEditar.TabIndex = 7;
            btnCargarEditar.Text = "Cargar para Editar";
            btnCargarEditar.UseVisualStyleBackColor = true;
            // 
            // dgvDatosGestionModulos
            // 
            dgvDatosGestionModulos.AllowUserToAddRows = false;
            dgvDatosGestionModulos.AllowUserToResizeColumns = false;
            dgvDatosGestionModulos.AllowUserToResizeRows = false;
            dgvDatosGestionModulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatosGestionModulos.BackgroundColor = Color.FromArgb(55, 55, 55);
            dgvDatosGestionModulos.BorderStyle = BorderStyle.None;
            dgvDatosGestionModulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDatosGestionModulos.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosGestionModulos.EnableHeadersVisualStyles = false;
            dgvDatosGestionModulos.GridColor = Color.Gainsboro;
            dgvDatosGestionModulos.Location = new Point(19, 63);
            dgvDatosGestionModulos.Name = "dgvDatosGestionModulos";
            dgvDatosGestionModulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosGestionModulos.Size = new Size(662, 150);
            dgvDatosGestionModulos.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(606, 27);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(517, 27);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombreEN
            // 
            txtNombreEN.BackColor = Color.FromArgb(55, 55, 55);
            txtNombreEN.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEN.ForeColor = Color.White;
            txtNombreEN.Location = new Point(349, 27);
            txtNombreEN.Name = "txtNombreEN";
            txtNombreEN.Size = new Size(120, 21);
            txtNombreEN.TabIndex = 3;
            // 
            // txtNombreES
            // 
            txtNombreES.BackColor = Color.FromArgb(55, 55, 55);
            txtNombreES.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreES.ForeColor = Color.White;
            txtNombreES.Location = new Point(116, 27);
            txtNombreES.Name = "txtNombreES";
            txtNombreES.Size = new Size(120, 21);
            txtNombreES.TabIndex = 2;
            // 
            // lblNombreEN
            // 
            lblNombreEN.AutoSize = true;
            lblNombreEN.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEN.ForeColor = Color.White;
            lblNombreEN.Location = new Point(252, 30);
            lblNombreEN.Name = "lblNombreEN";
            lblNombreEN.Size = new Size(91, 15);
            lblNombreEN.TabIndex = 1;
            lblNombreEN.Text = "Nombre (EN):";
            // 
            // lblNombreES
            // 
            lblNombreES.AutoSize = true;
            lblNombreES.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreES.ForeColor = Color.White;
            lblNombreES.Location = new Point(19, 30);
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
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(176, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
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
        private TextBox txtNombreEN;
        private TextBox txtNombreES;
        private Button button2;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridView dgvDatosGestionModulos;
        private Button btnVolverMenu;
        private Button btnEliminar;
        private Button btnCargarEditar;
        private Button button1;
    }
}