using System;

class Principal
{
    //loop de metodos
    static void Main()
    {
        Metodo(5); //inicializaçao
    }

    static void Metodo(int n1)
    {
        if (n1 > 0) // teste logico
        {
            Console.WriteLine("Repetiu " + n1);
            n1--; //decremento
            Metodo(n1);
        }
    }
}