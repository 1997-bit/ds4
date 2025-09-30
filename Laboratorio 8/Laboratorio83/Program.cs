internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Suma(1.0,2.0));
    }

    static int Suma(int x , int y)
    {
        return x + y;
    }

    static double Suma(double x , double y)
    {
        return x + y;
    }
    
    static long Suma(int x , int y , int z)
    {
        return x + y + z;
    }
}