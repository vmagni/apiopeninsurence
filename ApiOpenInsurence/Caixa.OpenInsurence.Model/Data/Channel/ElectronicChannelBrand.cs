using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class ElectronicChannelBrand
    {
        public string Name { get; set; }
        public List<ElectronicChannelComapany> Companies { get; set; }
    }
}
