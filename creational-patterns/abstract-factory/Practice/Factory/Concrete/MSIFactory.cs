using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Factory.Concrete;

public class MSIFactory : IComputerFactory
{
    public ICPU CreateCPU() => new CPU("MSI CPU üretildi");

    public IRAM CreateRAM() => new RAM("MSI RAM üretildi");

    public IVideoCard CreateVideoCard() => new VideoCard("MSI Video Card üretildi");
}