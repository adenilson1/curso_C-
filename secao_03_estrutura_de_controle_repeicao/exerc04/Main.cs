using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite dois numeros inteiros");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero2 > numero1)
        {
            for (int i = 0; i <= (numero2 - numero1); i++)
            {
                Console.Write(numero1 + i + " ");
            }
        }
        else
        {
            for (int i = 0; i <= (numero1 - numero2); i++)
            {
                Console.Write(numero2 + i + " ");
            }
        }
    }


}