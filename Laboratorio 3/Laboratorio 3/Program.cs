internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, suma;
        Console.WriteLine("Iiingrese el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        Console.WriteLine("La suma de {0} + {1} es: {2}", primerNumero, segundoNumero, suma);
    }
}