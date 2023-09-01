namespace Builder_Factory_Method_Pattern.Concrete;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double KM { get; set; }
    public bool Gear { get; set; }
    public override string ToString()
    {
        Console.WriteLine($"{Brand} marka araba {Model} modelinde {KM} kilometrede {Gear} vites olarak üretilmiştir.");
        return null;
    }
}