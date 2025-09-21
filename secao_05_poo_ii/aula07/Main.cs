using System;

class Principal
{
    static void Main()
    {
        Classe1 obj1 = new Classe1(); // 
        Classe2 obj2 = obj1.Metodo(); // objeto que chama outro obejto
        Console.WriteLine(obj2.n1);
    }

}

class Classe1
{
    public Classe2 Metodo()
    {
        return new Classe2(); // retorno de um objeto instanciado
    }
}

class Classe2
{
    public int n1 = 20;
    public Classe2()
    {
        Console.WriteLine("Objeto criado");
    }
}