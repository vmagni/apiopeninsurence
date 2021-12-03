using Newtonsoft.Json;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class MetaPaginated
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }
        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }
}
