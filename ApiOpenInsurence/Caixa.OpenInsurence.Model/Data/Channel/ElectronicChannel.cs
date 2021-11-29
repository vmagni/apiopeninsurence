using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class ElectronicChannel
    {
        public ElectronicChannelIdentification Identification { get; set; }
        public List<ChannelService> Services { get; set; }
    }
}
