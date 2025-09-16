internal class Program
{
    private static void Main(string[] args)
    {
        float a, b, resultado;

        Console.WriteLine("Ingrese el lado 1 : ");

        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el lado 2 : ");

        b = float.Parse(Console.ReadLine());

        resultado = CalculosMatematicos.perimetrorectangulo(a, b);
        Console.WriteLine("El perimetro del rectangulo es: {0}", resultado);

    }



}
class CalculosMatematicos
{
    public static float perimetrorectangulo(float a, float b)
    {

        return 2*( a + b);


    }
}




