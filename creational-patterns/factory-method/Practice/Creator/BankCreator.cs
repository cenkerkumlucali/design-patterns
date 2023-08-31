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