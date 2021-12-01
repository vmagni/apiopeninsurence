using Caixa.OpenInsurence.Model.Enums.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionProductDetails
    {
        public string SusepProcessNumber { get; set; }
        public TypeEnum Type { get; set; }
        public string ContractTermsConditions { get; set; }
        public LifePensionDefferalPeriod DefferalPeriod { get; set; }
        public LifePensionPeriodGrantBenefit GrantPeriodBenefit { get; set; }
        public LifePensionCosts Costs { get; set; }
        

    }
}
