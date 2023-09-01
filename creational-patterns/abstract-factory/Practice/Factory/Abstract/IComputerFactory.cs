using Practice.Abstract;

namespace Practice.Factory.Abstract;

public interface IComputerFactory
{
    ICPU CreateCPU();
    IRAM CreateRAM();
    IVideoCard CreateVideoCard();
}