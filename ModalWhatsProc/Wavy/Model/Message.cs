using System.Collections.Generic;

namespace ModalWhatsProc.Wavy.Model
{
    public class MessageContent
    {
        public string type { get; set; }
        public string messageText { get; set; }
        public string mediaUrl { get; set; }
        public string mimeType { get; set; }
        public string caption { get; set; }
        public Location location { get; set; }
        public List<Contact> contacts { get; set; }

    }
}