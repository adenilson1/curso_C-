using System;

class Principal
{
    static void Main()
    {
        Classe2 obj = new Classe3();
        Classe2 obj1 = new Classe2();
    }
}

class Classe1
{
    public Classe1()
    {
        Console.WriteLine("Construtor da Classe1");
    }

}

class Classe2 : Classe1
{
    public Classe2()
    {
        Console.WriteLine("Construtor da Classe2");
    }
}

class Classe3 : Classe2
{
    public Classe3()
    {
        Console.WriteLine("Construtor da Classe3");
    }
}