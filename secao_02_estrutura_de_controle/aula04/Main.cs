using System;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Digite a sua idade");
        // int idade = Convert.ToInt32(Console.ReadLine());

        // if (idade >= 18)
        // {
        //     Console.WriteLine("Acesso permitido");

        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado");
        // }

        Console.WriteLine("Digita um numero de 0 a 9");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 7 && numero <= 9)
        {
            Console.WriteLine("Parabéns, APROVADO");

        }
        else if (numero > 5 && numero <= 7)
        {
            Console.WriteLine("Você está na média");
        }
        else
        {
            Console.WriteLine("Tente mais uma vez");
        }
    }
}