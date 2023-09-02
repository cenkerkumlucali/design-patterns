using Builder_Factory_Method_Pattern.Builder.Concrete;
using Builder_Factory_Method_Pattern.Concrete;
using Builder_Factory_Method_Pattern.Creator;
using Builder_Factory_Method_Pattern.Director;

CarDirector director = new();
Car opel = director.Build(BuilderCreator.Create(BuilderType.Opel));
Car mercedes = director.Build(BuilderCreator.Create(BuilderType.Mercedes));
Car bmw = director.Build(BuilderCreator.Create(BuilderType.BMW));


opel.ToString();
Console.WriteLine("******************");
mercedes.ToString();
Console.WriteLine("******************");
bmw.ToString();