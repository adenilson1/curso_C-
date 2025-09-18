using System;

class Program
{
    static void Main()
    {
        // Métodos de Conversão
        // Convert.ToString();
        // Convert.ToDouble();
        // Convert.ToInt32();

        // string t1 = "3";
        // int num1 = Convert.ToInt32(t1);
        // Console.WriteLine(num1);

        // Console.WriteLine("Digite um numero inteiro");
        // string numero = Console.ReadLine();
        // int num = Convert.ToInt32(numero);
        // Console.WriteLine("Você digitou:" + numero);

        Console.WriteLine("Digite o primeiro numero inteiro");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero inteiro");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("resultado: " + (num1 + num2));

        
    }
}