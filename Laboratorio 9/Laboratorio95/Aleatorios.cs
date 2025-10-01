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

    // Versión simple: arreglo sin repetidos
    public int[] ArrayAleatorioSinRepetidos(int minValor, int maxValor, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        int indice = 0;

        while (indice < cantidad)
        {
            int candidato = NumeroAleatorio(minValor, maxValor);
            bool repetido = false;

            for (int j = 0; j < indice; j++)
            {
                if (arreglo[j] == candidato)
                {
                    repetido = true;
                    break;
                }
            }

            if (!repetido)
            {
                arreglo[indice] = candidato;
                indice++;
            }
        }

        return arreglo;
    }
}