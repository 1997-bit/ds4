class Program
{
    static void Main()
    {
        Aleatorio gen = new Aleatorio();

        int numero = gen.NumeroAleatorio(1, 10);
        Console.WriteLine("Numero aleatorio: " + numero);

        int[] arreglo = gen.ArrayAleatorio(3, 7, 1, 10);
        Console.Write("Arregl: ");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();

        ;
    }
}