class IsBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        return new IsBank();
    }
}