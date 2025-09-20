using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite o numero que se deseja a tabuata");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(numero + " * " + i + " = " + numero*i);
        }
    }
}