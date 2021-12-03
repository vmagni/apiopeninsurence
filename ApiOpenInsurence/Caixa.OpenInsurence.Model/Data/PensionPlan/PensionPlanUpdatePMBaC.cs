
using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanUpdatePMBaC
    {
        public string InterestRate { get; set; }
        public UpdateIndexPersonPlanEnum UpdateIndex { get; set; }
    }
}
