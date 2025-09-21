//Classes - > trabalham com o smodificadores da classe: Public , Private ect
// sem definição ela public, sem restrições 
using System;

class Principal
{
    static void Main()
    {
        
    }
}


public class Classe1
{
    // memboros: trabalham com os modificaodres de acesso
    public int n1 = 20; // nao é necessario colocar o public
    // int n2 = 20;

    public void Metodo1()
    {
        Console.WriteLine("Olá, Mundo!");
    }
}