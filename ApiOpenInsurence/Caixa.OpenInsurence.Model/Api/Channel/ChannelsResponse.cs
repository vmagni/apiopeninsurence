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
    }

    public class ElectronicChannelResponse
    {
        public ElectronicChannelBrand Data { get; set; }
        public LinksPaginated Links { get; set; }
        public MetaPaginated Meta { get; set; }
    }

    public class PhoneChannelResponse
    {
        public PhoneChannelCompany Data { get; set; }
        public LinksPaginated Links { get; set; }
        public MetaPaginated Meta { get; set; }
    }
}
