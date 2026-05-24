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
        private DataGridView dgvHistorial;

        public HistorialForm(int idUsuario)
        {
            _idUsuario = idUsuario;
            InitializeComponent();
            ConfigurarFormulario();
            CargarHistorial();
        }

        private void ConfigurarFormulario()
        {
            this.Text = ConfigIdiomas.IdiomaActual == "EN" ? "My History" : "Mi Historial";
            this.Size = new Size(640, 440);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = ConfigIdiomas.IdiomaActual == "EN" ? "My History" : "Mi Historial";
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(220, 220, 220);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 18);
            this.Controls.Add(lblTitulo);

            Panel separador = new Panel();
            separador.BackColor = Color.FromArgb(75, 75, 80);
            separador.Size = new Size(596, 1);
            separador.Location = new Point(20, 52);
            this.Controls.Add(separador);

            dgvHistorial = new DataGridView();
            dgvHistorial.Location = new Point(20, 64);
            dgvHistorial.Size = new Size(596, 300);
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.BackgroundColor = Color.FromArgb(37, 37, 40);
            dgvHistorial.GridColor = Color.FromArgb(65, 65, 70);

            dgvHistorial.DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 40);
            dgvHistorial.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvHistorial.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistorial.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvHistorial.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(48, 48, 52);
            dgvHistorial.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(210, 210, 210);

            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 30);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 180, 185);
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHistorial.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 4, 4, 4);
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistorial.ColumnHeadersHeight = 34;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.RowTemplate.Height = 32;
            this.Controls.Add(dgvHistorial);

            Button btnCerrar = new Button();
            btnCerrar.Text = ConfigIdiomas.IdiomaActual == "EN" ? "Close" : "Cerrar";
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.BackColor = Color.FromArgb(60, 60, 65);
            btnCerrar.ForeColor = Color.FromArgb(220, 220, 220);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(90, 90, 95);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 88);
            btnCerrar.Size = new Size(110, 34);
            btnCerrar.Location = new Point(506, 380);
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
            this.ClientSize = new System.Drawing.Size(624, 424);
            this.Name = "HistorialForm";
            this.ResumeLayout(false);
        }
    }
}
