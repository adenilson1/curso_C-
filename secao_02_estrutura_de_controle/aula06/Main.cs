using System;

class Program
{
    static void Main()
    {
        //GOTO
        inicio:
        Console.WriteLine("Digite um numero de 0 - 10");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0 && numero <= 10)
        {
            Console.WriteLine("Valor entregue");
        }
        else
        {
            Console.WriteLine("Valor inválido");
            goto inicio;
        }
    }
}