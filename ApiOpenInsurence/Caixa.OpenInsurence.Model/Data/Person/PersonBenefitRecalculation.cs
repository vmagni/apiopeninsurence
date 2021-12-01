using Caixa.OpenInsurence.Model.Enums.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonBenefitRecalculation
    {
        
        public BenefitRecalculationCriteriaEnum BenefitRecalculationCriteria { get; set; }
        public BenefitUpdateIndexEnum BenefitUpdateIndex { get; set; }
        
    }
}
