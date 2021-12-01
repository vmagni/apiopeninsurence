using Caixa.OpenInsurence.Model.Enums.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonMinimunRequirements
    {
        public ContractingTypeEnum ContractingType { get; set; }
        public string contractingMinRequirement { get; set; }

    }
}
