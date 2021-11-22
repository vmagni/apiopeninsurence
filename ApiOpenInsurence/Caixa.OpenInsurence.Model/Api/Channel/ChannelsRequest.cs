using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Api.Channel
{
    public class ChannelsRequest
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("page-size")]
        public int PageSize { get; set; }
    }
}
