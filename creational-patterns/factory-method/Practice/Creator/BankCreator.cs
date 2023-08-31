using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;
using Practice.Factory.Concrete;

namespace Practice.Creator;

class BankCreator
{
    public IBank Create(BankType bankType)
    {
        IBankFactory _bankFactory = bankType switch
        {
            BankType.Vakifbank => new VakifBankFactory(),
            BankType.Halkbank => new HalkBankFactory(),
            BankType.Garanti => new GarantiFactory()
        };

        return _bankFactory.CreateInstance();
    }
}