using System;
using System.Windows.Forms;
using PlataformaEducativa.Formularios;

namespace PlataformaEducativa
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditarMaterias_Click(object sender, EventArgs e)
        {
            GestiónPreguntas ventanaPreguntas = new GestiónPreguntas();
            ventanaPreguntas.ShowDialog();
        }

        private void buttonGestionarUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuarios ventanaUsuarios = new GestionUsuarios();
            ventanaUsuarios.ShowDialog();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
