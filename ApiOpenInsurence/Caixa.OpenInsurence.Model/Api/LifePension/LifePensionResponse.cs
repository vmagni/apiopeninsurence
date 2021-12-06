using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.LifePension
{
    public class LifePensionResponse
    {
        public string RequestTime { get; set; }
        public List<LifePensionBrand> Brand { get; set; }
        public LinksPaginated LinksPaginated { get; set; }
        public MetaPaginated MetaPaginated { get; set; }
    }
}
