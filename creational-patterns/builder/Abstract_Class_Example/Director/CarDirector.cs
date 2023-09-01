using Abstract_Class_Example.Builder.Abstract;
using Abstract_Class_Example.Concrete;

namespace Abstract_Class_Example.Director;

public class CarDirector
{
    public Car Build(CarBuilder builder)
    {
        builder.SetBrand()
            .SetModel()
            .SetKM()
            .SetGear();

        return builder.Car;
    }
}