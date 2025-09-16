internal class Program
{
    private static void Main(string[] args)
    {

        /*
        float a, b;
        */
        float resultado;
        float radio;

        /*
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        b = float.Parse(Console.ReadLine());

        resultado = CalculosMatematicos.operacion(a, b);
        */

        Console.WriteLine("radio");
        radio = float.Parse(Console.ReadLine());
        resultado = CalculosMatematicos.calculoArea(radio);
        Console.WriteLine("El area del circulo es: {0}", resultado);

    }



}
class CalculosMatematicos
{
    public static float operacion(float a, float b)
    {
        return (a + b) * (a - b);
    }


    public static float calculoArea(float radio)
    {
        return 3.14f * radio * radio;
    }
}




