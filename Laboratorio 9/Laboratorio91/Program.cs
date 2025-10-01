
float precio = 0;
int metodoPago = 0;
int numeroTarjeta = 0;
Console.WriteLine("Precio de su producto");
while (precio <= 0)
{
    Console.WriteLine("Ingrese un precio valido");
    precio = float.Parse(Console.ReadLine());
}

Console.WriteLine("Metodo de pago");
Console.WriteLine("1. Efectivo");
Console.WriteLine("2. Tarjeta");

metodoPago = int.Parse(Console.ReadLine());
if( metodoPago != 1){
    Console.WriteLine("Ingrese el numero de tarjeta");
    numeroTarjeta = int.Parse(Console.ReadLine());
}
