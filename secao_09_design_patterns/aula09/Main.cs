using Internal;
using System;


interface ICafe
{
    string GetDescription();
    double GetCusto();
}

class CafeSimple : ICafe
{
    public string GetDescription()
    {
        return "Café Simple";
    }

    public double GetCusto()
    {
        return 1;
    }
}


abstract class CafeDecorator : ICafe
{
    protected ICafe _cafe;
    public CafeDecorator(ICafe cafe)
    {
        _cafe = cafe;
    }
    public virtual string GetDescription()
    {
        return _cafe.GetDescription();
    }
    public virtual double GetCusto()
    {
        return _cafe.GetCusto();
    }
}


class LeiteDecorator : CafeDecorator
{
    public LeiteDecorator(ICafe cafe) : base(cafe) { }
    public override string GetDescription()
    {
        return _cafe.GetDescription() + ", Leite";
    }

    public override double GetCusto()
    {
        return _cafe.GetCusto() + 1;
    }
}

class AcucarDecorator : CafeDecorator
{
    public AcucarDecorator(ICafe cafe) : base(cafe) { }
    public override string GetDescription()
    {
        return _cafe.GetDescription() + ", Açucar";
    }

    public override double GetCusto()
    {
        return _cafe.GetCusto()+1.5;
    }
}


class Principal
{
    static void Main()
    {
        ICafe meuCafe = new CafeSimple();
        // meuCafe = new LeiteDecorator(meuCafe);
        meuCafe = new AcucarDecorator(meuCafe);
        Console.WriteLine(meuCafe.GetCusto());
        Console.WriteLine(meuCafe.GetDescription());
    }
}