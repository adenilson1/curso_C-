using Internal;
using System;
using System.Collections.Generic;

public class Car
{
    public string motor { get; set; }
    public int rodas { get; set; }
    public string cor { get; set; }


    public override string ToString()
    {
        return "Carro com motor " + motor + ", " + rodas + " rodas e cor: " + cor;
    }


}

public interface ICarBuilder
{
    void SetMotor(string motor);
    void SetRodas(int rodas);
    void SetCor(string color);

    Car GetResult();
}

public class CarBuilder : ICarBuilder
{
    private Car _car = new Car();
    public void SetMotor(string motor)
    {
        _car.motor = motor;
    }

    public void SetRodas(int rodas)
    {
        _car.rodas = rodas;
    }

    public void SetCor(string cor)
    {
        _car.cor = cor;
    }

    public Car GetResult()
    {
        return _car;
    }
}

public class CarDirector
{
    private readonly ICarBuilder _builder;
    public CarDirector(ICarBuilder builder)
    {
        _builder = builder;
    }

    public void SportsCar()
    {
        _builder.SetMotor("V8");
        _builder.SetRodas(4);
        _builder.SetCor("Red");
    }

    public void SUVCar()
    {
        _builder.SetMotor("V6");
        _builder.SetRodas(4);
        _builder.SetCor("Black");
    }
}
class Principal
{
    static void Main()
    {
        ICarBuilder builder = new CarBuilder();
        CarDirector director = new CarDirector(builder);

        director.SportsCar();
        Car sportscar = builder.GetResult();
        Console.WriteLine(sportscar);

        director.SUVCar();
        Car suvcar = builder.GetResult();
        Console.WriteLine(suvcar);
    }
}