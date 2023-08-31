class GarantiFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        GarantiBank garanti = new("asd", "123");
        garanti.ConnectGaranti();
        return garanti;
    }
}