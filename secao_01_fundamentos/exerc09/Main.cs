using System;

class Program
{
    static void Main()
    {
        //multiplos
        Console.WriteLine("Digite dois numeros inteiros");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um numero real");
        double numero_real = Convert.ToDouble(Console.ReadLine());

        double produto_dobro_metade = (2 * numero1) * (numero2 / 2);
        double soma_triplo = (3 * numero1) + (3 * numero_real);
        double elevado_cubo = Math.Pow(numero_real, 3);

        Console.WriteLine(
            string.Format(
                "Produto = {0}, Soma = {1} e Cubo = {2}", produto_dobro_metade,soma_triplo,elevado_cubo
            )
        );

    }
}