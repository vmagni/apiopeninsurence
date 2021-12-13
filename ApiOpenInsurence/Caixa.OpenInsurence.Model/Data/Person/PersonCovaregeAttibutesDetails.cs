using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonCovaregeAttibutesDetails
    {
        public long Amount { get; set; }
        public PersonCovaregeAttibutesDetailsUnit unit { get; set; }

        public PersonCovaregeAttibutesDetails()
        {
            unit = new PersonCovaregeAttibutesDetailsUnit();           
        }
    }
}
