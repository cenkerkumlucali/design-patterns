using Practice.Concrete;

namespace Practice.Builder.Abstract;

public interface ICarBuilder
{
    Car Car { get;}
    ICarBuilder SetBrand();
    ICarBuilder SetModel();
    ICarBuilder SetKM();
    ICarBuilder SetGear();
}