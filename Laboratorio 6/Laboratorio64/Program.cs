class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Acceso negado - no cumples con el criterio requerido.");
        }
        else
        {
            Console.WriteLine("Acceso concedido - cumple con el criterio requerido.");
        }
}
    static void Main(string[] args)
    {
        CheckAge(15);
    }
}