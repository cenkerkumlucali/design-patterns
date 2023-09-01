using Builder_Factory_Method_Pattern.Builder.Abstract;
using Builder_Factory_Method_Pattern.Concrete;

namespace Builder_Factory_Method_Pattern.Director;

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