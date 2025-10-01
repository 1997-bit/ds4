class Aleatorio
{
    Random random = new Random();

    public int NumeroAleatorio(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] ArrayAleatorio(int minTam, int maxTam, int minValor, int maxValor)
    {
        int tamaño = NumeroAleatorio(minTam, maxTam);
        int[] arreglo = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
        {
            arreglo[i] = NumeroAleatorio(minValor, maxValor);
        }

        return arreglo;
    }
}