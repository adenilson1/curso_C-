using Internal;
using System;


interface ModeloProduto
{
    void Operation();

}

class Produto : ModeloProduto
{
    public void Operation()
    {
        Console.WriteLine("Produto");
    }
}
interface IFabrica
{
    ModeloProduto FactoryMethod();
}

class Fabrica : IFabrica
{
    public ModeloProduto FactoryMethod()
    {
        return new Produto();
    }
    
}



class Principal
{
    static void Main()
    {
        IFabrica fab = new Fabrica();
        ModeloProduto prod = fab.FactoryMethod();
        prod.Operation();
    }
}