using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IChannelsService
    {
        
        public Task<object> GetBranches(string url, string username);
        public object GetEletronicChannels();
        public object GetPhoneChannels();

    }
}
