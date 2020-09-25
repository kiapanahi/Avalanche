using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Avalanche.Host
{
    internal class SenderHostedService : BackgroundService
    {
        private readonly ILogger<SenderHostedService> _logger;

        public SenderHostedService(ILogger<SenderHostedService> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("working...");
                await Task.Delay(TimeSpan.FromSeconds(1), CancellationToken.None)
                    .ConfigureAwait(false);
            }
        }
    }
}
