using Example.Abstract;
using Example.Concrete;
using Example.Factory.Abstract;

namespace Example.Factory.Concrete;

class HalkBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        HalkBank halkBank = new("asd");
        halkBank.Password = "123";
        return halkBank;
    }
}