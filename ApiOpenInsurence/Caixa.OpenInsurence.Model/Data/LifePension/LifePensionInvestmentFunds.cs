using Caixa.OpenInsurence.Model.Enums.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionInvestmentFunds
    {
        public string CnpjNumber { get; set; }
        public string CompanyName { get; set; }
        public long MaximumAdministrationFee { get; set; }
        public TypePerformanceFeeEnum TypePerformanceFee { get; set; }
        public long MaximumPerformanceFee { get; set; }
        public bool EligibilityRule { get; set; }
        public long MinimumContributionAmount { get; set; }
        public long MinimumMathematicalProvisionAmount { get; set; }
    }
}
