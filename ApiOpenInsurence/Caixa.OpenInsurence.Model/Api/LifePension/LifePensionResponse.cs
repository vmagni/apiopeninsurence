using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.LifePension
{
    public class LifePensionResponse
    {        
        public LifePensionBrand Brand { get; set; }
        public LinksPaginated LinksPaginated { get; set; }
        public MetaPaginated MetaPaginated { get; set; }

        public LifePensionResponse(LifePensionResponse response)
        {
            Brand = response.Brand;

            LinksPaginated = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/life-pension");

            MetaPaginated = response.MetaPaginated;

        }

        public LifePensionResponse()
        {
            Brand = new LifePensionBrand();

            LinksPaginated = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/life-pension");

            MetaPaginated = new MetaPaginated();
        }
    }
}
