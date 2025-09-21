using System;

class Principal
{
    static void Main()
    {
        // Felinos Gato1 = new Felinos("Lucky");
        // Console.WriteLine(Gato1.vida);
        // Console.WriteLine(Gato1.nome);

        Felinos Gato1 = new Felinos("Lucky", 50);
        Console.WriteLine(Gato1.vida);
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

    public Felinos(string n, int v)
    {
        vida = v;
        nome = n;
    }

}
