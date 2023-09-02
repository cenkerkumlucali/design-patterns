using System.Collections.Concurrent;


ObjectPool<X> pools = ObjectPool<X>.GetInstance;
var t1 = Task.Run((() =>
{
    while (true)
    {
        var x = pools.Get((() => new X()));
        if (x != null)
        {
            x.Count++;
            x.Write();
            pools.Return(x);
        } 

    }
}));
var t2 = Task.Run((() =>
{
    while (true)
    {
        var x = pools.Get((() => new X()));
        if (x != null)
        {
            x.Count++;
            x.Write();
            pools.Return(x);
        } 
    }
}));
Task.WhenAll(t1, t2);

class X
{
    public int Count { get; set; }
    public void Write() => Console.WriteLine(Count);

    public X() => Console.WriteLine("X üretim maliyeti...");

    ~X() => Console.WriteLine("X imha maliyeti...");
}


// ConcurrentBag
// Asenkron süreçlerde kullanılan Thread Safe bir koleksiyondur.
// Tüm thread'ler için bu koleksiyon nesnesinden bir model oluşturulmakta ve her bir iş parçacığı kendisine ait model üzerimnden çalışmaktadır. Böylece çakışma söz konusu olmamaktadır.
// Her bir thread için, eklenen en sonunca eleman elde edilir. Dolayısıyla herhangi bir threadde eleman eklenmediği durumlarda en sonuncu eleman istenildiği taktirde diğer threadler tarafından son eleman olarak eklenenlerden biri rastgele alınacak ve geri gönderilecektir.
class ObjectPool<T> where T : class
{

    // Pool
    private readonly ConcurrentBag<T> _instances;

    public ConcurrentBag<T> Instance => _instances;
    private readonly List<string> _types = new();

    ObjectPool()
    {
        _instances = new();
    }

    private static ObjectPool<T> _objectPool;
    static ObjectPool() => _objectPool = new ObjectPool<T>();
    public static  ObjectPool<T> GetInstance => _objectPool;
    private static object _lock = new();

    public T Get(Func<T>? objectGenerator = null)
    {
        //Havuzdan generic parametrede bildirilen türdeki nesneyi geri döndürmek.
        
        
        lock (_lock)
        {
            var state = _instances.TryTake(out T instance);
            if (!state && _types.Any(c=>c == nameof(T)))
            {
                T generatedInstance = objectGenerator();
                _types.Add(nameof(T));
                return generatedInstance;
            }

            return instance;
        }
    }

    public void Return(T instance)
    {
        //Havuzdan ödünç alınan nesneyi geri iade etmek.
        _instances.Add(instance);
    }
}