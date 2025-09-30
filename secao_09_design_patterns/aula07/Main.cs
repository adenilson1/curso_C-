using Internal;
using System;


interface I_Implementor
{
    string Operation();
}

class ImplementorA : I_Implementor
{
    public string Operation()
    {
        return "Imprementor_A";
    }
}

class ImplementorB : I_Implementor
{
    public string Operation()
    {
        return "Implementor_B";
    }
}

class Abstraction
{
    protected I_Implementor _Implementor;

    public Abstraction(I_Implementor implementor)
    {
        _Implementor = implementor;
    }

    public virtual string Op()
    {
        return _Implementor.Operation();
    }
}

class Adicional : Abstraction
{
    public Adicional(I_Implementor implementor) : base(implementor) { }
    //chamado de construtor base | Proposito: Inicilizar a instancia
    public override string Op() // conteudo Adicional a classe
    {
        return "Adicional: " + base.Op();
    }
}


class Principal
{
    static void Main()
    {
        I_Implementor implementorA = new ImplementorA();
        Abstraction absA = new Adicional(implementorA);
        Console.WriteLine(absA.Op());
        I_Implementor implementorB = new ImplementorB();
        Abstraction absB = new Adicional(implementorB);
        Console.WriteLine(absB.Op());
    }
}