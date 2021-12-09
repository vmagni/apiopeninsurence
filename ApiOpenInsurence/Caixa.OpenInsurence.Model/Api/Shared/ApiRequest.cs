﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class ApiRequest
    {
        [JsonProperty("page")]
        [Required(ErrorMessage = "Page obrigatório")]
        [CustomValidations(ErrorMessage = "Page Deve ser maior que 0.")]
        public int Page { get; set; }

        [JsonProperty("page-size")]
        [Required(ErrorMessage = "PageSize obrigatório")]
        [CustomValidations(ErrorMessage = "PageSize Deve ser maior que 0.")]
        public int PageSize { get; set; }
    }
}
