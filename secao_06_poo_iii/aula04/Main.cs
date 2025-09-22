using System;

class Principal
{
    static void Main()
    {
        // Classe2 obj = new Classe2();
        // obj.Metodo();
;    }
}

// class Classe1
// {
//     public int n1 = 10;
//     private int n2 = 20;
//     protected int n3 = 30;
// }

// class Classe2 : Classe1
// {
//     public void Metodo()
//     {
//         Console.WriteLine(n3);
//     }
// }

// sealed class Classe1
// {

// }
// class Classe2 : Classe1 // nao pode ser herdada da classe1 sealed
// {

// }

class Classe1
{

}

sealed class Classe2 : Classe1 // pode herada da classe1
{
    
}