using System;

class Principal
{
    static void Main()
    {
        Classe2 obj = new Classe2();
    }
}

class Classe1
{
    // public int ex;
    public Classe1(int n1) // construtor da classe1
    {
        Console.WriteLine("Construtor da Classe1()");
    }

}

class Classe2 : Classe1 // classe 2 herda da classe1. ela nao vai herda o construtor Classe1().
{
    // vai herda a propriedade ex da classe1.
    static int valor = 10; // deve ser static para passar para outra classe, não public 
    public Classe2() : base(valor)
    {
        Console.WriteLine("Construtor da Classe2()");
    }

}