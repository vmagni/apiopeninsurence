using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionBrand
    {
        public string Name { get; set; }
        public List<LifePensionCompany> companies { get; set; }

        public LifePensionBrand()
        {
            companies = new List<LifePensionCompany>();
        }
    }
}
