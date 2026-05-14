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
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.BackColor = Color.Transparent;
            txtLogin.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = SystemColors.ButtonFace;
            txtLogin.Location = new Point(346, 54);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(267, 34);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "Iniciar sesión";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(227, 214, 179);
            textBoxUsuario.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsuario.ForeColor = Color.IndianRed;
            textBoxUsuario.Location = new Point(396, 109);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "USUARIO";
            textBoxUsuario.Size = new Size(207, 30);
            textBoxUsuario.TabIndex = 3;
            // 
            // textBoxClave
            // 
            textBoxClave.BackColor = Color.FromArgb(227, 214, 179);
            textBoxClave.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxClave.ForeColor = SystemColors.Info;
            textBoxClave.Location = new Point(396, 162);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.PlaceholderText = "CLAVE";
            textBoxClave.Size = new Size(207, 30);
            textBoxClave.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(95, 163, 126);
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(45, 49, 58);
            btnIngresar.FlatAppearance.BorderSize = 2;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(435, 248);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(168, 46);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBoxCandado
            // 
            pictureBoxCandado.BackColor = Color.Transparent;
            pictureBoxCandado.Image = (Image)resources.GetObject("pictureBoxCandado.Image");
            pictureBoxCandado.Location = new Point(346, 158);
            pictureBoxCandado.Name = "pictureBoxCandado";
            pictureBoxCandado.Size = new Size(33, 34);
            pictureBoxCandado.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCandado.TabIndex = 6;
            pictureBoxCandado.TabStop = false;
            // 
            // pictureBoxUsuarioLogin
            // 
            pictureBoxUsuarioLogin.BackColor = Color.Transparent;
            pictureBoxUsuarioLogin.Image = (Image)resources.GetObject("pictureBoxUsuarioLogin.Image");
            pictureBoxUsuarioLogin.Location = new Point(346, 109);
            pictureBoxUsuarioLogin.Name = "pictureBoxUsuarioLogin";
            pictureBoxUsuarioLogin.Size = new Size(33, 34);
            pictureBoxUsuarioLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuarioLogin.TabIndex = 7;
            pictureBoxUsuarioLogin.TabStop = false;
            // 
            // pictureBoxMichiLogin
            // 
            pictureBoxMichiLogin.BackColor = Color.Transparent;
            pictureBoxMichiLogin.Image = (Image)resources.GetObject("pictureBoxMichiLogin.Image");
            pictureBoxMichiLogin.Location = new Point(17, 125);
            pictureBoxMichiLogin.Name = "pictureBoxMichiLogin";
            pictureBoxMichiLogin.Size = new Size(181, 189);
            pictureBoxMichiLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMichiLogin.TabIndex = 8;
            pictureBoxMichiLogin.TabStop = false;
            // 
            // LoginForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 317);
            Controls.Add(pictureBoxMichiLogin);
            Controls.Add(pictureBoxUsuarioLogin);
            Controls.Add(pictureBoxCandado);
            Controls.Add(btnIngresar);
            Controls.Add(textBoxClave);
            Controls.Add(textBoxUsuario);
            Controls.Add(txtLogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "Ingresar a Plataforma Educativa";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).EndInit();
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

