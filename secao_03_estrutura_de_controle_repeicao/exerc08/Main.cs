using System;

class Principal
{
    static void Main()
    {
        int[] numeros = new int[50];
        Random rdm = new Random();

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rdm.Next(0,50);
        }

        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}