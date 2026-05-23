using System;
using System.Collections.Generic;

namespace PlataformaEducativa
{
    public class Jugador : Rol
    {
        public int Puntuacion { get; set; }
        public int Nivel { get; set; }
        public string MateriaActual { get; set; }
        public int RespuestasCorrectas { get; private set; }
        public int RespuestasIncorrectas { get; private set; }

        public Jugador(int id, string nombre, string desc, int puntosIniciales = 0) : base(id, nombre, desc)
        {
            this.Puntuacion = puntosIniciales;
            this.Nivel = 1;
            this.MateriaActual = "";
            this.RespuestasCorrectas = 0;
            this.RespuestasIncorrectas = 0;
        }

        public void RegistrarCorrecta(int puntos = 10)
        {
            RespuestasCorrectas++;
            Puntuacion += puntos;
            // sube nivel cada 5 correctas
            if (RespuestasCorrectas > 0 && RespuestasCorrectas % 5 == 0)
                Nivel++;
        }

        public void RegistrarIncorrecta()
        {
            RespuestasIncorrectas++;
        }

        public void ReiniciarSesion()
        {
            RespuestasCorrectas = 0;
            RespuestasIncorrectas = 0;
        }

        public string ObtenerResumen()
        {
            return $"Nivel {Nivel} | Puntaje: {Puntuacion} | Correctas: {RespuestasCorrectas} | Incorrectas: {RespuestasIncorrectas}";
        }
    }
}
