using Core.Sql;
using Core.Sql.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DB_First_Approach.Controllers;
[ApiController]
[Route("[controller]")]
public class StockExchangeController : ControllerBase
{
    private readonly ILogger<StockExchangeController> _logger;
    private readonly DBFirstContext _dbContext;

    public StockExchangeController(ILogger<StockExchangeController> logger, DBFirstContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet]
    [AllowAnonymous]

    public IEnumerable<StockExchangeEntity> GetAllExchange(int? id)
    {
 
        return _dbContext.StockExchanges.ToList();

    }
}
