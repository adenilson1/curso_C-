using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("CONVERSÃO DE MOEDA");
        Console.Write("Qual a contação do dolar? ");
        double dolar = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantidade de reais que deseja converter? ");
        double qta_real = Convert.ToDouble(Console.ReadLine());

        double conversor_real_dola = qta_real / dolar;
        Console.WriteLine("Resultado $" + conversor_real_dola);

    }
}