using Caixa.OpenInsurence.Model.Enums.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonAgeAdjustment
    {
        public CriterionEnum Criterion { get; set; }
        public int Frequency { get; set; }

    }
}
