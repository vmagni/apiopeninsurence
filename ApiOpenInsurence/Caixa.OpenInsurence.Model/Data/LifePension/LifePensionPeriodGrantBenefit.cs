using Caixa.OpenInsurence.Model.Enums.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionPeriodGrantBenefit
    {
        public IncomeModalityEnum IncomeModality { get; set; }
        public BiometricTableEnum BiometricTable { get; set; }
        public long interestRate { get; set; }
        public UpdateIndexEnum UpdateIndex { get; set; }
        public long ReversalResultsFinancial { get; set; }
        public LifePensionInvestmentFunds InvestimentFunds { get; set; }
    }
}
