using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class ElectronicChannelComapany
    {
        public string Name { get; set; }
        [JsonProperty("cnpjNumber")]
        public string CnpjNumber { get; set; }
        public List<string> UrlComplementaryList { get; set; }
        public List<ElectronicChannel> ElectronicChannels { get; set; }

        public ElectronicChannelComapany()
        {
            UrlComplementaryList = new List<string>();
            ElectronicChannels = new List<ElectronicChannel>();
        }
        
    }
}
