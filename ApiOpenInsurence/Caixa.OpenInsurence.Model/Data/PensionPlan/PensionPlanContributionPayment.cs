using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanContributionPayment
    {
        public ContributionPaymentMethodEnum ContributionPaymentMethod { get; set; }
        public ContributionPeriodicityEnum ContributionPeriodicity { get; set; }
    }
}
