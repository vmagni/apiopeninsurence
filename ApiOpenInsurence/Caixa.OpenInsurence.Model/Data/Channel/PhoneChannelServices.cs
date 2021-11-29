using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class PhoneChannelServices
    {
        [JsonIgnore]
        public ServicesEnum Type { get; set; }
        public string Name { get => Name; set => Name = Type.ToString(); }
        public int Code { get => Code; set => Code = (int)Type; }
    }
}
