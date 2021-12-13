using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using Caixa.OpenInsurence.Model.Enums.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanCoverageAttribute
    {
        public PaymentMethodEnum IndenizationPaymentMethod { get; set; }

        public PensionPlanCoverageAttributeDetail MinValue { get; set; }
        public PensionPlanCoverageAttributeDetail MaxValue { get; set; }
        public PeriodEnum IndemnifiablePeriod { get; set; }
        public int IndemnifiableDeadline { get; set; }
        public CurrencyEnum Currency { get; set; }
        public PensionPlanGracePeriod GracePeriod { get; set; }
        public List<ExcludedRiskEnum> ExcludedRisks { get; set; }
        public string ExcludedRiskURL { get; set; }

        public PensionPlanCoverageAttribute()
        {
            MinValue = new PensionPlanCoverageAttributeDetail();
            MaxValue = new PensionPlanCoverageAttributeDetail();
            GracePeriod = new PensionPlanGracePeriod();
            ExcludedRisks = new List<ExcludedRiskEnum>();
        }
    }
}
