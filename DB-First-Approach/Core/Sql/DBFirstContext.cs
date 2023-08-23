using Microsoft.EntityFrameworkCore;
 

namespace Core.Sql;

public class DBFirstContext:DbContext
{

	public DBFirstContext(DbContextOptions<DBFirstContext> options):base(options)
	{
			
	}
}
