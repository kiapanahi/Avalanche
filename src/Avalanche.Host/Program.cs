using Avalanche.Host.Data;
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

            host.Run();
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


                    services.AddHostedService<SenderHostedService>();
                })
                .Build();
        }
    }
}
