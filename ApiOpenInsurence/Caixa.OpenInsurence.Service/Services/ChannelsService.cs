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
        private readonly ITokenService _tokenService;
        
        public ChannelsService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public async Task<object> GetBranches(string url, string username)
        {
            var tokenRequest = new SecurityTokenRequest() { Username = username
                                                            , Funcao = Enum.GetName(typeof(TokenFunctionEnum)
                                                            , TokenFunctionEnum.OPIN_ConsultaProdutosVidaPF) };

            var token = await _tokenService.GenerateToken(url, tokenRequest);

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
