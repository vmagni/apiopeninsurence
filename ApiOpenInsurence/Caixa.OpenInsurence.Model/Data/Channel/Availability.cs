using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class Availability
    {
        public List<AvailabilityStandards> Standards { get; set; }
        public bool IsPublicAccessAllowed { get; set; }
        public string Exception { get; set; }

        public Availability()
        {
            Standards = new List<AvailabilityStandards>();
        }

    }

    public class AvailabilityStandards
    {
        public string WeekDay { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string Exception { get; set; }
    }
}
