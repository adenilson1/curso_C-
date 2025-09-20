using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite 3 numeros");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        double numero2 = Convert.ToDouble(Console.ReadLine());
        double numero3 = Convert.ToDouble(Console.ReadLine());

        if (numero1 >= numero2 && numero1 >= numero3)
        {
            Console.WriteLine("O maior é  " + numero1);
        }
        else if (numero2 >= numero1 && numero2 >= numero3)
        {
            Console.WriteLine("O maior é  " + numero2);
        }
        else
        {
            Console.WriteLine("O maior é  " + numero3);
        }
    }
}