using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class PhoneChannelServices
    {
        [JsonIgnore]
        public ChannelServicesEnum Type { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
