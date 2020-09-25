using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Avalanche.Host.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Avalanche.Host
{
    internal class SenderHostedService : BackgroundService
    {
        private readonly AvalancheDbContext _dbContext;
        private readonly ILogger<SenderHostedService> _logger;

        public SenderHostedService(
            AvalancheDbContext dbContext,
            ILogger<SenderHostedService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var phones = _dbContext.MobileNumbers.AsNoTracking();

            var sw = Stopwatch.StartNew();
            await foreach (var _ in phones.AsAsyncEnumerable())
            {
                if (!stoppingToken.IsCancellationRequested)
                {
                    // silent
                }
                else
                {
                    _logger.LogWarning($"Cancellataion is requested. Stopping!");
                    break;
                }
            }
            sw.Stop();
            var count = await phones.CountAsync(CancellationToken.None).ConfigureAwait(false);

            _logger.LogInformation("read {count} records in {elapsed}", count, sw.Elapsed);
        }
    }
}
