using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Caixa.OpenInsurence.Model.Enums.Channel
{
    public enum PhoneTypesEnum
    {
        [Description("Central telefônica")]
        CENTRAL_TELEFONICA = 1,
        [Description("SAC")]
        SAC = 2,
        [Description("Ouvidoria")]
        OUVIDORIA = 3
    }
}
