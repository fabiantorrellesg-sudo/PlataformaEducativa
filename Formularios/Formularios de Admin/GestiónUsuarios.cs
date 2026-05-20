using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlataformaEducativa.Formularios
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
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
