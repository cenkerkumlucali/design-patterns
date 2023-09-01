using System.Reflection;
using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

class BankCreator
{
    public IBank Create(BankType bankType)
    {
        // IBankFactory _bankFactory = bankType switch
        // {
        //     BankType.Vakifbank => VakifBankFactory.GetInstance,
        //     BankType.Halkbank => HalkBankFactory.GetInstance,
        //     BankType.Garanti => GarantiFactory.GetInstance
        // };
        //
        // return _bankFactory.CreateInstance();
        //

        string factory = $"Practice.Factory.Concrete.{bankType.ToString()}Factory";
        Type? type = Assembly.GetExecutingAssembly().GetType(factory);
        IBankFactory? bankFactory = Activator.CreateInstance(type) as IBankFactory;
        return bankFactory.CreateInstance();
    }
}