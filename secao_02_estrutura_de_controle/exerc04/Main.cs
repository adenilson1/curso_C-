using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite duas notas, minima 0 e maxima 10");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2) / 2;
        if (media == 10)
        {
            Console.WriteLine("Aprovado com Distinção");
        }
        else if (media >= 7 && media < 10)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}