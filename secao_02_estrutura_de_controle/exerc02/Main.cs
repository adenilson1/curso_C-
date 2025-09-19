using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um numero");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0) { Console.WriteLine("POSITIVO"); }
        else if (numero < 0) { Console.WriteLine("NEGATIVO"); }
        else{ Console.WriteLine("zero"); }
    }
}