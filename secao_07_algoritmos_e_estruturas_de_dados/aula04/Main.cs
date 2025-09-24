using System;

class Principal
{
    static void Main()
    {
        int[] lista = { 3,7, 10,34,67,99};
        int id = BuscaBinaria(lista, 7);
        Console.WriteLine(id);
    }

    static int BuscaBinaria(int[] lista, int val)
    {
        int inicio = 0;
        int fim = lista.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (lista[meio] == val)
            {
                return meio;
            }
            else if (lista[meio] < val)
            {
                inicio = meio + 1;
            }
            else // lista[meio] > val
            {
                fim = meio - 1;
            }
        }
        return -1;
    }
}