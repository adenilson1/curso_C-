using System;

class Program
{
    static void Main()
    {
        //Calculo do peso
        Console.WriteLine("Qual a sua altura? ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double peso_ideal = 72.7 * altura - 58;
        Console.WriteLine(string.Format("Com altura de {0} seu peso ideal é {1}", altura, peso_ideal));
    }
}