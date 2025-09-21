using System;

class Principal
{
    static void Main()
    {
        Felinos Gato1 = new Felinos(); // criação de objeto
        Felinos Gato2 = new Felinos();

        Gato1.Damage(20);
        Console.WriteLine(Gato1.vida);
        Console.WriteLine(Gato2.vida);

        


        // Gato1.Ataque();
        // // Console.WriteLine(Gato1.vida);
        // // Gato1.vida = Gato1.vida - 10;
        // // Console.WriteLine(Gato1.vida);
        // // Console.WriteLine(Gato2.vida);




    }
}

public class Felinos
{
    public int vida = 100;

    public void Ataque()
    {
        Console.WriteLine("Ataque");
    }

    public void Damage(int dano)
    {
        vida = vida - dano;
    }
}