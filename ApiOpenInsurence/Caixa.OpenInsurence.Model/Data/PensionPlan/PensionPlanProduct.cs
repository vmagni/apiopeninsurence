using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.PensionPlan
{
    public class PensionPlanProduct
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ModalityEnum Modality { get; set; }
        //public List<PensionPlanCoverage> PensionPlanCoverages { get; set; }
        public string PensionPlanCoverages { get; set; }
        public AdditionalEnum Additional { get; set; }
        public List<string> AdditionalOthers { get; set; }
        public AssistanceTypeEnum AssistanceTypes { get; set; }
        public List<string> AssistanceTypesOthers { get; set; }
        public PensionPlanTerm TermsAndConditions { get; set; }
        public PensionPlanUpdatePMBaC UpdatePMBaC { get; set; }
        public PremiumUpdateIndexEnum PremiumUpdateIndex { get; set; }
        public PensionPlanAgeReframing AgeReframing { get; set; }
        public RegimeContractTypeEnum FinancialRegimeContractType { get; set; }
        public PensionPlanReclaim Reclaim { get; set; }
        public OtherGuarateedValuesEnum OtherGuarateedValues { get; set; }
        public ProfitModalityEnum ProfitModality { get; set; }
        public PensionPlanContributionPayment ContributionPayment { get; set; }
        public string ContributionTax { get; set; }
        public PensionPlanMinimunRequirement MinimunRequirement { get; set; }
        public TargetAudianceEnum TargetAudiance { get; set; }

        public PensionPlanProduct()
        {
            //PensionPlanCoverages = new List<PensionPlanCoverage>();
            AdditionalOthers = new List<string>();
            AssistanceTypesOthers = new List<string>();
            TermsAndConditions = new PensionPlanTerm();
            UpdatePMBaC = new PensionPlanUpdatePMBaC();
            AgeReframing = new PensionPlanAgeReframing();
            Reclaim = new PensionPlanReclaim();
            ContributionPayment = new PensionPlanContributionPayment();
            MinimunRequirement = new PensionPlanMinimunRequirement();
        }
    }
}
