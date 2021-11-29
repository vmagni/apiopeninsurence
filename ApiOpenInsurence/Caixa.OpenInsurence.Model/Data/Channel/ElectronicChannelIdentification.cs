using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class ElectronicChannelIdentification
    {
        public ElectronicChannelTypesEnum Type { get; set; }
        public List<string> Urls { get; set; }
    }
}
