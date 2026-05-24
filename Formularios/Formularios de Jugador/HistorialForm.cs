using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PlataformaEducativa.Clases;

namespace PlataformaEducativa.Formularios
{
    public partial class HistorialForm : Form
    {
        private int _idUsuario;

        public HistorialForm(int idUsuario)
        {
            _idUsuario = idUsuario;
            InitializeComponent();
            ConfigurarFormulario();
            CargarHistorial();
        }

        private DataGridView dgvHistorial;

        private void ConfigurarFormulario()
        {
            this.Text = ConfigIdiomas.IdiomaActual == "EN" ? "My History" : "Mi Historial";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(45, 47, 51);

            Label lblTitulo = new Label();
            lblTitulo.Text = this.Text;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 20);
            this.Controls.Add(lblTitulo);

            dgvHistorial = new DataGridView();
            dgvHistorial.Location = new Point(20, 70);
            dgvHistorial.Size = new Size(540, 250);
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgvHistorial);

            Button btnCerrar = new Button();
            btnCerrar.Text = ConfigIdiomas.IdiomaActual == "EN" ? "Close" : "Cerrar";
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.BackColor = Color.FromArgb(220, 53, 69);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.Location = new Point(460, 330);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Click += (s, e) => this.Close();
            this.Controls.Add(btnCerrar);
        }

        private void CargarHistorial()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"
                        SELECT m.nombre_es AS 'Módulo', h.puntuacion AS 'Puntaje', h.fecha AS 'Fecha'
                        FROM historial h
                        JOIN modulos m ON h.id_modulo = m.id
                        WHERE h.id_usuario = @idUser
                        ORDER BY h.fecha DESC";

                    if (ConfigIdiomas.IdiomaActual == "EN")
                    {
                        consulta = @"
                        SELECT m.name_en AS 'Module', h.puntuacion AS 'Score', h.fecha AS 'Date'
                        FROM historial h
                        JOIN modulos m ON h.id_modulo = m.id
                        WHERE h.id_usuario = @idUser
                        ORDER BY h.fecha DESC";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUser", _idUsuario);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistorial.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Name = "HistorialForm";
            this.ResumeLayout(false);
        }
    }
}
