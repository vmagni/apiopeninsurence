using Caixa.OpenInsurence.Model.Enums.Person;
using Caixa.OpenInsurence.Model.Enums.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonCoverageAttributes
    {
        public IndemnityPaymentMethodEnum IndemnityPaymentMethod { get; set; }
        public IndemnityPaymentFrequencyEnum IndemnityPaymentFrequency { get; set; }
        public PersonCovaregeAttibutesDetails MinValue { get; set; }
        public PersonCovaregeAttibutesDetails MaxValue { get; set; }
        public string IndemnifiablePeriod { get; set; }
        public int MaximumQtyIndemnifiableInstallments { get; set; }
        public CurrencyEnum Currency { get; set; }
        public PersonGracePeriodUnit GracePeriod { get; set; }
        public PersonGracePeriodUnit DifferentiatedGracePeriod { get; set; }
        public int deductibleDays { get; set; }
        public long differentiatedDeductibleDays { get; set; }
        public long deductibleBRL { get; set; }
        public string differentiatedDeductibleBRL { get; set; }
        public ExcludedRisksEnum ExcludedRisks { get; set; }
        public string ExcludedRisksURL { get; set; }
        public bool AllowApartPurchase { get; set; }
        public string MinCoverageGroupRequired { get; set; }
        public string MinCoverageGroupRequiredOthers { get; set; }

        public PersonCoverageAttributes()
        {
            MinValue = new PersonCovaregeAttibutesDetails();
            MaxValue = new PersonCovaregeAttibutesDetails();
            GracePeriod = new PersonGracePeriodUnit();
            DifferentiatedGracePeriod = new PersonGracePeriodUnit();
        }

    }
}
