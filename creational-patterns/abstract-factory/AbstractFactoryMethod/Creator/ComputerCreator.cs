using AbstractFactoryMethod.Abstract;
using AbstractFactoryMethod.Concrete;
using AbstractFactoryMethod.Factory.Abstract;
using AbstractFactoryMethod.Factory.Concrete;

namespace AbstractFactoryMethod.Creator;

public class ComputerCreator
{
    private ICPU _cpu;
    private IRAM _ram;
    private IVideoCard _videoCard;


    public Computer CreateComputer(ComputerType type)
    {
        IComputerFactory computerFactory = type switch
        {
            ComputerType.Asus => new AsusFactory(),
            ComputerType.MSI =>  new MSIFactory(),
            ComputerType.Toshiba => new ToshibaFactory()
        };
        _cpu = computerFactory.CreateCPU();
        _ram = computerFactory.CreateRAM();
        _videoCard = computerFactory.CreateVideoCard();
        return new(_cpu as CPU, _ram as RAM, _videoCard as VideoCard);
    }
}