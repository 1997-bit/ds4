internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "Jhon doe";
        Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

        CuentaBancaria cta = new CuentaBancaria();
        cta.Saldo = 100;
        Console.WriteLine($"Saldo de la cuenta: {cta.Saldo}");

        Cobertura c = new Cobertura(5);
        Console.WriteLine($"Cobertura por defecto: {c.Radio}");
    }
}