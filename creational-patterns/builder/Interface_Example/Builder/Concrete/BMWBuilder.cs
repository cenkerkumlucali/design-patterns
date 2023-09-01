using Practice.Builder.Abstract;
using Practice.Concrete;

namespace Practice.Builder.Concrete;

public class BMWBuilder: ICarBuilder
{
    public Car Car { get;}

    public BMWBuilder()
        => Car = new();

    public ICarBuilder SetBrand()
    {
        Car.Brand = "BMW";
        return this;
    }

    public ICarBuilder SetModel()
    {
        Car.Model = "320i";
        return this;
    }

    public ICarBuilder SetKM()
    {
        Car.KM = 36020;
        return this;
    }

    public ICarBuilder SetGear()
    {
        Car.Gear = false;
        return this;
    }
}