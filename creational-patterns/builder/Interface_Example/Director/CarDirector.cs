using Practice.Builder.Abstract;
using Practice.Concrete;

namespace Practice.Director;

public class CarDirector
{
    public Car Build(ICarBuilder builder)
    {
        builder.SetBrand()
            .SetModel()
            .SetKM()
            .SetGear();

        return builder.Car;
    }
}