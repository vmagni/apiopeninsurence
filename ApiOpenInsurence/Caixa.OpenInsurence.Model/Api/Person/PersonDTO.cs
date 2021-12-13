using Caixa.OpenInsurence.Model.Api.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Person
{
    public class PersonDTO : ValidaResponseDTO
    {
        private PersonDTO personDTO;

        public PersonDTO()
        {
        }

        public PersonDTO(PersonDTO pensionPlanDTO)
        {
            this.personDTO=pensionPlanDTO;
        }

        public PersonResponse Person { get; set; }
    }
}
