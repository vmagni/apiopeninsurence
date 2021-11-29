using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanAgeReframing
    {
        public ReframingCriterionEnum ReframingCriterion { get; set; }
        public int ReframingPeriodicty { get; set; }
    }
}
