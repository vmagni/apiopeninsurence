using Caixa.OpenInsurence.Model.Data.Token;
using Caixa.OpenInsurence.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Services
{

    public class ChannelsService : IChannelsService
    {
        public async Task<object> GetBranches(string url, string username)
        {

            throw new NotImplementedException();
        }

        public object GetEletronicChannels()
        {
            throw new NotImplementedException();
        }

        public object GetPhoneChannels()
        {
            throw new NotImplementedException();
        }
    }
}
