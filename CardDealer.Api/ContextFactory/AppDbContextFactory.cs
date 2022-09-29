using CardDealer.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CardDealer.Api.ContextFactory
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            
            var builder = new DbContextOptionsBuilder<AppDbContext>()
               .UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
               b => b.MigrationsAssembly("CardDealer.Api"));

            return new AppDbContext(builder.Options);
        }
    }
}
