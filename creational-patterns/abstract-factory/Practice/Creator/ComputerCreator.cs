using Practice.Abstract;
using Practice.Concrete;
using Practice.Factory.Abstract;

namespace Practice.Creator;

public class ComputerCreator
{
    private ICPU _cpu;
    private IRAM _ram;
    private IVideoCard _videoCard;


    public Computer CreateComputer(IComputerFactory computerFactory)
    {
        _cpu = computerFactory.CreateCPU();
        _ram = computerFactory.CreateRAM();
        _videoCard = computerFactory.CreateVideoCard();
        return new(_cpu as CPU, _ram as RAM, _videoCard as VideoCard);
    }
}