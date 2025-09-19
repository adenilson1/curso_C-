using System;

class Program
{
    static void Main()
    {
        // conversao de moeda
        Console.WriteLine("Qual é cotação do dolar?");
        double valor_dolar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Quanto você quer converter para real?");
        double quantidade_dolar = Convert.ToDouble(Console.ReadLine());

        double converter_dolar_para_real = valor_dolar * quantidade_dolar;
        Console.WriteLine(
            string.Format(
                "$ {0} valem R$ {1}", quantidade_dolar, converter_dolar_para_real
            )
        );
    }
}