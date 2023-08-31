using Practice.Abstract;

namespace Practice.Concrete;

class HalkBank : IBank
{
    string _userCode, _password;
    HalkBank(string userCode)
    {
        Console.WriteLine($"{nameof(HalkBank)} nesnesi oluşturuldu.");
        _userCode = userCode;
    }
    static HalkBank()
        => _halkBank = new("asd");
    static HalkBank _halkBank;
    static public HalkBank GetInstance => _halkBank;

    public string Password { set => _password = value; }

    public void Send(int amount, string accountNumber)
        => Console.WriteLine($"{amount} money sent.");
}