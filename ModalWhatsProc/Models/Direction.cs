using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace ModalWhatsProc.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Direction
    {
        [EnumMember(Value = "in")]
        In,
        [EnumMember(Value = "out")]
        Out
    }
}