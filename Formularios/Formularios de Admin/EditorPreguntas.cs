using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PlataformaEducativa.Formularios
{
    public partial class EditorPreguntas : Form
    {
        private string cadenaConexion = "Server=localhost; Database=peducativa; Uid=root; Pwd=;";
        private int idPregunta;

        // Constructor: Recibe ID para editar, o -1 para crear nueva
        public EditorPreguntas(int id)
        {
            InitializeComponent();
            this.idPregunta = id;
            if(idPregunta == 0)
            {
                LimpiarCampos();
            }
            CargarComboMaterias();
            ConfigurarComboCorrecta();
        }

        private void EditorPreguntas_Load(object sender, EventArgs e)
        {
            if (idPregunta == -1)
            {
                this.Text = "Nueva Pregunta";
            }
            else
            {
                this.Text = "Editar Pregunta";
                CargarDatosPregunta();
            }
        }

        private void CargarComboMaterias()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT id, CONCAT(nombre_es, ' / ', name_en) AS nombre_completo FROM modulos";
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbMateria.DataSource = dt;
                    cmbMateria.DisplayMember = "nombre_completo";
                    cmbMateria.ValueMember = "id";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar materias: " + ex.Message); }
        }

        private void ConfigurarComboCorrecta()
        {
            cmbCorrecta.Items.Clear();
            cmbCorrecta.Items.AddRange(new string[] { "A", "B", "C", "D" });
            cmbCorrecta.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarDatosPregunta()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM preguntas WHERE id = @id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idPregunta);
                        using (MySqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtEnunciadoES.Text = dr["pregunta_es"].ToString();
                                txtEnunciadoEN.Text = dr["pregunta_en"].ToString();
                                txtOpcionAES.Text = dr["opcion_a_es"].ToString();
                                txtOpcionAEN.Text = dr["opcion_a_en"].ToString();
                                txtOpcionBES.Text = dr["opcion_b_es"].ToString();
                                txtOpcionBEN.Text = dr["opcion_b_en"].ToString();
                                txtOpcionCES.Text = dr["opcion_c_es"].ToString();
                                txtOpcionCEN.Text = dr["opcion_c_en"].ToString();
                                txtOpcionDES.Text = dr["opcion_d_es"].ToString();
                                txtOpcionDEN.Text = dr["opcion_d_en"].ToString();
                                cmbCorrecta.SelectedItem = dr["letra_correcta"].ToString();
                                cmbMateria.SelectedValue = dr["id_modulo"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar pregunta: " + ex.Message); }
        }

        private void LimpiarCampos()
        {
            txtEnunciadoES.Clear();
            txtEnunciadoEN.Clear();
            txtOpcionAES.Clear();
            txtOpcionAEN.Clear();
            txtOpcionBES.Clear();
            txtOpcionBEN.Clear();
            txtOpcionCES.Clear();
            txtOpcionCEN.Clear();
            txtOpcionDES.Clear();
            txtOpcionDEN.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta;
                    if (idPregunta == -1)
                        consulta = "INSERT INTO preguntas (id_modulo, pregunta_es, pregunta_en, opcion_a_es, opcion_a_en, opcion_b_es, opcion_b_en, opcion_c_es, opcion_c_en, opcion_d_es, opcion_d_en, letra_correcta) VALUES (@id_mod, @pes, @pen, @aes, @aen, @bes, @ben, @ces, @cen, @des, @den, @cor)";
                    else
                        consulta = "UPDATE preguntas SET id_modulo=@id_mod, pregunta_es=@pes, pregunta_en=@pen, opcion_a_es=@aes, opcion_a_en=@aen, opcion_b_es=@bes, opcion_b_en=@ben, opcion_c_es=@ces, opcion_c_en=@cen, opcion_d_es=@des, opcion_d_en=@den, letra_correcta=@cor WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_mod", cmbMateria.SelectedValue);
                        cmd.Parameters.AddWithValue("@pes", txtEnunciadoES.Text);
                        cmd.Parameters.AddWithValue("@pen", txtEnunciadoEN.Text);
                        cmd.Parameters.AddWithValue("@aes", txtOpcionAES.Text);
                        cmd.Parameters.AddWithValue("@aen", txtOpcionAEN.Text);
                        cmd.Parameters.AddWithValue("@bes", txtOpcionBES.Text);
                        cmd.Parameters.AddWithValue("@ben", txtOpcionBEN.Text);
                        cmd.Parameters.AddWithValue("@ces", txtOpcionCES.Text);
                        cmd.Parameters.AddWithValue("@cen", txtOpcionCEN.Text);
                        cmd.Parameters.AddWithValue("@des", txtOpcionDES.Text);
                        cmd.Parameters.AddWithValue("@den", txtOpcionDEN.Text);
                        cmd.Parameters.AddWithValue("@cor", cmbCorrecta.SelectedItem.ToString());
                        if (idPregunta != -1) cmd.Parameters.AddWithValue("@id", idPregunta);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Guardado con éxito.");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
    }
}