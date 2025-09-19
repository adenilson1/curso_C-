using System;

class Program
{
    static void Main()
    {
        // metros para centimetros

        Console.WriteLine("Digite um numero em metros: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        double metros_para_centimetros = numero * 100;

        Console.WriteLine(string.Format("O {0} metro(s) é igual a {1} centimetro(s)", numero, metros_para_centimetros));
    }
}