using System;

class Program
{
    static void Main()
    {
        // Leitura Sequencial
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Qualquer coisa!");

        //simulado erro
        // Console.WriteLine(num);
        // int num = 20;

        //outro erro. mesma variavel, ou seja variavel ja declarada nao pode ser usada no mesmo ambiente
        int num = 20;
        Console.WriteLine(num);
        int num = 30;
        Console.WriteLine(num);

    }
}