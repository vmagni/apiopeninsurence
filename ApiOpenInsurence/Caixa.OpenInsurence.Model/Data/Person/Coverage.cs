using Caixa.OpenInsurence.Model.Enums.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class Coverage
    {
        public CoverageEnum CoverageType { get; set; }
        public string CoverageOthers { get; set; }
        public PersonCoverageAttributes coverageAttributes { get; set; }

        public Coverage()
        {
            coverageAttributes = new PersonCoverageAttributes();
        }
    }
}
