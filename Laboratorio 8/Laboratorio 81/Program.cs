class Persona {
    public string Nombre;
    public int Edad;
    public string NIF; 

    void Cumpleaños()
    {
               Edad++;
    }

    public Persona(string nombre , int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }

    class Trabajador : Persona
    {
        public int Sueldo;
            public Trabajador(string nombre, int edad, string nif , int sueldo) : base (nombre,edad,nif)
        {
            Sueldo = sueldo;
        }
    }

    public static void Main()
    {
        Trabajador p = new Trabajador("josan", 22, "7758260-Z", 10000);
            Console.WriteLine("Nombre=" + p.Nombre);
            Console.WriteLine("Edad=" + p.Edad);
            Console.WriteLine("NIF=" + p.NIF);
            Console.WriteLine("Sueldo=" + p.Sueldo);
            Console.ReadKey();
    }
}