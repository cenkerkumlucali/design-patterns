using Practice.Builder.Abstract;
using Practice.Concrete;

namespace Practice.Builder.Concrete;

public class OpelBuilder : ICarBuilder
{
    public Car Car { get; }

    public OpelBuilder()
        => Car = new();

    public ICarBuilder SetBrand()
    {
        Car.Brand = "Opel";
        return this;
    }

    public ICarBuilder SetModel()
    {
        Car.Model = "Astra";
        return this;
    }

    public ICarBuilder SetKM()
    {
        Car.KM = 0;
        return this;
    }

    public ICarBuilder SetGear()
    {
        Car.Gear = true;
        return this;
    }
}