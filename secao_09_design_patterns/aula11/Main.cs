using System.Data;
using Internal;
using System;
using System.Collections.Generic;


interface IFlayweight
{
    void Operation(int ex_state); // estado externo
}

class Implementacao : IFlayweight
{
    private string in_State; // estado interno

    public Implementacao(string in_State)
    {
        this.in_State = in_State;
    }

    public void Operation(int ex_state)
    {
        Console.WriteLine("Interno: " + in_State + " " + "Externo: " + ex_state);
    }
}

class FlyweightFactory
{
    private Dictionary<string, IFlayweight> flyweights = new Dictionary<string, IFlayweight>();

    public IFlayweight GetFlayweight(string key)
    {
        if (!flyweights.ContainsKey(key))
        {
            flyweights[key] = new Implementacao(key);
        }
        return flyweights[key];
    }

    public void ListFlyweights()
    {
        Console.WriteLine(flyweights.Count);
        foreach (var key in flyweights.Keys)
        {
            Console.WriteLine(key);
        }
    }
}
class Principal
{
    static void Main()
    {
        var factory = new FlyweightFactory();

        var flyweight1 = factory.GetFlayweight("A");
        flyweight1.Operation(1);

        var flyweight2 = factory.GetFlayweight("B");
        flyweight2.Operation(2);

        var flyweight3 = factory.GetFlayweight("A");
        flyweight3.Operation(3);

        factory.ListFlyweights();
    }
}