using Caixa.OpenInsurence.Model.Enums.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonPremiumPayment
    {
        
        public PaymentMethodPersonEnum PaymentMethod { get; set; }
        public FrequencyEnum Frequency { get; set; }
        public string premiumTax { get; set; }
        
    }
}
