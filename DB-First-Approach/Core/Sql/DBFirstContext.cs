using Core.Sql.Entities;
using Microsoft.EntityFrameworkCore;
 

namespace Core.Sql;

public class DBFirstContext:DbContext
{

	public DBFirstContext(DbContextOptions<DBFirstContext> options):base(options)
	{
			
	}
    public DbSet<StockExchangeEntity> StockExchanges { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBFirstContext).Assembly);
    }
}
