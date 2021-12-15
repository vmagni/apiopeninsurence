using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.Channel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Api
{
    public class BranchChannelResponse
    {
        public BranchBrand Data { get; set; }
        public LinksPaginated Links { get; set; }
        public MetaPaginated Meta { get; set; }
        public BranchChannelResponse()
        {
            Data = new BranchBrand();
            Links = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/channels");
            Meta = new MetaPaginated();
        }

        public BranchChannelResponse(BranchChannelResponse response)
        {
            Data = response.Data;
            Links = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/channels");
            Meta = response.Meta;

        }
    }

    

    public class ElectronicChannelResponse
    {
        public ElectronicChannelBrand Data { get; set; }
        public LinksPaginated Links { get; set; }
        public MetaPaginated Meta { get; set; }

        public ElectronicChannelResponse()
        {
            Data = new ElectronicChannelBrand();
            Links = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/channels");
            Meta = new MetaPaginated();
        }

        public ElectronicChannelResponse(ElectronicChannelResponse response)
        {
            Data = response.Data;
            Links = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/channels");
            Meta = response.Meta;

        }
    }

    public class PhoneChannelResponse
    {
        public PhoneChannelCompany Data { get; set; }
        public LinksPaginated Links { get; set; }
        public MetaPaginated Meta { get; set; }

        public PhoneChannelResponse()
        {
            Data = new PhoneChannelCompany();
            Links = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/channels");
            Meta = new MetaPaginated();
        }

        public PhoneChannelResponse(PhoneChannelResponse response)
        {
            Data = response.Data;
            Links = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/channels");
            Meta = response.Meta;
        }
    }
}
