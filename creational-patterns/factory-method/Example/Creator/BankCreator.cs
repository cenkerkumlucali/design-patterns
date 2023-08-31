using System.Reflection;
using Example.Abstract;
using Example.Concrete;
using Example.Factory.Abstract;
using Example.Factory.Concrete;

namespace Example.Creator;

class BankCreator
{
    public IBank Create(BankType bankType)
    {
        IBankFactory _bankFactory = bankType switch
        {
            BankType.Vakifbank => new VakifBankFactory(),
            BankType.HalkBank => new HalkBankFactory(),
            BankType.Garanti => new GarantiFactory(),
            BankType.IsBank => new IsBankFactory()
        };

        return _bankFactory.CreateInstance();

    }
}