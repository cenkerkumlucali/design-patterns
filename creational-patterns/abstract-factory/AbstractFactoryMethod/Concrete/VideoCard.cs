using AbstractFactoryMethod.Abstract;

namespace AbstractFactoryMethod.Concrete;

public class VideoCard : IVideoCard
{
    public VideoCard(string text)
        =>
            Console.WriteLine(text);
}