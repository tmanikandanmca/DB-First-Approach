using Core.Sql;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Core.Helper;

namespace DB_First_Approach.Controllers;

[ApiController]
[Route("[controller]")]
public class StocksController : ControllerBase
{
    private readonly ILogger<StockExchangeController> _logger;
    private readonly DBFirstContext _dbContext;
    private readonly IHostingEnvironment _Environment;
    private readonly FileHelper _Helper;

    public StocksController(
        ILogger<StockExchangeController> logger, 
        DBFirstContext dbContext, 
        IHostingEnvironment Environment,
        FileHelper Helper)
	{
        _logger = logger;
        _dbContext = dbContext;
        _Environment= Environment;
        _Helper= Helper;
    }

    [HttpPost]
    [AllowAnonymous]

    public async Task<string> UploadFile(string ScriptName,IFormFile file)
    {
        string LocalPath = _Environment.ContentRootPath;

        if (ScriptName.Contains("NSE"))     
        {
            _Helper.StreamFile(LocalPath, file);
        }
        return ("File Upload ");
    }
}
