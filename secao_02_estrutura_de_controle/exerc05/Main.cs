using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um numero");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (Math.Round(numero) % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }
}