using Practice.Builder.Abstract;
using Practice.Concrete;

namespace Practice.Builder.Concrete;

public class MercedesBuilder : ICarBuilder
{
    public Car Car { get; }

    public MercedesBuilder()
        => Car = new();

    public ICarBuilder SetBrand()
    {
        Car.Brand = "Mercedes";
        return this;
    }

    public ICarBuilder SetModel()
    {
        Car.Model = "CLA180";
        return this;
    }

    public ICarBuilder SetKM()
    {
        Car.KM = 12050;
        return this;
    }

    public ICarBuilder SetGear()
    {
        Car.Gear = true;
        return this;
    }
}