using System;

class Program
{
    static void Main()
    {
        //area do circulo
        const double pi = 3.141592;
        Console.WriteLine("Qual o valor do raio do circulo? ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double area_circulo = Math.Round(pi * Math.Pow(raio, 2));
        Console.WriteLine(string.Format("Com o raio de {0}m, a area é de {1}m²", raio, area_circulo));
    }
}