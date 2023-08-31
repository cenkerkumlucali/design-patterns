class HalkBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        HalkBank halkBank = new("asd");
        halkBank.Password = "123";
        return halkBank;
    }
}