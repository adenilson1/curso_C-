using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite 10 elementos:");
        int[] vetor = new int[10];

        int j = 0;
        Console.WriteLine();
        while (j < vetor.Length)
        {
            Console.WriteLine("Digite o " + (j + 1) + " elemento");
            vetor[j] = Convert.ToInt32(Console.ReadLine());
            j++;
        }

        Console.WriteLine();
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");

        }
        Console.WriteLine();

        Array.Reverse(vetor);
        foreach (int n in vetor)
        {
            Console.Write(n + " ");
        }
        
    }
}