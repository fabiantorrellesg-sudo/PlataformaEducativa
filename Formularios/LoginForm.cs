using PlataformaEducativa.Clases;
using MySql.Data.MySqlClient;
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
        private PictureBox pbIdiomaEN;
        private PictureBox pbIdiomaES;
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
            pbIdiomaEN = new PictureBox();
            pbIdiomaES = new PictureBox();
            btnVerClave = new Button();
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
            Controls.Add(pbIdiomaES);
            Controls.Add(pbIdiomaEN);
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
            ((System.ComponentModel.ISupportInitialize)pbIdiomaEN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIdiomaES).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnVerClave.Size = new Size(30, textBoxClave.Height);
            btnVerClave.Location = new Point(textBoxClave.Right - 30, textBoxClave.Top);
            btnVerClave.BringToFront();
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            textBoxClave.UseSystemPasswordChar = !textBoxClave.UseSystemPasswordChar;
            btnVerClave.Text = textBoxClave.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Server=localhost; Database=peducativa; Uid = root; Pwd=;";
            string consulta = "SELECT id, nombre, rol FROM usuario WHERE nombre = @usuario AND clave = @clave";

            if(string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxClave.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario y la contraseña para iniciar sesión", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (textBoxClave.Text.Trim().Length < 8)
            {
                MessageBox.Show("La contraseña debe tener mínimo 8 carácteres", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
           
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            using (MySqlCommand comando = new MySqlCommand(consulta,conexion))
            {
                comando.Parameters.AddWithValue("@usuario", textBoxUsuario.Text.ToLower());
                comando.Parameters.AddWithValue("@clave", textBoxClave.Text);

                    conexion.Open();

              MySqlDataReader lector = comando.ExecuteReader();
              
                    if(lector.Read())
                    {
                        int rol = Convert.ToInt32(lector["rol"]);

                        if(rol==0)
                        {
                            AdminMenuForm ventanaAdmin = new AdminMenuForm();
                            ventanaAdmin.Show();

                        }
                        else if(rol==1)
                        {
                            int idBD = Convert.ToInt32(lector["id"]);
                            string nombreBD = lector["nombre"].ToString();
                            string descripcion = "Usuario tipo jugador";

                            Jugador nuevoJugador = new Jugador(idBD, nombreBD, descripcion);
                            JugadorMenuForm ventanaJugador = new JugadorMenuForm(nuevoJugador);
                            MessageBox.Show($"¡Bienvenido al juego, {nuevoJugador.Nombre}!", "Ingreso al juego");
                            ventanaJugador.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error de inició de sesión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    conexion.Close();
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: {0}", ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

