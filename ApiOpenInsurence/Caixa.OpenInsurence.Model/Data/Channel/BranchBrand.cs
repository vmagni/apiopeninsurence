using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class BranchBrand
    {
        public string Name { get; set; }
        public List<BranchCompany> Companies { get; set; }
    }
}
