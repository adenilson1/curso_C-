using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite 5 numeros");
        int[] vetor = new int[5];

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}