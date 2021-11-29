using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class Branch
    {
        public BranchIdentification Identification { get; set; }
        public BranchPostalAddress PostalAddress { get; set; }
        public Availability Availbility { get; set; }
        public List<BranchPhone> Phones { get; set; }
        public List<ChannelService> Services { get; set; }
    }
}
