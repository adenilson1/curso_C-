using System;

class Principal
{
    static void Main()
    {
        for (int num = 0; num < 10; num++)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("------------------------");

        for (int num = 10; num > 0; num--)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("------------------------");

        Console.WriteLine("Tabuada");
        for (int num = 1; num < 10; num++)
        {
            for (int num1 = 0; num1 < 10; num1++)
            {
                Console.WriteLine(num + " * " + num1 + " = " + num * num1);
            }
        }
    }
}