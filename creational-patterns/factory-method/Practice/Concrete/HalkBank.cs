using Practice.Abstract;

namespace Practice.Concrete;

class HalkBank : IBank
{
    string _userCode, _password;
    public HalkBank(string userCode)
    {
        Console.WriteLine($"{nameof(HalkBank)} nesnesi oluşturuldu.");
        _userCode = userCode;
    }

    public string Password { set => _password = value; }

    public void Send(int amount, string accountNumber)
        => Console.WriteLine($"{amount} money sent.");
}