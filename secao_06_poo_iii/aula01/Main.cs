using System;

class Principal
{
    static void Main()
    {
        Felinos Gato = new Felinos();
        // Console.WriteLine(Gato.vida);
        Gato.Ataque();
    }
}

class Animais // classe base
{
    public int vida = 100;
    public string especie;

    public void Ataque()
    {
        Console.WriteLine("Ataque");
    }
}

class Felinos : Animais // classe derivada - Felinos herda da classe Animal
{
    // pussui vida e especie.
    public int sla; //propriedade exclusiva da classe Felinos, ou seja, nao tem na classe base Animais.
}