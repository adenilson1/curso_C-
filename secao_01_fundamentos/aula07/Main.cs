using System;

class Program
{
    static void Main()
    {
        //Operdares aritmeticos: +, -, *, /
        int num1 = 5;
        int num2 = 10;

        //adição
        int resultado1 = num1 + num2;
        Console.WriteLine(resultado1);

        //subtração
        int resultado2 = num1 - num2;
        Console.WriteLine(resultado2);

        //multiplicação
        int resultado3 = num2 * num1;
        Console.WriteLine(resultado3);

        //divisão
        int resultado4 = num2 / num1;
        Console.WriteLine(resultado4);

        //modulo
        int resultado5 = num2 % num1;
        Console.WriteLine(resultado5);

        //outros
        num1 += 10;
        Console.WriteLine(num1);

        num1 -= 5;
        Console.WriteLine(num1);

        num1 *= 2;
        Console.WriteLine(num1);

        num1 /= 4;
        Console.WriteLine(num1);

        num1 %= 2;
        Console.WriteLine(num1);
    }
}