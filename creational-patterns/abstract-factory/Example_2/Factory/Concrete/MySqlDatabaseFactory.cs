using Example_2.Abstract;
using Example_2.Concrete;
using Example_2.Factory.Abstract;

namespace Example_2.Factory.Concrete;

public class MySqlDatabaseFactory : DatabaseFactory
{
    public override Connection CreateConnection()
    {
        MySqlConnection connection = new();
        return connection;
    }

    public override Command CreateCommand()
    {
        MySqlCommand command = new();
        return command;
    }
}