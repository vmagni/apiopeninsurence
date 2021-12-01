using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonReclaim
    {
        public PersonReclaimTable ReclaimTable { get; set; }
        public string DifferentiatedPercentage { get; set; }
        public PersonCovaregeAttibutesDetails GracePeriod { get; set; }
        

    }
}
