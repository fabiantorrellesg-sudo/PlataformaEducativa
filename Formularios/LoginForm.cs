using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using PlataformaEducativa.Clases;
using System;
using System.Data;

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
        private Button btnEN;
        private Button btnES;
        private Button btnIngresar;
        private Button btnVerClave;

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
            btnEN = new Button();
            btnES = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).BeginInit();
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
            textBoxClave.ForeColor = Color.IndianRed;
            textBoxClave.Name = "textBoxClave";
            textBoxClave.UseSystemPasswordChar = true;
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
            // btnEN
            // 
            resources.ApplyResources(btnEN, "btnEN");
            btnEN.Name = "btnEN";
            btnEN.UseVisualStyleBackColor = true;
            btnEN.Click += btnEN_Click;
            // 
            // btnES
            // 
            btnES.BackgroundImage = Properties.Resources.spain2;
            resources.ApplyResources(btnES, "btnES");
            btnES.Name = "btnES";
            btnES.UseVisualStyleBackColor = true;
            btnES.Click += btnES_Click;
            // 
            // btnVerClave
            // 
            btnVerClave.BackColor = Color.FromArgb(227, 214, 179);
            btnVerClave.FlatStyle = FlatStyle.Flat;
            btnVerClave.FlatAppearance.BorderSize = 0;
            btnVerClave.Text = "👁";
            btnVerClave.Cursor = Cursors.Hand;
            btnVerClave.Click += btnVerClave_Click;
            btnVerClave.Name = "btnVerClave";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(btnES);
            Controls.Add(btnEN);
            Controls.Add(pictureBoxMichiLogin);
            Controls.Add(pictureBoxUsuarioLogin);
            Controls.Add(pictureBoxCandado);
            Controls.Add(btnIngresar);
            Controls.Add(btnVerClave);
            Controls.Add(textBoxClave);
            Controls.Add(textBoxUsuario);
            Controls.Add(txtLogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCandado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMichiLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnVerClave.Size = new Size(30, textBoxClave.Height);
            btnVerClave.Location = new Point(textBoxClave.Right - 30, textBoxClave.Top);
            btnVerClave.BringToFront();
            AplicarIdioma();
        }

        // Centraliza todos los textos de la pantalla según el idioma actual
        private void AplicarIdioma()
        {
            if (ConfigIdiomas.IdiomaActual == "EN")
            {
                txtLogin.Text = "Login";
                textBoxUsuario.PlaceholderText = "Username";
                textBoxClave.PlaceholderText = "Password";
                btnIngresar.Text = "Log In";
            }
            else
            {
                txtLogin.Text = "Iniciar Sesión";
                textBoxUsuario.PlaceholderText = "Usuario";
                textBoxClave.PlaceholderText = "Contraseña";
                btnIngresar.Text = "Ingresar";
            }
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            textBoxClave.UseSystemPasswordChar = !textBoxClave.UseSystemPasswordChar;
            btnVerClave.Text = textBoxClave.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT id, nombre, rol FROM usuario WHERE nombre = @usuario AND clave = @clave";

            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxClave.Text))
            {
                if (ConfigIdiomas.IdiomaActual == "EN")
                    MessageBox.Show("Enter your username and password to log in", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Ingrese el nombre de usuario y la contraseña para iniciar sesión", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxClave.Text.Trim().Length < 8)
            {
                if (ConfigIdiomas.IdiomaActual == "EN")
                    MessageBox.Show("The password must be at least 8 characters long.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("La contraseña debe tener mínimo 8 carácteres", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", textBoxUsuario.Text.ToLower());
                    comando.Parameters.AddWithValue("@clave", textBoxClave.Text);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            int rol = Convert.ToInt32(lector["rol"]);

                            if (rol == 0)
                            {
                                AdminMenuForm ventanaAdmin = new AdminMenuForm();
                                ventanaAdmin.Show();
                            }
                            else if (rol == 1)
                            {
                                int idBD = Convert.ToInt32(lector["id"]);
                                string nombreBD = lector["nombre"].ToString()!;
                                string descripcion = "Usuario tipo jugador";

                                Jugador nuevoJugador = new Jugador(idBD, nombreBD, descripcion);
                                JugadorMenuForm ventanaJugador = new JugadorMenuForm(idBD, nombreBD);

                                if (ConfigIdiomas.IdiomaActual == "EN")
                                    MessageBox.Show($"Welcome to the game, {nuevoJugador.Nombre}!", "Enter the game");
                                else
                                    MessageBox.Show($"¡Bienvenido al juego, {nuevoJugador.Nombre}!", "Ingreso al juego");

                                ventanaJugador.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            if (ConfigIdiomas.IdiomaActual == "EN")
                                MessageBox.Show("Incorrect username or password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ConfigIdiomas.IdiomaActual == "EN")
                    MessageBox.Show($"Error: {ex.Message}", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Error: {ex.Message}", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            ConfigIdiomas.IdiomaActual = "EN";
            AplicarIdioma();
        }

        private void btnES_Click(object sender, EventArgs e)
        {
            ConfigIdiomas.IdiomaActual = "ES";
            AplicarIdioma();
        }
    }
}
