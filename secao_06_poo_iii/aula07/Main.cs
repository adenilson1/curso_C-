using System;

class Principal
{
    static void Main()
    {
        Gato Gato1 = new Gato();
        Cao Cao1 = new Cao();
        Panda Panda1 = new Panda();

        Mamiferos[] vetor = { Cao1, Gato1, Panda1 }; // polimorfismo
    }
}

class Mamiferos { }
class Gato : Mamiferos { } // gato e mamifero
class Cao : Mamiferos { } // cao  e mamifero
class Panda : Mamiferos { } //panda e mamifero
