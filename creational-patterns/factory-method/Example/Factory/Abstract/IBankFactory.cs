using Example.Abstract;

namespace Example.Factory.Abstract;

interface IBankFactory
{
    IBank CreateInstance();
}