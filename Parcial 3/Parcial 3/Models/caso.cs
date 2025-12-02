using System;

namespace Parcial_3.Models
{
    public class Caso
    {
        public int Id { get; set; }
        public string NumeroCaso { get; set; }
        public string ClienteNombre { get; set; }
        public string Descripcion { get; set; }
        public string AbogadoAsignado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
