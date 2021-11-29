using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Caixa.OpenInsurence.Model.Enums.PensionPlan
{
    public enum ModalityEnum
    {
        [Description("Pecúlio")]
        PECULIO,
        [Description("Pensão - Prazo Certo")]
        PENSAO_PRAZO_CERTO,
        [Description("Pensão - Menores de 21 anos")]
        PENSAO_MENORES_21,
        [Description("Pensão - Menores de 24 anos")]
        PENSAO_MENORES_24,
        [Description("Pensão Vitalícia - Cônjuge")]
        PENSAO_CONJUGE_VITALICIA,
        [Description("Pensão Temporária - Cônjuge")]
        PENSAO_CONJUGE_TEMPORARIA
    }
}
