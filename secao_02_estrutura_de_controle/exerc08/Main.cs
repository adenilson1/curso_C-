using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um ano");
        int ano = Convert.ToInt32(Console.ReadLine());

        if (ano % 4 == 0 || ano % 400 == 0)
        {
            Console.WriteLine("ANO BISSEXTO");
        }
        else
        {
            Console.WriteLine("NÃO É BISSEXTO");
        }
    }
}