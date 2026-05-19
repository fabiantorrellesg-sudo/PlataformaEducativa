using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlataformaEducativa.Formularios
{
    public partial class GestiónModulos : Form
    {
        public GestiónModulos()
        {
            InitializeComponent();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenuForm regreso = new AdminMenuForm();
            regreso.Show();
        }
    }
}
