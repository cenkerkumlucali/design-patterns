using Example_2.Abstract;

namespace Example_2.Concrete;

public class MySqlCommand : Command
{
    public override void Execute(string query)
    {
        Console.WriteLine(query);
    }
}