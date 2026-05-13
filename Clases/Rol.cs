using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaEducativa
{
    public abstract class Rol
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Rol(int ID, string nom, string desc)
        {
            this.ID = ID;
            this.Nombre = nom;
            this.Descripcion = desc;
        }

    }

}
