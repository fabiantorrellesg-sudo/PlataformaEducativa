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
        private Label txtUsuario;
        private Label txtClave;
        private TextBox textBoxUsuario;
        private TextBox textBoxClave;
        private Button btnIngresar;

        private void InitializeComponent()
        {
            txtLogin = new Label();
            txtUsuario = new Label();
            txtClave = new Label();
            textBoxUsuario = new TextBox();
            textBoxClave = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.BackColor = Color.Transparent;
            txtLogin.ForeColor = SystemColors.ButtonFace;
            txtLogin.Location = new Point(118, 34);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(46, 20);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "Login";
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.ForeColor = SystemColors.ButtonFace;
            txtUsuario.Location = new Point(57, 75);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(59, 20);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            // 
            // txtClave
            // 
            txtClave.AutoSize = true;
            txtClave.BackColor = Color.Transparent;
            txtClave.ForeColor = SystemColors.ButtonFace;
            txtClave.Location = new Point(57, 116);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(45, 20);
            txtClave.TabIndex = 2;
            txtClave.Text = "Clave";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.InactiveCaptionText;
            textBoxUsuario.ForeColor = SystemColors.Info;
            textBoxUsuario.Location = new Point(121, 72);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 27);
            textBoxUsuario.TabIndex = 3;
            // 
            // textBoxClave
            // 
            textBoxClave.BackColor = SystemColors.InactiveCaptionText;
            textBoxClave.ForeColor = SystemColors.Info;
            textBoxClave.Location = new Point(121, 113);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.Size = new Size(100, 27);
            textBoxClave.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(62, 62, 66);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(99, 160);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // LoginForm
            // 
            BackgroundImage = Properties.Resources.cat1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(692, 354);
            Controls.Add(btnIngresar);
            Controls.Add(textBoxClave);
            Controls.Add(textBoxUsuario);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtLogin);
            Name = "LoginForm";
            Text = "Ingresar a Plataforma Educativa";
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

