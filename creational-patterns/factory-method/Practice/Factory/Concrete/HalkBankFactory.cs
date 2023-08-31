using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class HalkBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        HalkBank halkBank = new("asd");
        halkBank.Password = "123";
        return halkBank;
    }
}