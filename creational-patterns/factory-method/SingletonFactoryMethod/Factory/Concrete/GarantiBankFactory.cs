using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class GarantiBankFactory : IBankFactory
{
    public GarantiBankFactory() { }
    static GarantiBankFactory()
        => _garantiFactory = new();
    static GarantiBankFactory _garantiFactory;
    static public GarantiBankFactory GetInstance => _garantiFactory;
    public IBank CreateInstance()
    {
        GarantiBank garanti = GarantiBank.GetInstance;
        garanti.ConnectGaranti();
        return garanti;
    }
}