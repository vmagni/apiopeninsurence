using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonCompany
    {
        public string Name { get; set; }
        public string CnpjNumber { get; set; }
        public List<PersonProduct> PersonProducts { get; set; }        
    }
}