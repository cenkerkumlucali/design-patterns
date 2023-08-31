using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class VakifBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        VakifBank vakifBank = new(new() { Mail = "gncy@gencayyildiz.com", UserCode = "gncy" }, "123");
        vakifBank.ValidateCredential();
        return vakifBank;
    }
}