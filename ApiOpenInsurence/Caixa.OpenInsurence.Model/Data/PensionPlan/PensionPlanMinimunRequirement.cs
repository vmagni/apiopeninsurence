using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanMinimunRequirement
    {
        public RequirementContractTypeEnum MinRequirementContractType { get; set; }
        public string MinRequirementContract { get; set; }
    }
}
