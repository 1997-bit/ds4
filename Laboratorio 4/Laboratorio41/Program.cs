
class Program
{
    static void Main(string[] args)
    {
        int n, x;
        string linea;

        Console.Write("Ingrese el valor de n: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);

        x = 1;

        while (x <= n)
        {
            if (x < n)
                Console.Write(x + ", ");
            else
                Console.Write(x);

            x = x + 1;
        }

        Console.ReadKey();
    }
}
