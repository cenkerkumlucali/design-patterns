using Example_2.Concrete;
using Example_2.Factory.Abstract;

namespace Example_2.Creator;

public class DatabaseCreator
{
    public Database Create(DatabaseFactory databaseFactory)
    {
        return new Database
        {
            Command = databaseFactory.CreateCommand(),
            Connection = databaseFactory.CreateConnection()
        };
    }
}