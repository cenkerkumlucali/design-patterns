using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace AspNetCore_Example.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    private readonly ObjectPool<Model.Model> _pool;

    public ValuesController(ObjectPool<Model.Model> pool)
    {
        _pool = pool;
    }

    [HttpGet("[action]")]
    public IActionResult Get1()
    {
        var x1 = _pool.Get();
        x1.Count++;
        _pool.Return(x1);
        return Ok(x1.Count);
    }

    [HttpGet("[action]")]
    public IActionResult Get2()
    {
        var x1 = _pool.Get();
        x1.Count++;
        _pool.Return(x1);
        return Ok(x1.Count);
    }
}