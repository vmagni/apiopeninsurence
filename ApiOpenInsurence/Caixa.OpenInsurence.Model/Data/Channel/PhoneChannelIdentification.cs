using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class PhoneChannelIdentification
    {
        public PhoneChannelTypeEnum Type { get; set; }
        public string Name { get; set; }
        public List<PhoneChannelPhone> Phones { get; set; }

        public PhoneChannelIdentification()
        {
            Phones = new List<PhoneChannelPhone>();
        }
    }
}
