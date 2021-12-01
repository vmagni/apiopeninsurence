using Caixa.OpenInsurence.Model.Data.Token;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface ITokenService
    {
        public Task<object> GenerateToken(string url, SecurityTokenRequest request);
    }
}
