using System.Reflection.Emit;
using System.Data;
using Internal;
using System;
using System.Collections.Generic;


public class Singleton
{
    private static Singleton instance;
    private Singleton() {}

    public static Singleton GetSingleton()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}
class Principal
{
    static void Main()
    {
        Singleton obj1 = Singleton.GetSingleton();
        Singleton obj2 = Singleton.GetSingleton();
        Console.WriteLine(obj1 == obj2);

    }
}