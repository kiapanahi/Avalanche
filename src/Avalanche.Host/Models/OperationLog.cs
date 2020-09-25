using System;

namespace Avalanche.Host.Models
{
    public class OperationLog
    {
        public int Id { get; set; }
        public string Msisdn { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
        public string BrokerResponse { get; set; }
    }
}
