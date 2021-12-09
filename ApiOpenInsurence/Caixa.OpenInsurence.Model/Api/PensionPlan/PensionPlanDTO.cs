using Caixa.OpenInsurence.Model.Api.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.PensionPlan
{
    public class PensionPlanDTO : ValidaResponseDTO
    {
        private PensionPlanDTO pensionPlanDTO;

        public PensionPlanDTO()
        {
        }

        public PensionPlanDTO(PensionPlanDTO pensionPlanDTO)
        {
            this.pensionPlanDTO=pensionPlanDTO;
        }

        public PensionPlanResponse PensionPlan  { get; set; }
    }
}
