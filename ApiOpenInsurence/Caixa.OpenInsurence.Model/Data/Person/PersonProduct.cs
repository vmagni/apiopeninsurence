using Caixa.OpenInsurence.Model.Enums.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonProduct
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public CategoryEnum Category { get; set; }
        public InsuranceModalityEnum InsuranceModality { get; set; }
        public List<Coverage> Coverages { get; set; }
        public AssistanceTypePersonEnum AssistanceType { get; set; }
        public AdditionalPersonEnum Additional { get; set; }
        public List<string> AssistanceTypeOthers { get; set; }
        public List<PersonTermsAndCondition> TermsAndConditions { get; set; }
        public bool GlobalCapital { get; set; }
        public ValidityEnum Validity { get; set; }
        public PersonPmbacRemuneration PmbacRemuneration { get; set; }
        public PersonBenefitRecalculation BenefitRecalculation { get; set; }
        public PersonAgeAdjustment AgeAdjustment { get; set; }
        public ContractTypePersonEnum ContractType { get; set; }
        public PersonReclaim Reclaim { get; set; }
        public OtherGuaranteedValuesEnum OtherGuaranteedValues { get; set; }
        public int PortabilityGraceTime { get; set; }
        public IndemnityPaymentMethodEnum IndemnityPaymentMethod { get; set; }
        public IndemnityPaymentIncomeEnum IndemnityPaymentIncome { get; set; }
        public PersonPremiumPayment PremiumPayment { get; set; }
        public PersonMinimunRequirements MinimunRequirements { get; set; }
        public TargetAudiencePersonEnum TargetAudience { get; set; }

        public PersonProduct()
        {
            Coverages = new List<Coverage>();
            AssistanceTypeOthers = new List<string>();
            TermsAndConditions = new List<PersonTermsAndCondition>();
            PmbacRemuneration = new PersonPmbacRemuneration();
            BenefitRecalculation = new PersonBenefitRecalculation();
            AgeAdjustment = new PersonAgeAdjustment();
            Reclaim = new PersonReclaim();
            PremiumPayment = new PersonPremiumPayment();
            MinimunRequirements = new PersonMinimunRequirements();
        }
    }
}
