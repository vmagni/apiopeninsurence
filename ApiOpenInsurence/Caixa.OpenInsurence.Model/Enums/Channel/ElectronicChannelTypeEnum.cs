using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Caixa.OpenInsurence.Model.Enums.Channel
{
    public enum ElectronicChannelTypeEnum
    {
        [Description("Internet")]
        INTERNET = 1,
        [Description("Mobile")]
        MOBILE = 2,
        [Description("Chat")]
        CHAT = 3,
        [Description("Whatsapp")]
        WHATSAPP = 4,
        [Description("Consumidor")]
        CONSUMIDOR = 5,
        [Description("Outros ")]
        OUTROS = 6
    }
}
