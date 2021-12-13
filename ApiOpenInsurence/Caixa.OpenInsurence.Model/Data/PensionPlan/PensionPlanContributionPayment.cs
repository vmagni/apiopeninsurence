using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanContributionPayment
    {
        public List<ContributionPaymentMethodEnum> ContributionPaymentMethod { get; set; }
        public List<ContributionPeriodicityEnum> ContributionPeriodicity { get; set; }

        public PensionPlanContributionPayment()
        {
            ContributionPaymentMethod = new List<ContributionPaymentMethodEnum>();
            ContributionPeriodicity = new List<ContributionPeriodicityEnum>();


            ContributionPaymentMethod.Add(ContributionPaymentMethodEnum.DEBITO_CONTA);
            ContributionPaymentMethod.Add(ContributionPaymentMethodEnum.BOLETO_BANCARIO);

            ContributionPeriodicity.Add(ContributionPeriodicityEnum.MENSAL);
            ContributionPeriodicity.Add(ContributionPeriodicityEnum.UNICA);
        }
    }
}
