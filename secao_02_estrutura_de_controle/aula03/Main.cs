using System;

class Program
{
    static void Main()
    {
        // int numero1 = 20;

        // if (numero1 > 10) {
        //     Console.WriteLine("Olá, Mundo!");
        // }

        Console.WriteLine("Digite sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você pode entrar na sala");
        }

        Console.WriteLine("Legal !!");
    }
}