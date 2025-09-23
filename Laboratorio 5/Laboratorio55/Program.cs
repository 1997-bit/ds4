public class Program
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>
    {
        new Estudiante { Nombre = "Juan", Edad = 20 },
        new Estudiante { Nombre = "María", Edad = 22 },
        new Estudiante { Nombre = "Pedro", Edad = 21 }
    };
        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine("Nombre: {estudiante.Nombre}, Edad:" + estudiante.Edad);
        }

    }
}


