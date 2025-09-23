class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Diguite el numero deciado");

        try
        {
            num = Int16.Parse(Console.ReadLine());
        } catch (FormatException ex)
        {
            Console.WriteLine("no ha introducido un digito valido");
            num = -1;
        } catch (OverflowException ex)
        {
            Console.WriteLine("el numero es demasiado grande o demasiado pequeño");
            num = -1;
        }
        Console.WriteLine(num);

    }
}
