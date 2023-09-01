using AbstractFactoryMethod.Abstract;
using AbstractFactoryMethod.Concrete;
using AbstractFactoryMethod.Factory.Abstract;

namespace AbstractFactoryMethod.Factory.Concrete;

public class MSIFactory : IComputerFactory
{
    public ICPU CreateCPU() => new CPU("MSI CPU üretildi");

    public IRAM CreateRAM() => new RAM("MSI RAM üretildi");

    public IVideoCard CreateVideoCard() => new VideoCard("MSI Video Card üretildi");
}