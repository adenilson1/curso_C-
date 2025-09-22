using System;

class Principal
{
    static void Main()
    {
        op del1 = new op(Operations.soma); // associação do delegation com o metodo Operations
        op del2 = new op(Operations.subtracao); // associação do delegation com o metodo Operations
        int res = del1(10, 20);
        int res1 = del2(10, 20);
        Console.WriteLine(res);
        Console.WriteLine(res1);

    }
}

delegate int op(int n1, int n2);
class Operations
{
    public static int soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int subtracao(int n1, int n2)
    {
        return n1 - n2;
    }
}