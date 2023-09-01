using Example.Concrete;
using Example.Factory.Abstract;

namespace Example.Factory.Concrete;

public class MsSqlDatabaseFactory:DatabaseFactory
{
    public override AbstractConnection CreateConnection()
    {
        Connection connection = new();
        connection.ConnectionString = "MSSQL connection string";
        return connection;
    }

    public override AbstractCommand CreateCommand()
    {
        Command command = new();
        return command;
    }
}