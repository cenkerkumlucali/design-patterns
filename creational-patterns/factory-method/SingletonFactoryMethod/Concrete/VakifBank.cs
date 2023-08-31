using Practice.Abstract;

namespace Practice.Concrete;

class VakifBank : IBank
{
    string _userCode, _email, _password;
    public bool isAuthentcation { get; set; }
    VakifBank(CredentialVakifBank credential, string password)
    {
        Console.WriteLine($"{nameof(VakifBank)} nesnesi oluşturuldu.");
        _userCode = credential.UserCode;
        _email = credential.Mail;
        _password = password;
    }

    static VakifBank()
        => _vakifBank = new(new() { Mail = "gncy@gencayyildiz.com", UserCode = "gncy" }, "123");
    static VakifBank _vakifBank;
    static public VakifBank GetInstance => _vakifBank;

    public void ValidateCredential()
    {
        if (true) //validating
            isAuthentcation = true;
    }

    public void SendMoneyToAccountNumber(int amount, string recipientName, string accountNumber)
        => Console.WriteLine($"{amount} money sent.");
}