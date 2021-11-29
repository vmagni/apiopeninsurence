using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class PhoneChannelIdentification
    {
        public PhoneTypesEnum Type { get; set; }
        public List<PhoneChannelPhone> Phones { get; set; }
    }
}
