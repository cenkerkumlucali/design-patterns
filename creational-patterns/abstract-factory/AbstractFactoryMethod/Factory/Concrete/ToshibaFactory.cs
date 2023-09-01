using AbstractFactoryMethod.Abstract;
using AbstractFactoryMethod.Concrete;
using AbstractFactoryMethod.Factory.Abstract;

namespace AbstractFactoryMethod.Factory.Concrete;

public class ToshibaFactory : IComputerFactory
{
    public ICPU CreateCPU() => new CPU("Toshiba CPU üretildi");

    public IRAM CreateRAM() => new RAM("Toshiba RAM üretildi");

    public IVideoCard CreateVideoCard() => new VideoCard("Toshiba Video Card üretildi");
}