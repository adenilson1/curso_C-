using System;

class Principal
{
    static void Main()
    {
        Classe2 obj = new Classe2();
        Console.WriteLine(obj.Soma(20,30, 40));
    }
}


class Classe2
{
    public int Soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Soma(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }
}
