using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class ApiRequest
    {
        [JsonProperty("page")]
        [Required(ErrorMessage = "Page obrigatório")]
        [DefaultValue(1)]
        [CustomValidations(ErrorMessage = "Page Deve ser maior que 0.")]
        public int Page { get; set; }

        [JsonProperty("page-size")]
        [Required(ErrorMessage = "PageSize obrigatório")]
        [DefaultValue(10)]
        [CustomValidations(ErrorMessage = "PageSize Deve ser maior que 0.")]
        public int PageSize { get; set; }
    }
}
