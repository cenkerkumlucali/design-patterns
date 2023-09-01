using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class HalkBankFactory : IBankFactory
{
    public HalkBankFactory() { }
    static HalkBankFactory()
        => _halkBankFactory = new();
    static HalkBankFactory _halkBankFactory;
    static public HalkBankFactory GetInstance => _halkBankFactory;

    public IBank CreateInstance()
    {
        HalkBank halkBank = HalkBank.GetInstance;
        halkBank.Password = "123";
        return halkBank;
    }
}