using Caixa.OpenInsurence.Model.Data.Token;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Data.Interfaces
{
    public interface ITokenService
    {
        public Task<SecurityToken> GenerateToken(TokenFunctionEnum funcaoRequest);
    }
}
