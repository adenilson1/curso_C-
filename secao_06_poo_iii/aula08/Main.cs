using System;

class Principal
{
    static void Main()
    {
        Classe1 obj = new Classe1();
        Classe2 obj2 = new Classe2();

        // São os mesmo metodo, so que rescrito
        obj.Metodo();
        obj2.Metodo();
    }
}

class Classe1
{
    public virtual void Metodo()
    {
        Console.WriteLine("Olá, Mundo");
    }
}

class Classe2 : Classe1
{
    public override void Metodo()
    {
        Console.WriteLine("Outra coisa");
    }
}