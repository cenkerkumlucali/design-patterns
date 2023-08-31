using Practice.Abstract;

namespace Practice.Concrete;

class GarantiBank : IBank
{
    string _userCode, _password;
    GarantiBank(string userCode, string password)
    {
        Console.WriteLine($"{nameof(GarantiBank)} nesnesi oluşturuldu.");
        _userCode = userCode;
        _password = password;
    }
    static GarantiBank()
        => _garantiBank = new("asd", "123");
    static GarantiBank _garantiBank;
    static public GarantiBank GetInstance => _garantiBank;

    public void ConnectGaranti()
        => Console.WriteLine($"{nameof(GarantiBank)} - Connected.");
    public void SendMoney(int amount)
        => Console.WriteLine($"{amount} money sent.");
}