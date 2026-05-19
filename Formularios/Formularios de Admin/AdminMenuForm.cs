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

        // abre la gestion de preguntas
        private void buttonEditarMaterias_Click(object sender, EventArgs e)
        {
            GestiónPreguntas ventanaPreguntas = new GestiónPreguntas();
            ventanaPreguntas.ShowDialog();
        }

        // abre la gestion de usuarios
        private void buttonGestionarUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuarios ventanaUsuarios = new GestionUsuarios();
            ventanaUsuarios.ShowDialog();
        }

        // cierra sesion y vuelve al login
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
