using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class PhoneChannel
    {
        public PhoneChannelIdentification Identification { get; set; }
        public PhoneChannelServices Services { get; set; }
        public Availability Availability { get; set; }
    }
}
