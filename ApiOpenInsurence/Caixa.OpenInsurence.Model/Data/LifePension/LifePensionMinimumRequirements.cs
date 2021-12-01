using Caixa.OpenInsurence.Model.Enums.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionMinimumRequirements
    {
        public ContractTypeEnum ContractType { get; set; }
        public bool ParticipantQualified { get; set; }
        public string MinRequirementsContract { get; set; }
    }
}
