using AbstractFactoryMethod.Abstract;

namespace AbstractFactoryMethod.Concrete;

public class CPU : ICPU
{
    public CPU(string text)
        =>
            Console.WriteLine(text);
}