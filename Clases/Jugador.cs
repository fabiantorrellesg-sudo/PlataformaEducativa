using System;
using System.Collections.Generic;

namespace PlataformaEducativa
{
    public class Jugador : Rol
    {
        // puntaje acumulado del jugador
        public int Puntuacion { get; set; }

        // nivel actual del jugador (empieza en 1)
        public int Nivel { get; set; }

        // materia que el jugador eligio para jugar
        public string MateriaActual { get; set; }

        // cuantas respondio bien y mal en la sesion
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

        // registra una respuesta correcta y suma puntos
        public void RegistrarCorrecta(int puntos = 10)
        {
            RespuestasCorrectas++;
            Puntuacion += puntos;
            VerificarSubidaNivel();
        }

        // registra una respuesta incorrecta
        public void RegistrarIncorrecta()
        {
            RespuestasIncorrectas++;
        }

        // sube de nivel cada 5 respuestas correctas
        private void VerificarSubidaNivel()
        {
            if (RespuestasCorrectas > 0 && RespuestasCorrectas % 5 == 0)
                Nivel++;
        }

        // reinicia los contadores para una nueva partida
        public void ReiniciarSesion()
        {
            RespuestasCorrectas = 0;
            RespuestasIncorrectas = 0;
        }

        // devuelve un resumen del jugador para mostrar en pantalla
        public string ObtenerResumen()
        {
            return $"Nivel {Nivel} | Puntaje: {Puntuacion} | Correctas: {RespuestasCorrectas} | Incorrectas: {RespuestasIncorrectas}";
        }
    }
}
