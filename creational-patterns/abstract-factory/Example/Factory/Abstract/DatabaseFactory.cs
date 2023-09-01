using Example.Concrete;

namespace Example.Factory.Abstract;

public abstract class DatabaseFactory
{
    public abstract AbstractConnection CreateConnection();
    public abstract AbstractCommand CreateCommand();
}