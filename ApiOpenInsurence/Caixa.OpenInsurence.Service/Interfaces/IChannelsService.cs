using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IChannelsService
    {
        
        public object GetBranches();
        public object GetEletronicChannels();
        public object GetPhoneChannels();

    }
}
