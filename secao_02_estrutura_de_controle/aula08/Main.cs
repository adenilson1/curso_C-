using System;

class Program
{
    static void Main()
    {
        // Estruturas switch - case

        Console.WriteLine("Escolha uma opção: ");
        Console.WriteLine("[1] - Opção 1 ");
        Console.WriteLine("[2] - Opção 2 ");
        Console.WriteLine("[3] - Opção 3 ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1: Console.WriteLine("Você selecionou a primeira opção"); break;
            case 2: Console.WriteLine("Você selecionou a segunda opção"); break;
            case 3: Console.WriteLine("Você selecionou a terceira opção"); break;
            default: Console.WriteLine("Isso é uma opção"); break;
        }


        
    }
}