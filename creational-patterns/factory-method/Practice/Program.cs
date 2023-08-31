//GarantiBank garantiBank = new("asd", "123");
//garantiBank.ConnectGaranti();


//VakifBank vakifBank = new(new() { UserCode = "gncy", Mail = "gncy@gencayyildiz.com" }, "123");
//bool result = vakifBank.ValidateCredential();
//if (result)
//{
//    //...
//}

//HalkBank halkBank = new("gncy");
//halkBank.Password = "123";

using Practice.Concrete;
using Practice.Creator;

BankCreator bankCreator = new();
GarantiBank? garanti = bankCreator.Create(BankType.Garanti) as GarantiBank;
HalkBank? halkBank = bankCreator.Create(BankType.Halkbank) as HalkBank;
VakifBank? vakifbank = bankCreator.Create(BankType.Vakifbank) as VakifBank;

GarantiBank? garanti2 = bankCreator.Create(BankType.Garanti) as GarantiBank;
HalkBank? halkBank2 = bankCreator.Create(BankType.Halkbank) as HalkBank;
VakifBank? vakifbank2 = bankCreator.Create(BankType.Vakifbank) as VakifBank;

GarantiBank? garanti3 = bankCreator.Create(BankType.Garanti) as GarantiBank;
HalkBank? halkBank3 = bankCreator.Create(BankType.Halkbank) as HalkBank;
VakifBank? vakifbank3 = bankCreator.Create(BankType.Vakifbank) as VakifBank;



#region Abstract Product

#endregion

#region Concrete Products

#endregion

#region Abstract Factory

#endregion
#region Concrete Factories

#endregion

#region Creator

#endregion