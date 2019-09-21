using System;

namespace ModalWhatsProc.Wavy.Model
{
    public class Datum
    {
        public string id { get; set; }
        public string source { get; set; }
        public string origin { get; set; }
        public UserProfile userProfile { get; set; }
        public int campaignId { get; set; }
        public string correlationId { get; set; }
        public string campaignAlias { get; set; }
        public string flowId { get; set; }
        public ExtraInfo extraInfo { get; set; }
        public MessageContent message { get; set; }
        public long receivedAt { get; set; }
        public DateTime receivedDate { get; set; }
    }
}