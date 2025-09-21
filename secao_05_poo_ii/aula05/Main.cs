using System;

class Principal
{
    static void Main()
    {
        // Felinos Gato1 = new Felinos("Lucky");
        // Console.WriteLine(Gato1.vida);
        // Console.WriteLine(Gato1.nome);

        Felinos Gato1 = new Felinos("Lucky");
        Console.WriteLine(Gato1.nome);

    }
}

class Felinos
{
    public int vida = 100;
    public string nome;

    public Felinos(string m)
    {
        nome = m;
    }

    ~Felinos()
    {
        Console.WriteLine("Objeto deixou de existir");
        
    }
}
