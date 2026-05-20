using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaEducativa.Clases
{
    public class Pregunta
    {
        public int Id { get; set; }
        public int IdModulo { get; set; }

        // Enunciados
        public string PreguntaEs { get; set; } = null!;
        public string PreguntaEn { get; set; } = null!;

        // Español
        public string OpcionAEs { get; set; } = null!;
        public string OpcionBEs { get; set; } = null!;
        public string OpcionCEs { get; set; } = null!;
        public string OpcionDEs { get; set; } = null!;

        // Ingles
        public string OpcionAEn { get; set; } = null!;
        public string OpcionBEn { get; set; } = null!;
        public string OpcionCEn { get; set; } = null!;
        public string OpcionDEn { get; set; } = null!;

        // Respuesta correcta
        public string LetraCorrecta { get; set; } = null!;
    }
}
