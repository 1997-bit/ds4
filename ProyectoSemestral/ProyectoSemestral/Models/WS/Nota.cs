namespace ProyectoSemestral.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public System.DateTime UltimaModificacion { get; set; }
    }
}