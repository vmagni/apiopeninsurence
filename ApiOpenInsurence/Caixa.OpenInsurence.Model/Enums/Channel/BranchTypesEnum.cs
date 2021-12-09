using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Enums.Channel
{
    public enum BranchTypesEnum
    {
        [Description("Agência")]
        AGENCIA,
        [Description("Posto de Atendimento")]
        POSTO_ATENDIMENTO,
        [Description("Posto de Atendimento Eletrônico")]
        POSTO_ATENDIMENTO_ELETRONICO,
        [Description("Unidade Administrative Desmembrada")]
        UNIDADE_ADMINISTRATIVA_DESMEMBRADA
    }
}
