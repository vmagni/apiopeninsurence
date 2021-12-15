using Caixa.OpenInsurence.Model.Enums.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionDefferalPeriod
    {
        public long InterestRate { get; set; }
        public UpdateIndexEnum UpdateIndex { get; set; }
        public string otherMinimumPerformanceGarantees { get; set; }
        public long ReversalFinancialResults { get; set; }
        public MinimumPremiumAmount minimumPremiumAmount { get; set; }
        public PremiumPaymentMethodEnum PremiumPaymentMethod { get; set; }
        public bool PermissionExtraordinaryContributions { get; set; }
        public bool PermissonScheduledFinancialPayments { get; set; }
        public int GracePeriodRedemption { get; set; }
        public int GracePeriodBetweenRedemptionRequests { get; set; }
        public int RedemptionPaymentTerm { get; set; }
        public int GracePeriodPortability { get; set; }
        public int GracePeriodBetweenPortabilityRequests { get; set; }
        public int PortabilityPaymentTerm { get; set; }
        public LifePensionInvestmentFunds InvestimentFunds { get; set; }

        public LifePensionDefferalPeriod()
        {
            minimumPremiumAmount = new MinimumPremiumAmount();
            InvestimentFunds = new LifePensionInvestmentFunds();
        }
    }
}
