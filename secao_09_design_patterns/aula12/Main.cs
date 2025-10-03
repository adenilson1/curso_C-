using Internal;
using System;


interface IObjetivo
{
    void Request();
}

class ObjetivoReal : IObjetivo
{
    public ObjetivoReal()//operação cara
    {
        Console.WriteLine("Operação (Conexão ao Banco)");
    }

    public void Request()
    {
        Console.WriteLine("ObjetivoReal: Hnadle Request");
    }
}

class Proxy : IObjetivo
{
    private ObjetivoReal _objetivoReal;
    public void Request()
    {
        if (_objetivoReal == null)
        {
            _objetivoReal = new ObjetivoReal();
        }
        _objetivoReal.Request();
    }
}
class Principal
{
    static void Main()
    {
        IObjetivo proxy = new Proxy();
        proxy.Request();
        proxy.Request();
    }
}