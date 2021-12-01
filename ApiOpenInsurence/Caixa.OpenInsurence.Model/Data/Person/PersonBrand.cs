using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonBrand
    {
        public string Name { get; set; }
        public List<PersonCompany> companies { get; set; }
    }
}
