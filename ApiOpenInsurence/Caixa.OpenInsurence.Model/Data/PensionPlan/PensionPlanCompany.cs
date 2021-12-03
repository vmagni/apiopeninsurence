using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanCompany
    {
        public string Name { get; set; }
        public string CnpjNumber { get; set; }
        public List<PensionPlanProduct> PensionPlanProducts { get; set; }

        public PensionPlanCompany()
        {
            PensionPlanProducts = new List<PensionPlanProduct>();
        }
    }
}
