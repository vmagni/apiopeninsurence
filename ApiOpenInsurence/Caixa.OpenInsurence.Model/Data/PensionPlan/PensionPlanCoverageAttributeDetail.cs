using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanCoverageAttributeDetail
    {
        public decimal Amount { get; set; }
        public PensionPlanCoverageAttributeDetailUnit Unit { get; set; }
    }

    public class PensionPlanCoverageAttributeDetailUnit
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
