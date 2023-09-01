using Example.Concrete;
using Example.Factory.Abstract;

namespace Example.Creator;

public class DatabaseCreator
{
    private AbstractConnection _connection;
    private AbstractCommand _command;

    public Database Create(DatabaseFactory databaseFactory)
    {
        _connection = databaseFactory.CreateConnection();
        _command = databaseFactory.CreateCommand();
        return new Database(
            (DatabaseType)Enum.Parse(typeof(DatabaseType), databaseFactory.GetType().Name.Replace("DatabaseFactory", "")),
            _connection as Connection, _command as Command);
    }
}