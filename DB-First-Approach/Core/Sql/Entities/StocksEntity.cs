using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sql.Entities;

public class StocksEntity
{
    public int Id { get; set; }
    public StockExchangeEntity Exchange { get; set; }
    public string Token { get; set; }
    public string ShortName { get; set; }
    public string Series { get; set; }
    public string CompanyName { get; set; }
    public string TickSize { get; set; }
    public int LotSize { get; set; }
    public float IssuePrice { get; set; }
    public int FaceValue { get; set; }
    public string ISINCode { get; set; }
    public float WeeksHigh52 { get; set; }
    public float WeeksLow52 { get; set; }
    public float LifeTimeHigh { get; set; }
    public float LifeTimeLow { get; set; }
    public string ExchangeCode { get; set; }
    public DateTime CreatedDate { get; set; }
}
