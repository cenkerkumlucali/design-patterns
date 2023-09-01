using AbstractFactoryMethod.Abstract;
using AbstractFactoryMethod.Concrete;
using AbstractFactoryMethod.Factory.Abstract;

namespace AbstractFactoryMethod.Factory.Concrete;

public class AsusFactory : IComputerFactory
{
    public ICPU CreateCPU() => new CPU("Asus CPU üretildi");

    public IRAM CreateRAM() => new RAM("Asus RAM üretildi");

    public IVideoCard CreateVideoCard() => new VideoCard("Asus Video Card üretildi");
}