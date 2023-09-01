using Abstract_Class_Example.Builder.Abstract;
using Abstract_Class_Example.Concrete;

namespace Abstract_Class_Example.Builder.Concrete;

public class BMWBuilder: CarBuilder
{
    public override  CarBuilder SetBrand()
    {
        car.Brand = "BMW";
        return this;
    }

    public override  CarBuilder SetModel()
    {
        car.Model = "320i";
        return this;
    }

    public override  CarBuilder SetKM()
    {
        car.KM = 36020;
        return this;
    }

    public override  CarBuilder SetGear()
    {
        car.Gear = false;
        return this;
    }
}