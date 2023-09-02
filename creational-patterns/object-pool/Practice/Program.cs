using System.Collections.Concurrent;


ObjectPool<X> pools = new ObjectPool<X>();
X x1 = pools.Get(() => new X());
x1.Count++;
pools.Return(x1);
X x2 = pools.Get(() => new X());
x2.Count++;
pools.Return(x2);
X x3 = pools.Get(() => new X());
x2.Count++;
pools.Return(x3);

class X
{
    public int Count { get; set; }
    public void Write() => Console.WriteLine(Count);

    public X() => Console.WriteLine("X üretim maliyeti...");

    ~X() => Console.WriteLine("X imha maliyeti...");
}

class ObjectPool<T> where T : class
{
    // Pool
    private readonly ConcurrentBag<T> _instances;

    public ConcurrentBag<T> Instance => _instances;

    public ObjectPool()
    {
        _instances = new();
    }

    public T Get(Func<T>? objectGenerator = null)
    {
        //Havuzdan generic parametrede bildirilen türdeki nesneyi geri döndürmek.
        return _instances.TryTake(out T instance) ? instance : objectGenerator();
    }

    public void Return(T instance)
    {
        //Havuzdan ödünç alınan nesneyi geri iade etmek.
        _instances.Add(instance);
    }
}