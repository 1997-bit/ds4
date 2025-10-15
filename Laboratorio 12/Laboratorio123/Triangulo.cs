using System;

public class Triangulo
{
    public float A { get; set; }
    public float B { get; set; }
    public float C { get; set; }

    public float CalcularSemiperimetro()
    {
        return (A + B + C) / 2;
    }

    public float CalcularArea()
    {
        float s = CalcularSemiperimetro();
        return (float)Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
}