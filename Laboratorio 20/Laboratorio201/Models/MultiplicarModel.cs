using System.ComponentModel.DataAnnotations;

namespace TablaMultiplicarApp.Models
{
    public class MultiplicarModel
    {
        [Required(ErrorMessage = "El número es requerido")]
        [Range(1, 1000, ErrorMessage = "El número debe estar entre 1 y 1000")]
        public int Numero { get; set; }

        public int[] Resultados { get; set; }
    }
}