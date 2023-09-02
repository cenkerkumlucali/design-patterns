using AbstractFactoryMethod.Concrete;
using AbstractFactoryMethod.Creator;
using AbstractFactoryMethod.Factory.Concrete;

ComputerCreator creator = new ComputerCreator();
Computer asus = creator.CreateComputer(ComputerType.Asus);
Computer toshiba = creator.CreateComputer(ComputerType.Toshiba);