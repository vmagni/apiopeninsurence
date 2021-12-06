using Newtonsoft.Json;


namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class ApiRequest
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("page-size")]
        public int PageSize { get; set; }
    }
}
