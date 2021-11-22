using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class BranchServices
    {
        public BranchServiceEnum Type { get; set; }
        public string Name { get => Type.ToString(); }
        public int Code { get => (int)Type; }
    }
}
