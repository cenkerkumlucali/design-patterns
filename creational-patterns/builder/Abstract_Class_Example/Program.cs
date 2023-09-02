using Abstract_Class_Example.Builder.Concrete;
using Abstract_Class_Example.Concrete;
using Abstract_Class_Example.Director;

CarDirector director = new();
Car opel = director.Build(new OpelBuilder());
Car mercedes = director.Build(new MercedesBuilder());
Car bmw = director.Build(new BMWBuilder());


opel.ToString();
Console.WriteLine("******************");
mercedes.ToString();
Console.WriteLine("******************");
bmw.ToString();