﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ModalWhatsProc.Models
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Channel
    {

        [EnumMember(Value = "sms")]
        SMS,

        [EnumMember(Value = "whatsapp")]
        WhatsApp
    }
}
