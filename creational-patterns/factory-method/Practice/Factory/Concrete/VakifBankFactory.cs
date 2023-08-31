class VakifBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        VakifBank vakifBank = new(new() { Mail = "gncy@gencayyildiz.com", UserCode = "gncy" }, "123");
        vakifBank.ValidateCredential();
        return vakifBank;
    }
}