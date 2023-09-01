using Abstract_Class_Example.Builder.Abstract;
using Abstract_Class_Example.Concrete;

namespace Abstract_Class_Example.Builder.Concrete;

public class OpelBuilder : CarBuilder
{

    public override CarBuilder SetBrand()
    {
        car.Brand = "Opel";
        return this;
    }

    public override  CarBuilder SetModel()
    {
        car.Model = "Astra";
        return this;
    }

    public override  CarBuilder SetKM()
    {
        car.KM = 0;
        return this;
    }

    public override  CarBuilder SetGear()
    {
        car.Gear = true;
        return this;
    }
}