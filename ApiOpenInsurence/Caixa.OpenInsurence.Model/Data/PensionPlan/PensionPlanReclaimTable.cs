using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanReclaimTable
    {
        public int InitialMonthRange { get; set; }
        public int FinalMonthRange { get; set; }
        public string Percentage { get; set; }
    }
}
