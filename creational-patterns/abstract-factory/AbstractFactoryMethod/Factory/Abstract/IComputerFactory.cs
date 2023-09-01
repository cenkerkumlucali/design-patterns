using AbstractFactoryMethod.Abstract;

namespace AbstractFactoryMethod.Factory.Abstract;

public interface IComputerFactory
{
    ICPU CreateCPU();
    IRAM CreateRAM();
    IVideoCard CreateVideoCard();
}