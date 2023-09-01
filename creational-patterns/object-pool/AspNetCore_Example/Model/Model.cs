namespace AspNetCore_Example.Model;

public class Model
{
    public int Count { get; set; }
    public void Write() => Console.WriteLine(Count);

    public Model() => Console.WriteLine("X üretim maliyeti...");

    ~Model() => Console.WriteLine("X imha maliyeti...");
}