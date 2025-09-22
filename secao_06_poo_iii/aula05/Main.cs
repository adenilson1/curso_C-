using System;

class Principal
{
    static void Main()
    {
        Classe1 obj = new Classe1();
        obj.Num = 30;
        Console.WriteLine(obj.Num);
    }
}

class Classe1
{
    // private int num = 50;
    public int Num { get; set; }

    // public int Num
    // {
    //     get { return num; } // chama o valor (leitura)
    //     set { num = value; } // escreve ou altera o valor
    // }
}