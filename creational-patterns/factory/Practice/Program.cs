using Practice.Concrete;
using Practice.Creator;

while (true)
{
    for (int i = 0; i < 100; i++)
    {
        try
        {
            A? a = ProductCreator.GetInstance(ProductType.A) as A;
            a.Run();

            B? b = ProductCreator.GetInstance(ProductType.B) as B;
            b.Run();


        }
        catch (Exception ex)
        {

            throw;
        }
    }
}

#region Abstract Product

#endregion
#region Concrete Products

#endregion

#region Creator

#endregion