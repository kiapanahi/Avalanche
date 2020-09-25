using Avalanche.Host.Data;
using Avalanche.Host.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GenericHost = Microsoft.Extensions.Hosting.Host;

namespace Avalanche.Host
{
    internal class Program
    {
        private static void Main()
        {
            var host = BuildHost();
            UpdateDatabase(host);
            host.Run();
        }

        private static void UpdateDatabase(IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var ctx = scope.ServiceProvider.GetService<AvalancheDbContext>();
            ctx.Database.Migrate();
        }

        private static IHost BuildHost()
        {
            return GenericHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<AvalancheDbContext>(options =>
                                options
                                .EnableSensitiveDataLogging()
                                .EnableDetailedErrors()
                                .UseSqlServer(hostContext.Configuration.GetConnectionString("Avalanche")));

                    services.Configure<ArmaghanCredentials>(hostContext.Configuration.GetSection("Armaghan"));
                    services.Configure<BulkOptions>(hostContext.Configuration.GetSection("BulkOptions"));

                    services.AddHostedService<SenderHostedService>();
                })
                .Build();
        }
    }
}
