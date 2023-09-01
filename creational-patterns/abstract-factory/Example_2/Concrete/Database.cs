using Example_2.Abstract;

namespace Example_2.Concrete;

public class Database
{
    public Connection Connection { get; set; }
    public Command Command { get; set; }
}