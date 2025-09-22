using System;

class Principal
{
    static void Main()
    {
        Classe2 obj = new Classe2();
        obj.M1();
    }
}

abstract class Classe1
{
    // Não pode ter objetos
    public int n1 = 10;

    abstract public void M1();
}

class Classe2 : Classe1
{
    public override void M1()
    {
        Console.WriteLine("Olá, Mundo");
    }
}