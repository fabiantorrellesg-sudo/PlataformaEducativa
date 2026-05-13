using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaEducativa
{
    public class Usuario
    {

        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public Rol Perfil { get; set; }

        public Usuario(int ID, string NombreUsuario, string Clave, Rol rol)
        {
            this.ID = ID;
            this.NombreUsuario = NombreUsuario;
            this.Clave = Clave;
            this.Perfil = rol;
        }

    }

}
