using System;

class Principal
{
    static void Main()
    {
        Metodo1(10, 20, 30, 40, 50);
    }

    static void Metodo1(params int[]nums)
    {
        foreach (int n in nums)
        {
            Console.WriteLine(n);
        }
    }
}