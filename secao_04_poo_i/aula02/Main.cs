using System;

class Principal
{
    static void Main()
    {
        Soma(1, 2);
        Subtracao(1, 2);
    }

    static void Soma(int n1, int n2)
    {
        Console.WriteLine(n1 + " + " + n2 + " = " + (n1 + n2));
    }

    static void Subtracao(int n1, int n2)
    {
        Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
    }

}