using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PlataformaEducativa.Formularios
{

    public partial class GestionUsuarios : Form
    {
        string cadenaConexion = "Server=localhost; Database=peducativa; Uid = root; Pwd=;";
        public GestionUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();

        }

        public void CargarUsuarios()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string Consulta = "SELECT id,nombre,clave,rol FROM usuario";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(Consulta, conexion);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvGestionDeUsuarios.DataSource = tabla;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenuForm regreso = new AdminMenuForm();
            regreso.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxClave.Text) || string.IsNullOrWhiteSpace(listBoxRol.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos para registrar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxClave.Text.Trim().Length < 8)
            {
                MessageBox.Show("La contraseña debe tener como mínimo 8 carácteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {

                    conexion.Open();
                    string ConsultaCheck = "SELECT COUNT(*) FROM usuario WHERE nombre = @nombre";
                    int conteo = 0;

                    using (MySqlCommand VerificarUsuario = new MySqlCommand(ConsultaCheck, conexion))
                    {
                        VerificarUsuario.Parameters.AddWithValue("@nombre", textBoxUsuario.Text.Trim());
                        conteo = Convert.ToInt32(VerificarUsuario.ExecuteScalar());

                    }


                    if (conteo > 0)
                    {

                        MessageBox.Show("El nombre de usuario ingresado ya existe. Ingrese otro.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexion.Close();
                        return;
                    }

                    string ConsultaInsert = "INSERT INTO usuario (nombre,clave,rol) VALUES (@nombre,@clave,@rol)";

                    using (MySqlCommand AgregarUsuario = new MySqlCommand(ConsultaInsert, conexion))
                    {
                        AgregarUsuario.Parameters.AddWithValue("@nombre", textBoxUsuario.Text.Trim());

                        AgregarUsuario.Parameters.AddWithValue("@clave", textBoxClave.Text);

                        AgregarUsuario.Parameters.AddWithValue("@rol", listBoxRol.Text);

                        AgregarUsuario.ExecuteNonQuery();

                        conexion.Close();

                    }


                    MessageBox.Show("Usuario agregado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.ToString()}", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvGestionDeUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGestionDeUsuarios.Columns[e.ColumnIndex].Name.ToLower() == "clave" && e.Value != null)
            {
                e.Value = new string('●', e.Value.ToString().Length);

                e.FormattingApplied = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Clear();
            textBoxClave.Clear();
            listBoxRol.SelectedIndex = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (dgvGestionDeUsuarios.CurrentRow != null)
            {
                textBoxUsuario.Text = dgvGestionDeUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
                textBoxClave.Text = dgvGestionDeUsuarios.CurrentRow.Cells["clave"].Value.ToString();
                string rol = dgvGestionDeUsuarios.CurrentRow.Cells["rol"].Value.ToString();

                if (rol == "0")
                {
                    listBoxRol.Text = "Administrador";
                }
                if (rol == "1")
                {
                    listBoxRol.Text = "Jugador";
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario para cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idSeleccionado = Convert.ToInt32(dgvGestionDeUsuarios.CurrentRow.Cells["id"].Value);

            if (textBoxClave.Text.Trim().Length < 8)
            {
                MessageBox.Show("La contraseña debe tener mínimo 8 carácteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nombre = dgvGestionDeUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            DialogResult advertencia = MessageBox.Show($"¿Está seguro de editar los datos del usuario '{nombre}'?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (advertencia == DialogResult.Yes)
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consultaVerificar = "SELECT COUNT(*) FROM usuario WHERE nombre = @nombre AND id != @id";
                    int conteo = 0;

                    using (MySqlCommand verificar = new MySqlCommand(consultaVerificar, conexion))
                    {
                        verificar.Parameters.AddWithValue("@nombre", textBoxUsuario.Text);
                        verificar.Parameters.AddWithValue("@id", idSeleccionado);
                        conteo = Convert.ToInt32(verificar.ExecuteScalar());
                    }

                    if (conteo > 0)
                    {
                        MessageBox.Show("No puedes usar ese nombre porque ya le pertenece a otro usuario.", "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexion.Close();
                        return;
                    }

                    string consultaUpdate = "UPDATE usuario SET nombre = @nombre, clave = @clave, rol = @rol WHERE id = @id";
                    using (MySqlCommand Update = new MySqlCommand(consultaUpdate, conexion))
                    {
                        Update.Parameters.AddWithValue("@nombre", textBoxUsuario.Text.Trim());
                        Update.Parameters.AddWithValue("@clave", textBoxClave.Text);
                        Update.Parameters.AddWithValue("@rol", listBoxRol.Text);
                        Update.Parameters.AddWithValue("@id", idSeleccionado);

                        Update.ExecuteNonQuery();
                        conexion.Close();
                    }

                }
                MessageBox.Show("Usuario editado exitosamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
            else
            {
                return;
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGestionDeUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string consulta = "DELETE from usuario WHERE id = @id"; // Guardamos el orden específico del botón en una variable de tipo string. 
            int idUsuario = Convert.ToInt32(dgvGestionDeUsuarios.CurrentRow.Cells["id"].Value); // Guardamos el id ÚNICO del usuario. Especificamos el dgv,luego llamamos al método que indica
            string nombre = dgvGestionDeUsuarios.CurrentRow.Cells["nombre"].Value.ToString();

            DialogResult advertencia = MessageBox.Show($"¿Está seguro de eliminar al usuario '{nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (advertencia == DialogResult.Yes)
            {

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    using (MySqlCommand orden = new MySqlCommand(consulta, conexion))
                    {

                        orden.Parameters.AddWithValue("@id", idUsuario);

                        conexion.Open(); 
                        orden.ExecuteNonQuery();
                        conexion.Close();
                    }
                    MessageBox.Show("Usuario eliminado exitosamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    textBoxClave.Clear();
                    textBoxUsuario.Clear();
                    listBoxRol.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}");


                }
            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            if(btnVerClave != null && textBoxClave != null)
            {
                btnVerClave.Size = new Size(30, textBoxClave.Height);
                btnVerClave.Location = new Point(textBoxClave.Right - 30, textBoxClave.Top);
                btnVerClave.BringToFront();
            }
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            if(textBoxClave != null)
            {
                textBoxClave.UseSystemPasswordChar = !textBoxClave.UseSystemPasswordChar;
                btnVerClave.Text = textBoxClave.UseSystemPasswordChar ? "👁" : "🙈";
            }
        }
    }


}
