﻿using Newtonsoft.Json;


namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class Request
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("page-size")]
        public int PageSize { get; set; }
    }
}
