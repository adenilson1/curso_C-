using System;

class Principal
{
    static void Main()
    {
        Felinos Gato = new Felinos("Lucky", 100);
        Console.WriteLine(Gato.nome);
        Console.WriteLine(Gato.vida);
        {
            
        }
    }
}

class Felinos
{
    public int vida;
    public string nome;

    public Felinos(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
        
    }
}