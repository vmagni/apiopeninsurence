using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Caixa.OpenInsurence.Model.Enums.Channel
{
    public enum PhoneChannelTypeEnum
    {
        [Description("Central de Atendimento")]
        CENTRAL_ATENDIMENTO,
        [Description("SAC")]
        SAC,
        [Description("Ouvidoria")]
        OUVIDORIA,
        [Description("Sinistros")]
        SINISTROS,
        [Description("Assistencia Dia e Noite")]
        ASSISTENCIA_DIA_NOITE
    }
}
