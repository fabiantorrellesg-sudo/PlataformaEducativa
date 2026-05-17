using PlataformaEducativa.Clases;

namespace PlataformaEducativa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private Label txtLogin;
        private TextBox textBoxUsuario;
        private TextBox textBoxClave;
        private PictureBox pictureBoxCandado;
        private PictureBox pictureBoxUsuarioLogin;
        private PictureBox pictureBoxMichiLogin;
        private PictureBox pbIdiomaEN;
        private PictureBox pbIdiomaES;
        private Button btnIngresar;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtLogin = new Label();
            textBoxUsuario = new TextBox();
            textBoxClave = new TextBox();
            btnIngresar = new Button();
            pictureBoxCandado = new PictureBox();
            pictureBoxUsuarioLogin = new PictureBox();
            pictureBoxMichiLogin = new PictureBox();
            pbIdiomaEN = new PictureBox();
            pbIdiomaES = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIdiomaEN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIdiomaES).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            resources.ApplyResources(txtLogin, "txtLogin");
            txtLogin.BackColor = Color.Transparent;
            txtLogin.ForeColor = SystemColors.ButtonFace;
            txtLogin.Name = "txtLogin";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(227, 214, 179);
            resources.ApplyResources(textBoxUsuario, "textBoxUsuario");
            textBoxUsuario.ForeColor = Color.IndianRed;
            textBoxUsuario.Name = "textBoxUsuario";
            // 
            // textBoxClave
            // 
            textBoxClave.BackColor = Color.FromArgb(227, 214, 179);
            resources.ApplyResources(textBoxClave, "textBoxClave");
            textBoxClave.ForeColor = SystemColors.Info;
            textBoxClave.Name = "textBoxClave";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(95, 163, 126);
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(45, 49, 58);
            btnIngresar.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(btnIngresar, "btnIngresar");
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBoxCandado
            // 
            pictureBoxCandado.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxCandado, "pictureBoxCandado");
            pictureBoxCandado.Name = "pictureBoxCandado";
            pictureBoxCandado.TabStop = false;
            // 
            // pictureBoxUsuarioLogin
            // 
            pictureBoxUsuarioLogin.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxUsuarioLogin, "pictureBoxUsuarioLogin");
            pictureBoxUsuarioLogin.Name = "pictureBoxUsuarioLogin";
            pictureBoxUsuarioLogin.TabStop = false;
            // 
            // pictureBoxMichiLogin
            // 
            pictureBoxMichiLogin.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxMichiLogin, "pictureBoxMichiLogin");
            pictureBoxMichiLogin.Name = "pictureBoxMichiLogin";
            pictureBoxMichiLogin.TabStop = false;
            // 
            // pbIdiomaEN
            // 
            pbIdiomaEN.BackColor = Color.Transparent;
            resources.ApplyResources(pbIdiomaEN, "pbIdiomaEN");
            pbIdiomaEN.Cursor = Cursors.Hand;
            pbIdiomaEN.Name = "pbIdiomaEN";
            pbIdiomaEN.TabStop = false;
            // 
            // pbIdiomaES
            // 
            pbIdiomaES.BackColor = Color.Transparent;
            resources.ApplyResources(pbIdiomaES, "pbIdiomaES");
            pbIdiomaES.Cursor = Cursors.Hand;
            pbIdiomaES.Name = "pbIdiomaES";
            pbIdiomaES.TabStop = false;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(pbIdiomaES);
            Controls.Add(pbIdiomaEN);
            Controls.Add(pictureBoxMichiLogin);
            Controls.Add(pictureBoxUsuarioLogin);
            Controls.Add(pictureBoxCandado);
            Controls.Add(btnIngresar);
            Controls.Add(textBoxClave);
            Controls.Add(textBoxUsuario);
            Controls.Add(txtLogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIdiomaEN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIdiomaES).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // creamos los roles (esto tiene que venir de la base de datos despues)
            Administrador rolAdmin = new Administrador(1, "Administrador", "Acceso total");
            Jugador rolJugador = new Jugador(2, "Jugador", "Acceso a módulos", 0);

            // creamos dos usuarios de prueba
            Usuario user1 = new Usuario(101, "admin", "123", rolAdmin);
            Usuario user2 = new Usuario(102, "proplayer", "abc", rolJugador);

            // logica de identificación
            if (textBoxUsuario.Text == user1.NombreUsuario && textBoxClave.Text == user1.Clave)
            {
                // verificar si el perfil es Administrador
                if (user1.Perfil is Administrador)
                {
                    AdminMenuForm ventanaAdmin = new AdminMenuForm();
                    ventanaAdmin.Show();
                    this.Hide();
                }
            }
            else if (textBoxUsuario.Text == user2.NombreUsuario && textBoxClave.Text == user2.Clave)
            {
                // verificamos si el perfil es Jugador
                if (user2.Perfil is Jugador)
                {
                    JugadorMenuForm ventanaJugador = new JugadorMenuForm();
                    ventanaJugador.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}

