using System;

class Principal
{
    static void Main()
    {
        Felinos Gato1 = new Felinos("Lucky");
        Console.WriteLine(Gato1.vida);
        Console.WriteLine(Gato1.nome);
    }
}

class Felinos
{
    public int vida;
    public string nome;

    public Felinos(string n) // metodo construtor, eles nunca tem retorno
    {
        vida = 100;
        nome = n;
    }
}