using System;

class Principal
{
    static void Main()
    {
        int n1 = 20;
        double n2 = 20.0;
        string n3 = "20";

        Metodo(n3);

    }

    public static void Metodo<Qualquer>(Qualquer res) // generic - qualquer dado funcionaria
    {
        Console.WriteLine(res);
    }
}