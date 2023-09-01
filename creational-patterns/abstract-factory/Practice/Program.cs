using Practice.Concrete;
using Practice.Creator;
using Practice.Factory.Concrete;

ComputerCreator creator = new ComputerCreator();
Computer asus = creator.CreateComputer(new AsusFactory());
Computer toshiba = creator.CreateComputer(new ToshibaFactory());
