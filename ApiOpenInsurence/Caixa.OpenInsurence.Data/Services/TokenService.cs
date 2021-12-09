using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Data.Token;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Data.Services
{
    public class TokenService : ITokenService
    {
        private readonly ITokenConfigManager _tokenConfig;
        public TokenService(ITokenConfigManager tokenConfig)
        {
            _tokenConfig = tokenConfig;
        }
        public async Task<SecurityToken> GenerateToken(TokenFunctionEnum funcaoRequest)
        {
            var retorno = await RequestToken(_tokenConfig.TokenUrl, new SecurityTokenRequest()
            {
                Funcao = Enum.GetName(typeof(TokenFunctionEnum), funcaoRequest),
                Username = _tokenConfig.TokenUsername

            });

            var tokenData = retorno.Dados;
            
            return new SecurityToken()
            {
                Username = _tokenConfig.TokenUsername,
                SHArsaKey = GenerateSHArsKey(tokenData.Mapdata, tokenData.KeyData)
            };
        }

        private string GenerateSHArsKey(string PGPPK, string KeyRSA)
        {
            string dataret = "";
            for (int g = 0; g < KeyRSA.Length; g += 4)
            {
                dataret += PGPPK.Substring(int.Parse(KeyRSA.Substring(g, 4)), 1);
            }
            return dataret;
        }

        private async Task<SecurityTokenResponse> RequestToken(string url, SecurityTokenRequest requestBody)
        {
            //SSL Certification Invalid Bypass
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            //REQUEST
            var client = new HttpClient(handler);
            var json = JsonConvert.SerializeObject(requestBody);
            var response = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
            var responseData = response.Content.ReadAsStringAsync();

            //var l = JsonConvert.DeserializeObject<ProdutosPrevidenciaCompletoResponse>(responseData.Result);
            return JsonConvert.DeserializeObject<SecurityTokenResponse>(responseData.Result);
        }
    }
}
