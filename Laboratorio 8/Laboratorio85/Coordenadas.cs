public partial class Coordenadas
{
    private int x;
    private int y;

    public Coordenadas(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}

public partial class Coordenadas
{
    public void VerCoodenadas()
    {
        Console.WriteLine("Coodenadas: {0},{1}", x, y);
    }
}