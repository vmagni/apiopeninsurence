using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionCompany
    {
        public string Name { get; set; }
        public string CnpjNumber { get; set; }
        public List<LifePensionProduct> products { get; set; }
    }
}
