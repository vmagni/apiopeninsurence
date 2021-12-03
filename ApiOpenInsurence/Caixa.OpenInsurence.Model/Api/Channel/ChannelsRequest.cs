using Newtonsoft.Json;

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
