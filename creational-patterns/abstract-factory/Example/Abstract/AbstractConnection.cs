namespace Example.Concrete;

public abstract class AbstractConnection
{
    public abstract string ConnectionString { get; set; }
    public abstract ConnectionState State { get; set; }
    public abstract bool Connect();
    public abstract bool Disconnect();

}