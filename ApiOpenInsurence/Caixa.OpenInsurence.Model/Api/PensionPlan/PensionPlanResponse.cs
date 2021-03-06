using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.PensionPlan
{
    public class PensionPlanResponse 
    {
        public PensionPlanBrand Data { get; set; }
        public LinksPaginated LinksPaginated { get; set; }
        public MetaPaginated MetaPaginated { get; set; }

        public PensionPlanResponse(PensionPlanResponse response) 
        {
            Data = response.Data;

            LinksPaginated = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/pension-plan");

            MetaPaginated = response.MetaPaginated;
        
        }

        public PensionPlanResponse()
        {
            Data = new PensionPlanBrand();

            LinksPaginated = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/pension-plan");

            MetaPaginated = new MetaPaginated();
        }
    }
}
