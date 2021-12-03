using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanBrand
    {
        public string Name { get; set; }
        public List<PensionPlanCompany> Companies { get; set; }

        public PensionPlanBrand()
        {
            Companies = new List<PensionPlanCompany>();
        }
    }
}
