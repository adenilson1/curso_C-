using System;

class Program
{
    static void Main()
    {
        // Programa que soma dois numero
        Console.WriteLine("Digite o primeiro numero");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resul = num1 + num2;
        Console.WriteLine("A soma dos dois numero = " + resul);

    }
}
