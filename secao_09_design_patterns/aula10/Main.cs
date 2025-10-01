using System.Data;
using Internal;
using System;


class Luzes
{
    public void Ligar()
    {
        Console.WriteLine("Luzes Ligados");
    }

    public void Desligar()
    {
        Console.WriteLine("Luzes Desligados");
    }
}

class Arcondicionado
{
    public void Ligar()
    {
        Console.WriteLine("Arcodicionado Ligadas");
    }

    public void Desligar()
    {
        Console.WriteLine("Arcondicionado Desligadas");
    }
}

class SistemadeSom
{
    public void Ligar()
    {
        Console.WriteLine("Sistema de som Ligados");
    }

    public void Desligar()
    {
        Console.WriteLine("Sistema de som Desligados");
    }
}

class Facade
{

    private readonly Luzes _luzes;
    private readonly Arcondicionado _arcondicionado;
    private readonly SistemadeSom _sistemadesom;

    public Facade()
    {
        _luzes = new Luzes();
        _arcondicionado = new Arcondicionado();
        _sistemadesom = new SistemadeSom();
    }


    public void LigarTudo()
    {
        _luzes.Ligar();
        _arcondicionado.Ligar();
        _sistemadesom.Ligar();
    }

    public void DesligarTudo()
    {
        _luzes.Desligar();
        _arcondicionado.Desligar();
        _sistemadesom.Desligar();
    }
}
class Principal
{
    static void Main()
    {
        Facade Automacao = new Facade();
        Automacao.LigarTudo();
        Automacao.DesligarTudo();
    }
}