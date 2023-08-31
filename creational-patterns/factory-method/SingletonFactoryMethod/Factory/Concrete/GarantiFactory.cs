using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class GarantiFactory : IBankFactory
{
    GarantiFactory() { }
    static GarantiFactory()
        => _garantiFactory = new();
    static GarantiFactory _garantiFactory;
    static public GarantiFactory GetInstance => _garantiFactory;
    public IBank CreateInstance()
    {
        GarantiBank garanti = GarantiBank.GetInstance;
        garanti.ConnectGaranti();
        return garanti;
    }
}