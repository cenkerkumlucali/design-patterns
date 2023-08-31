using Example.Abstract;
using Example.Concrete;
using Example.Factory.Abstract;

namespace Example.Factory.Concrete;

class IsBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        return new IsBank();
    }
}