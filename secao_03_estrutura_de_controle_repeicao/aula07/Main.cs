using System;

class Principal
{
    static void Main()
    {
        // int[] vetor1 = new int[3] { 20, 30, 40 };

        // // vetor1[0] = 20;
        // // vetor1[1] = 30;
        // // vetor1[2] = 30;
        // // Console.WriteLine(vetor1[2]);

        // for (int i = 0; i < vetor1.Length; i++) // vetor1.Length é o tamanho do vetor
        // {
        //     Console.WriteLine(vetor1[i]);
        // }


        //outra forma


        Console.WriteLine("Digite o numero de elementos do vetor");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] vetor = new int[num];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Digite o elemento " + (i+1));
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine(vetor[i]);
        }





    }
}