using Abstract_Class_Example.Builder.Abstract;
using Abstract_Class_Example.Concrete;

namespace Abstract_Class_Example.Builder.Concrete;

public class MercedesBuilder : CarBuilder
{

    public override  CarBuilder SetBrand()
    {
        car.Brand = "Mercedes";
        return this;
    }

    public override  CarBuilder SetModel()
    {
        car.Model = "CLA180";
        return this;
    }

    public override  CarBuilder SetKM()
    {
        car.KM = 12050;
        return this;
    }

    public override  CarBuilder SetGear()
    {
        car.Gear = true;
        return this;
    }
}