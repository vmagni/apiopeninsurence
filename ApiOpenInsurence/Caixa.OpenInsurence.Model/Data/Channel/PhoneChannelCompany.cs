using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class PhoneChannelCompany
    {
        public string Name { get; set; }
        [JsonProperty("cnpjNumber")]
        public string CnpjNumber { get; set; }
        [JsonProperty("phoneChannels")]
        public List<PhoneChannel> PhoneChannels { get; set; }
    }
}
