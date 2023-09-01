using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

public class ToshibaFactory : IComputerFactory
{
    public ICPU CreateCPU() => new CPU("Toshiba CPU üretildi");

    public IRAM CreateRAM() => new RAM("Toshiba RAM üretildi");

    public IVideoCard CreateVideoCard() => new VideoCard("Toshiba Video Card üretildi");
}