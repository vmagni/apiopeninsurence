using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class PhoneChannelCompany
    {
        public string Name { get; set; }
        public string CnpjNumber { get; set; }
        public List<PhoneChannel> PhoneChannels { get; set; }

        public PhoneChannelCompany()
        {
            PhoneChannels = new List<PhoneChannel>();
        }
    }
}
