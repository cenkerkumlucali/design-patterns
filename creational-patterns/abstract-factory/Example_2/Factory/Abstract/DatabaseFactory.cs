using Example_2.Abstract;

namespace Example_2.Factory.Abstract;

public abstract class DatabaseFactory
{
    public abstract Connection CreateConnection();
    public abstract Command CreateCommand();
}