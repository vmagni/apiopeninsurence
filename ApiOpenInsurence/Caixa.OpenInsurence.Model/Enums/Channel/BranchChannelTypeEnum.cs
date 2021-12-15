using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Enums.Channel
{
    public enum BranchChannelTypeEnum
    {
        [Description("Agência")]
        AGENCIA = 1,
        [Description("Posto de Atendimento")]
        POSTO_ATENDIMENTO = 2,
        [Description("Posto de Atendimento Eletrônico")]
        POSTO_ATENDIMENTO_ELETRONICO = 3,
        [Description("Unidade Administrative Desmembrada")]
        UNIDADE_ADMINISTRATIVA_DESMEMBRADA = 4
    }
}
