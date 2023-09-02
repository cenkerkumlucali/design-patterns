using Practice.Builder.Concrete;
using Practice.Concrete;
using Practice.Director;

CarDirector director = new();
Car opel = director.Build(new OpelBuilder());
Car mercedes = director.Build(new MercedesBuilder());
Car bmw = director.Build(new BMWBuilder());


opel.ToString();
Console.WriteLine("******************");
mercedes.ToString();
Console.WriteLine("******************");
bmw.ToString();
