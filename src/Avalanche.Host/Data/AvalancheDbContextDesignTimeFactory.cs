using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Avalanche.Host.Data
{
    public class AvalancheDbContextDesignTimeFactory : IDesignTimeDbContextFactory<AvalancheDbContext>
    {
        public AvalancheDbContext CreateDbContext(string[] args)
        {
            var configurationRoot = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .Build();

            var connectionString = configurationRoot.GetConnectionString("Avalanche");
            var options = new DbContextOptionsBuilder<AvalancheDbContext>()
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
                .UseSqlServer(connectionString);

            return new AvalancheDbContext(options.Options);
        }
    }
}
