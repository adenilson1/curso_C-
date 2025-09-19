using System;

class Program
{
    static void Main()
    {
        //Loja de tintas
        Console.WriteLine("Quantos metros quadrados são pintados?");
        double tamanho_quadrado = Convert.ToDouble(Console.ReadLine());

        int quantidade_latas = (int)Math.Round((tamanho_quadrado / 3) / 18);
        double preco_lata_total = quantidade_latas * 80.0;

        Console.WriteLine(
            string.Format(
                "Para {0}m² a quantidade de latas de tintas é de {1}, custando R$ {2}",
                tamanho_quadrado, quantidade_latas, preco_lata_total
            )
        );
    }
}