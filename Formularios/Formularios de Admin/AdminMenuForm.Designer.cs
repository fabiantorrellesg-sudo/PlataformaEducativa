namespace PlataformaEducativa
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            panel1 = new Panel();
            buttonCerrar = new Button();
            buttonReportes = new Button();
            buttonEditarMaterias = new Button();
            buttonGestionarUsuarios = new Button();
            labelTitulo = new Label();
            lblBienvenido = new Label();
            lblMensaje = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(buttonCerrar);
            panel1.Controls.Add(buttonReportes);
            panel1.Controls.Add(buttonEditarMaterias);
            panel1.Controls.Add(buttonGestionarUsuarios);
            panel1.Controls.Add(labelTitulo);
            panel1.Name = "panel1";
            // 
            // buttonCerrar
            // 
            resources.ApplyResources(buttonCerrar, "buttonCerrar");
            buttonCerrar.Cursor = Cursors.Hand;
            buttonCerrar.FlatAppearance.BorderColor = Color.FromArgb(62, 62, 66);
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.ForeColor = SystemColors.ControlLightLight;
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // buttonReportes
            // 
            resources.ApplyResources(buttonReportes, "buttonReportes");
            buttonReportes.Cursor = Cursors.Hand;
            buttonReportes.FlatAppearance.BorderColor = Color.FromArgb(62, 62, 66);
            buttonReportes.FlatAppearance.BorderSize = 0;
            buttonReportes.ForeColor = SystemColors.ControlLightLight;
            buttonReportes.Name = "buttonReportes";
            buttonReportes.UseVisualStyleBackColor = false;
            buttonReportes.Click += buttonReportes_Click;
            // 
            // buttonEditarMaterias
            // 
            resources.ApplyResources(buttonEditarMaterias, "buttonEditarMaterias");
            buttonEditarMaterias.Cursor = Cursors.Hand;
            buttonEditarMaterias.FlatAppearance.BorderColor = Color.FromArgb(62, 62, 66);
            buttonEditarMaterias.FlatAppearance.BorderSize = 0;
            buttonEditarMaterias.ForeColor = SystemColors.ControlLightLight;
            buttonEditarMaterias.Name = "buttonEditarMaterias";
            buttonEditarMaterias.UseVisualStyleBackColor = false;
            buttonEditarMaterias.Click += buttonEditarMaterias_Click;
            // 
            // buttonGestionarUsuarios
            // 
            resources.ApplyResources(buttonGestionarUsuarios, "buttonGestionarUsuarios");
            buttonGestionarUsuarios.Cursor = Cursors.Hand;
            buttonGestionarUsuarios.FlatAppearance.BorderColor = Color.FromArgb(62, 62, 66);
            buttonGestionarUsuarios.FlatAppearance.BorderSize = 0;
            buttonGestionarUsuarios.ForeColor = SystemColors.ControlLightLight;
            buttonGestionarUsuarios.Name = "buttonGestionarUsuarios";
            buttonGestionarUsuarios.UseVisualStyleBackColor = false;
            buttonGestionarUsuarios.Click += buttonGestionarUsuarios_Click;
            // 
            // labelTitulo
            // 
            resources.ApplyResources(labelTitulo, "labelTitulo");
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Name = "labelTitulo";
            // 
            // lblBienvenido
            // 
            resources.ApplyResources(lblBienvenido, "lblBienvenido");
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.ForeColor = Color.White;
            lblBienvenido.Name = "lblBienvenido";
            // 
            // lblMensaje
            // 
            resources.ApplyResources(lblMensaje, "lblMensaje");
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Name = "lblMensaje";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // AdminMenuForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 47, 51);
            Controls.Add(pictureBox1);
            Controls.Add(lblMensaje);
            Controls.Add(lblBienvenido);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "AdminMenuForm";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelTitulo;
        private Button buttonGestionarUsuarios;
        private Button buttonEditarMaterias;
        private Button buttonReportes;
        private Button buttonCerrar;
        private Label lblBienvenido;
        private Label lblMensaje;
        private PictureBox pictureBox1;
    }
}