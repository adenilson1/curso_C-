using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite dois numeros");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine(
                string.Format(
                    "{0} > {1} ", numero1, numero2
                )
            );
        } else {
            Console.WriteLine(
                string.Format(
                    "{1} > {0}", numero1, numero2

                )
            );
        }
    }
}