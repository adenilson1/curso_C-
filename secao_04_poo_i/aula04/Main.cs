using System;

class Principal
{
    static void Main()
    {
        int num1 = 20;
        Somar(ref num1);
        Console.WriteLine(num1);

    }

    static void Somar(ref int n1)
    {
        n1 = n1 + 1;
    }
}
