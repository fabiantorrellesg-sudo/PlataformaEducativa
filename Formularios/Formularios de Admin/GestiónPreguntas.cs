using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PlataformaEducativa.Formularios
{
    public partial class GestiónPreguntas : Form
    {

        public GestiónPreguntas()
        {
            InitializeComponent();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenuForm volver = new AdminMenuForm();
            volver.Show();
        }
    }
}
