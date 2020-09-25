using System;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Avalanche.Host.Data;
using Avalanche.Host.Models;
using Avalanche.Host.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Avalanche.Host
{
    internal class SenderHostedService : BackgroundService
    {
        private readonly AvalancheDbContext _dbContext;
        private readonly ArmaghanCredentials _armaghanCredentials;
        private readonly BulkOptions _bulkOptions;
        private readonly ILogger<SenderHostedService> _logger;
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            AllowTrailingCommas = false,
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = false,
            IgnoreReadOnlyProperties = false,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            ReadCommentHandling = JsonCommentHandling.Skip,
            WriteIndented = false
        };

        public SenderHostedService(
            AvalancheDbContext dbContext,
            IOptions<ArmaghanCredentials> armaghanCredentials,
            IOptions<BulkOptions> bulkOptions,
            ILogger<SenderHostedService> logger)
        {
            _armaghanCredentials = armaghanCredentials?.Value ?? throw new ArgumentNullException(nameof(armaghanCredentials));
            _bulkOptions = bulkOptions?.Value ?? throw new ArgumentNullException(nameof(bulkOptions));
            _dbContext = dbContext;
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var phones = _dbContext.MobileNumbers.AsNoTracking().OrderBy(o => o.Msisdn).ToList();

            var counter = 0;

            using var armaghanClient = new MessageRelayClient();

            foreach (var phoneEntity in phones)
            {
                if (counter >= _bulkOptions.BulkSize)
                {
                    _logger.LogInformation("Bulk size met, exiting");
                    return;
                }

                var alreadySentToday = await _dbContext
                    .OperationLogs
                    .AnyAsync(a => a.Msisdn == phoneEntity.Msisdn && a.SentDate.Date == DateTime.Now.Date, CancellationToken.None)
                    .ConfigureAwait(false);
                if (alreadySentToday)
                {
                    _logger.LogInformation("already sent a message to {phone} today, skipping", phoneEntity.Msisdn);
                    continue;
                }

                if (!stoppingToken.IsCancellationRequested)
                {
                    var sendResult = await armaghanClient.sendMessageOneToManyAsync(new sendMessageOneToMany
                    {
                        destination = new[] { phoneEntity.Msisdn },
                        originator = _armaghanCredentials.Originator,
                        password = _armaghanCredentials.Password,
                        username = _armaghanCredentials.Username,
                        content = _bulkOptions.MessageText,
                    })
                        .ConfigureAwait(false);

                    SaveSendResult(phoneEntity.Msisdn, _bulkOptions.MessageText, sendResult);
                    if (sendResult?.@return?.error?.errorCode == 0)
                    {
                        counter++;
                    }
                }
                else
                {
                    _logger.LogWarning($"Cancellataion is requested. Stopping!");
                    break;
                }
            }
        }

        private void SaveSendResult(string msisdn, string text, sendMessageOneToManyResponse sendResult)
        {
            var entity = new OperationLog
            {
                BrokerResponse = JsonSerializer.Serialize(sendResult?.@return, _jsonSerializerOptions),
                Msisdn = msisdn,
                SentDate = DateTime.Now,
                Text = text
            };
            try
            {
                _dbContext.OperationLogs.Add(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving send result: {entity}", JsonSerializer.Serialize(entity, _jsonSerializerOptions));
            }
        }
    }
}
