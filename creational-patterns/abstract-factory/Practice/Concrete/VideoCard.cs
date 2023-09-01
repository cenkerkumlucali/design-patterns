using Practice.Abstract;

namespace Practice.Concrete;

public class VideoCard : IVideoCard
{
    public VideoCard(string text)
        =>
            Console.WriteLine(text);
}