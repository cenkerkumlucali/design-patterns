using Example.Abstract;
using Example.Concrete;
using Example.Factory.Abstract;

namespace Example.Factory.Concrete;

class GarantiFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        GarantiBank garanti = new("asd", "123");
        garanti.ConnectGaranti();
        return garanti;
    }
}