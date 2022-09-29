using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Data;

namespace ShopOnline.Controllers;

[Route("caketypes")]
[ApiController]
public class TypeController : Controller
{
    private readonly CakeFactoryContext _db;

    public TypeController(CakeFactoryContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<CakeTypes>>> GetTypes()
    {
        return (await _db.CakeTypeses.ToListAsync()).OrderByDescending(s => s.Price).ToList();
    }
}