using System.ComponentModel.DataAnnotations;

namespace Laboratorio202.Models
{
    public class MatrizModel
    {
        [Required(ErrorMessage = "La dimensión es requerida")]
        [Range(2, 20, ErrorMessage = "La dimensión debe estar entre 2 y 20")]
        public int Dimension { get; set; }

        public int[,] Matriz { get; set; }
    }
}