using System;

class Program
{
    static void Main()
    {
        // Calculo medio
        Console.WriteLine("Entre com as quantidades Minima e Maxima: ");
        int qtd_min = Convert.ToInt32(Console.ReadLine());
        int qtd_max = Convert.ToInt32(Console.ReadLine());

        int estoque_med = (qtd_max - qtd_min) / 2;
        Console.WriteLine(
            string.Format(
                "O estoque medio da peça = {0}", estoque_med
            )
        );

    }
}