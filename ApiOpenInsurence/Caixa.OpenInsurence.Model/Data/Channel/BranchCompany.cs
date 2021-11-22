using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class BranchCompany
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public object[] Branches { get; set; }
    }
}
