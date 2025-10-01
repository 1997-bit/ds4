
float[] lado = new float[3];
for (int a = 1; a <= 3; a++)
{
    Console.WriteLine("Escriba el lado " + (a));
    lado[a-1] = float.Parse(Console.ReadLine());

}
if (lado[0] == lado[1] && lado[1] == lado[2])
{
    Console.WriteLine("El triangulo es equilatero");
}
else if (lado[0] == lado[1] || lado[1] == lado[2] || lado[0] == lado[2])
{
    Console.WriteLine("El triangulo es isosceles");
}
else
{
    Console.WriteLine("El triangulo es escaleno");
}


