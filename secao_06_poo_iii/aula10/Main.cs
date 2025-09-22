using System;

class Principal
{
    static void Main()
    {
        Classe2 obj = new Classe2();
        obj.Metodo1();
    }
}

public interface Nome
{
    // Métodos -> sem implementação
    // nada de propriedades

    void Metodo1();
    void Metodo2();
}

class Classe2 : Nome
{
    public void Metodo1()
    {
        Console.WriteLine("Olá Mundo");
    }

    public void Metodo2()
    {
        
    }
}