using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanCoverage
    {
        public CoveragePersonPlanEnum Coverage { get; set; }
        public PensionPlanCoverageAttribute CoverageAttribute { get; set; }
        public CoveragePeriodEnum CoveragePeriod { get; set; }

        public PensionPlanCoverage()
        {
            CoverageAttribute = new PensionPlanCoverageAttribute();            
        }
    }
}
