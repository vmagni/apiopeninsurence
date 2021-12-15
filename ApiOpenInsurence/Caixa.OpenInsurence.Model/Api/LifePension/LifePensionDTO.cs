using Caixa.OpenInsurence.Model.Api.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.LifePension
{
    public class LifePensionDTO : ValidaResponseDTO
    {
        private LifePensionDTO lifePensionDTO;

        public LifePensionDTO()
        {
        }

        public LifePensionDTO(LifePensionDTO lifePensionDTO)
        {
            this.lifePensionDTO=lifePensionDTO;
        }

        public LifePensionResponse LifePension { get; set; }
    }
}
