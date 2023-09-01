using Example_2.Concrete;

namespace Example_2.Abstract;

public abstract class Connection
{
    public abstract bool Connect();
    public abstract bool Disconnect();
    public abstract ConnectionState State { get; set; }
}