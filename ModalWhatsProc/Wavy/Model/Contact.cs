using System.Collections.Generic;

namespace ModalWhatsProc.Wavy.Model
{
    public class Contact
    {
        public List<Address> addresses { get; set; }
        public string birthday { get; set; }
        public List<Email> emails { get; set; }
        public Name name { get; set; }
        public Org org { get; set; }
        public List<Phone> phones { get; set; }
        public List<Url> urls { get; set; }
    }
}