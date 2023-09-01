using AbstractFactoryMethod.Abstract;

namespace AbstractFactoryMethod.Concrete;

public class RAM: IRAM
{
    public RAM(string text)
        =>
            Console.WriteLine(text);
}