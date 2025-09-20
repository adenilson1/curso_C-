using System;

class Principal
{
    static void Main()
    {
        int[] vetor = { 10, 20, 30 };

        int posicao = Array.BinarySearch(vetor, 20);
        //procura a posicao do elemento no vetor
        Console.WriteLine(posicao);

        int value = Convert.ToInt32(vetor.GetValue(1));
        //pega o valor da posicao 1
        Console.WriteLine(value);

        int menor_indice = vetor.GetLowerBound(0);
        // pega o menor indice  do array
        Console.WriteLine(menor_indice);

        int maior_indice = vetor.GetUpperBound(0);
        //PEGA O MAIOR INDICE DO ARRAY
        Console.WriteLine(maior_indice);

        foreach (int n in vetor)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        
        Array.Reverse(vetor);
        //inverte a ordem do vetor
        foreach (int n in vetor)

        {
            Console.Write(n + " ");

        }


    }
}