namespace Example.Concrete;

public class Connection: AbstractConnection
{
    private string _connectionString;
    
    public Connection()
    {
    }
    
    public Connection(string connectionString) => _connectionString = connectionString;
    

    public override string ConnectionString
    {
        get => _connectionString;
        set => _connectionString = value;
    }

    public override ConnectionState State { get; set; }

    public override bool Connect()
    {
        //... işlemler yürütülüyor
        State = ConnectionState.Open;
        return true;
    }

    public override bool Disconnect()
    {
        //... işlemler yürütülüyor
        State = ConnectionState.Close;
        return true;
    }
}