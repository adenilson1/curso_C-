using System;

class Principal
{
    static void Main()
    {
        //matriz

        int[,] matriz1 = new int[3, 3]; // tres linhas e tres collunas

        // matriz1[0, 0] = 15; // na matriz na posição (0,0) o valor é 15
        // matriz1[0, 1] = 30; // na matriz na posição (0,1) o valor é 30
        // matriz1[0, 2] = 60; // na matriz na posição (0,2) o valor é 60

        matriz1[0, 0] = 15; matriz1[0, 1] = 30; matriz1[0, 2] = 60;
        matriz1[1, 0] = 21; matriz1[1, 1] = 45; matriz1[1, 2] = 2;
        matriz1[2, 0] = 10; matriz1[2, 1] = 43; matriz1[2, 2] = 80;


        // Console.WriteLine(matriz1[0, 2]);

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz1[i, j] + " ");
            }
            Console.WriteLine();
        }

    
    }
}