namespace Example.Concrete;

public class Database
{
    public DatabaseType Type { get; set; }
    public Connection Connection { get; set; }
    public Command Command { get; set; }
    
    public Database()
    {
        
    }

    public Database(DatabaseType type, Connection connection, Command command)
    {
        Type = type;
        Connection = connection;
        Command = command;
    }
}