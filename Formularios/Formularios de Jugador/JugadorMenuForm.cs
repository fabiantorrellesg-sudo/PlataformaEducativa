using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlataformaEducativa
{
    public partial class JugadorMenuForm : Form
    {
        private Jugador JugadorActual;
        public JugadorMenuForm(Jugador JugadorLogueado)
        {
            InitializeComponent();

            this.JugadorActual = JugadorLogueado;
        }

        private void JugadorMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void JugadorMenuForm_Load_1(object sender, EventArgs e)
        {

        }

        private void JugadorMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
