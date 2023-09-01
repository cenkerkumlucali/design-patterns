using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

public class AsusFactory : IComputerFactory
{
    public ICPU CreateCPU() => new CPU("Asus CPU üretildi");

    public IRAM CreateRAM() => new RAM("Asus RAM üretildi");

    public IVideoCard CreateVideoCard() => new VideoCard("Asus Video Card üretildi");
}