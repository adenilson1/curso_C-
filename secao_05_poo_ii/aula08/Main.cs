using System;

class Principal
{
    static void Main()
    {
        // Felinos Gato1 = new Felinos();
        // Console.WriteLine(Gato1.ex1);
        // Console.WriteLine(Gato1.ex2); // sem acesso quando private
        Console.WriteLine(Felinos.ex1);

    }
}

static class Felinos
{
    static public  int ex1 = 0;
    // private int ex2 = 0;    
    static public int ex2 = 0;


    
}