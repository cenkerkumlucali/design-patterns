using Builder_Factory_Method_Pattern.Concrete;

namespace Builder_Factory_Method_Pattern.Builder.Abstract;

public abstract class CarBuilder
{
    protected Car car;
    public Car Car => car;

    public CarBuilder() => car = new();
    public abstract CarBuilder SetBrand();
    public abstract CarBuilder SetModel();
    public abstract CarBuilder SetKM();
    public abstract CarBuilder SetGear();
}