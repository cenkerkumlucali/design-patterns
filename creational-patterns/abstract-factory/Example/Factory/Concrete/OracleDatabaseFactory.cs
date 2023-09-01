using Example.Concrete;
using Example.Factory.Abstract;

namespace Example.Factory.Concrete;

public class OracleDatabaseFactory:DatabaseFactory
{
    public override AbstractConnection CreateConnection()
    {
        Connection connection = new();
        connection.ConnectionString = "Oracle connection string";
        return connection;
    }

    public override AbstractCommand CreateCommand()
    {
        Command command = new();
        return command;
    }
}