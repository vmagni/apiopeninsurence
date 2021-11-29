using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Caixa.OpenInsurence.Model.Enums.PensionPlan
{
    public enum PeriodEnum
    {
        [Description("Prazo")]
        PRAZO, 
        [Description("Até fim do ciclo determinado")]
        ATE_FIM_CICLO_DETERMINADO
    }
}
