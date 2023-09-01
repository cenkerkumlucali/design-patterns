using Practice.Abstract;

namespace Practice.Concrete;

public class CPU : ICPU
{
    public CPU(string text)
        =>
            Console.WriteLine(text);
}