internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcreta1 concreta1 = new ClaseConcreta1();
        concreta1.printOut();
        Console.WriteLine(concreta1.prefixValor("ES_"));

        ClaseConcreta1 concreta2 = new ClaseConcreta1();
        concreta1.printOut();
        Console.WriteLine(concreta2.prefixValor("ES_"));

    }
}