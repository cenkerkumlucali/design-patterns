using Builder_Factory_Method_Pattern.Builder.Abstract;
using Builder_Factory_Method_Pattern.Builder.Concrete;
using Builder_Factory_Method_Pattern.Concrete;

namespace Builder_Factory_Method_Pattern.Creator;

public class BuilderCreator
{
    static public CarBuilder Create(BuilderType type)
    {
        return type switch
        {
            BuilderType.Opel => new OpelBuilder(),
            BuilderType.Mercedes => new MercedesBuilder(),
            BuilderType.BMW => new BMWBuilder()
        };
    }
}