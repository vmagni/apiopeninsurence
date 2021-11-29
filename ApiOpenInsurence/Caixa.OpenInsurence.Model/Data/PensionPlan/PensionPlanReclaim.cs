using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanReclaim
    {
         public PensionPlanReclaimTable ReclaimTable { get; set; }
         public string DifferentiatePercentage { get; set; }
         public string GracePeriod { get; set; }
    }
}
