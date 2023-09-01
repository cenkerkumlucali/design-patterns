using Example_2.Abstract;
using Example_2.Concrete;
using Example_2.Factory.Abstract;

namespace Example_2.Factory.Concrete;

public class MsSqlDatabaseFactory:DatabaseFactory
{
    public override Connection CreateConnection()
    {
        MsSqlConnection connection = new();
        return connection;
    }

    public override Command CreateCommand()
    {
        MsSqlCommand command = new();
        return command;
    }
}