namespace AbstractFactoryMethod.Concrete;

public class Computer
{
    public Computer(CPU? cpu, RAM? ram, VideoCard? videoCard)
    {
        CPU = cpu;
        RAM = ram;
        VideoCard = videoCard;
    }

    public CPU? CPU { get; set; }
    public RAM? RAM { get; set; }
    public VideoCard? VideoCard { get; set; }
}