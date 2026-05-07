using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SmartTask.AccessDatas;

public class BackendDBContextFactory : IDesignTimeDbContextFactory<BackendDBContext>
{
    public BackendDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BackendDBContext>();
        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BackendDB;MultipleActiveResultSets=True");
        optionsBuilder.UseSqlite("Data Source=BackendDB.db");
        return new BackendDBContext(optionsBuilder.Options);
    }
}
