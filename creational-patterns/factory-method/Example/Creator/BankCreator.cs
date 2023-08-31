using System.Reflection;

class BankCreator
{
    public IBank Create(BankType bankType)
    {
        //IBankFactory _bankFactory = bankType switch
        //{
        //    BankType.Vakifbank => new VakifBankFactory(),
        //    BankType.Halkbank => new HalkBankFactory(),
        //    BankType.Garanti => new GarantiFactory(),
        //    BankType.IsBank => new IsBankFactory()
        //};

        //return _bankFactory.CreateInstance();

        string factory = $"{bankType.ToString()}Factory";
        Type? type = Assembly.GetExecutingAssembly().GetType(factory);
        IBankFactory? bankFactory = Activator.CreateInstance(type) as IBankFactory;
        return bankFactory.CreateInstance();
    }
}