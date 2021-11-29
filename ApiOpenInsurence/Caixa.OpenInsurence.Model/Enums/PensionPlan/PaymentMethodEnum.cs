using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Caixa.OpenInsurence.Model.Enums.PensionPlan
{
    public enum PaymentMethodEnum
    {
        [Description("Pagamento Único")]
        PAGAMENTO_UNICO,
        [Description("Forma de Renda")]
        FORMA_RENDA
    }
}
