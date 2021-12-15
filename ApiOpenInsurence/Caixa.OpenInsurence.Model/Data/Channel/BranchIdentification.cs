using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class BranchIdentification
    {
        public BranchChannelTypeEnum Type { get; set; }
        public string Code { get; set; }
        public int CheckDigit { get; set; }
        public string Name { get; set; }
    }
}
