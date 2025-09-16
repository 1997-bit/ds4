internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, OP;
        Console.WriteLine("Ingrese el primer numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        b = Convert.ToInt32(Console.ReadLine());

        OP = (a + b) * (a - b);

        Console.WriteLine("La suma de {0} + {1} es: {2}", a, b, OP);
    }
}