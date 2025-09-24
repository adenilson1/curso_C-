using System;

class Principal
{
    static void Main()
    {
        int[] lista = { 3, 6, 3, 4, 6, 8, 33, 5, 7, 3, 2, 4, 6, 11, 0 };
        int id = BuscaSequencial(lista, 67); // quarto valor da lista
        Console.WriteLine(id);
    }

    static int BuscaSequencial(int[] lista, int val)
    {
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i] == val)
            {
                return i;
            }
        }
        return -1;
    }
}
