using Practice.Abstract;

namespace Practice.Concrete;

public class RAM: IRAM
{
    public RAM(string text)
        =>
            Console.WriteLine(text);
}