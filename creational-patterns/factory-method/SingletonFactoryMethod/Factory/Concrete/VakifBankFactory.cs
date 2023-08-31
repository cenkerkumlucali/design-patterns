using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class VakifBankFactory : IBankFactory
{
    VakifBankFactory() { }
    static VakifBankFactory()
        => _vakifBankFactory = new();
    static VakifBankFactory _vakifBankFactory;
    static public VakifBankFactory GetInstance => _vakifBankFactory;
    public IBank CreateInstance()
    {
        VakifBank vakifBank = VakifBank.GetInstance;
        vakifBank.ValidateCredential();
        return vakifBank;
    }
}