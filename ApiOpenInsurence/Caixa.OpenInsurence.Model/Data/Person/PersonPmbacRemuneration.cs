using Caixa.OpenInsurence.Model.Enums.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonPmbacRemuneration
    {
        public long InterestRate { get; set; }
        public PmbacUpdateIndexEnum PmbacUpdateIndex { get; set; }
        public CapitalizationMethodEnum CapitalizationMethod { get; set; }        

    }
}
