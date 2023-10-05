using MercedesStore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MercedesStore.ContextFactory
{
    public class MercedesDbContextFactory : IDesignTimeDbContextFactory<MercedesDbContext>
    {
        public MercedesDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<MercedesDbContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"), b=>b.MigrationsAssembly("MercedesStore"));

            return new MercedesDbContext(builder.Options);
        }
    }
}
