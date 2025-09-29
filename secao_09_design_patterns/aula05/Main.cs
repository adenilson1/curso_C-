using Internal;
using System.Reflection;
using System;
using System.Collections.Generic;


abstract class Prototype
{
    public abstract Prototype Clone();
}

class ConcretePrototype : Prototype
{
    private string _atrubute;
    public ConcretePrototype(string att)
    {
        this._atrubute = att;
    }

    public override Prototype Clone()
    {
        return new ConcretePrototype(this._atrubute);
    }

    public void SetAtributte(string att)
    {
        this._atrubute = att;
    }

    public void ShowAtribute()
    {
        Console.WriteLine("Atributo: " + _atrubute);
    }
}
class Principal
{
    static void Main()
    {
        ConcretePrototype prototype = new ConcretePrototype("Primeiro");
        ConcretePrototype clone = (ConcretePrototype)prototype.Clone();

        clone.SetAtributte("Modificado");
        prototype.ShowAtribute();
        clone.ShowAtribute();

    }
}