using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um numero");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero % 1 == 0)
        {
            Console.WriteLine("NUMERO INTEIRO");
        }
        else
        {
            Console.WriteLine("NUMERO DECIMAL");
        }
    }
}