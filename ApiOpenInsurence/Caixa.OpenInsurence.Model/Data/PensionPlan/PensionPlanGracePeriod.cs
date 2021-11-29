using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanGracePeriod
    {
        public decimal Amount { get; set; }
        public UnitPeriodEnum Unit { get; set; }
    }
}
