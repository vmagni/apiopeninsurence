using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Enums.PensionPlan
{
    public enum ContributionPaymentMethodEnum
    {
        CARTAO_CREDITO, DEBITO_CONTA, DEBITO_CONTA_POUPANCA, BOLETO_BANCARIO, PIX, TED_DOC, CONSIGNACAO_FOLHA_PAGAMENTO, PONTOS_PROGRAMA_BENEFICIO, OUTROS
    }
    public enum ContributionPeriodicityEnum
    {
        MENSAL, UNICA, ANUAL, TRIMESTRAL, SEMESTRAL, BIMESTRAL, OUTRAS
    }
}
