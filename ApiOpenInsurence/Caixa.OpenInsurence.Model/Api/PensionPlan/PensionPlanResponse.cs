using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.PensionPlan
{
    public class PensionPlanResponse
    {
        public string RequestTime { get; set; }
        public PensionPlanBrand Data { get; set; }
        public LinksPaginated LinksPaginated { get; set; }
        public MetaPaginated MetaPaginated { get; set; }
    }
}
