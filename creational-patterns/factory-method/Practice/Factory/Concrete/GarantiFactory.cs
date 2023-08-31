using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class GarantiFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        GarantiBank garanti = new("asd", "123");
        garanti.ConnectGaranti();
        return garanti;
    }
}