using System;

class Principal
{
    static void Main()
    {
        int num1;
        Metodo1(out num1);
        Console.WriteLine(num1);
    }

    static void Metodo1(out int n1)
    {
        n1 = 20;
        
    }
}