using System;

class Program
{
    static void Main()
    {
        //Operadores logicos
        bool b1 = true;
        bool b2 = false;

        bool exp1 = b1 && b2; //and
        bool exp2 = b1 || b2; // or
        bool exp3 = !b1 && b2; //not
        bool exp4 = b1 && !b2;
        bool exp5 = !b1 || b2;
        bool exp6 = !(b1 && b2);

        Console.WriteLine(exp1);
        Console.WriteLine(exp2);
        Console.WriteLine(exp3);
        Console.WriteLine(exp4);
        Console.WriteLine(exp5);
        Console.WriteLine(exp6);
    }
}