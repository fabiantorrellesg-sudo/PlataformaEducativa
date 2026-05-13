using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaEducativa
{
    public class Jugador : Rol
    {
        public int Puntuacion { get; set; }

        public Jugador(int id, string nombre, string desc, int puntosIniciales = 0) : base(id, nombre, desc)
        {
            this.Puntuacion = puntosIniciales;
        }
    }

}
