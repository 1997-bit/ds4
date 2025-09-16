internal class Program
{
    private static void Main(string[] args)
    {
        float a, b, resultado;

        Console.WriteLine("Ingrese el primer numero: ");

        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");

        b = float.Parse(Console.ReadLine());

        resultado = CalculosMatematicos.operacion(a, b);
        Console.WriteLine("El resultado de la operacion es: {0}", resultado);
    }



}
class CalculosMatematicos {
    public static float operacion(float a, float b)
    {

       return (a + b) * (a - b);


    }
}




