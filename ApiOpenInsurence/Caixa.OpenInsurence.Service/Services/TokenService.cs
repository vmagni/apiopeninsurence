using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.Token;
using Caixa.OpenInsurence.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Services
{
    public class TokenService : ITokenService
    {
        public async Task<object> GenerateToken(string url, SecurityTokenRequest request)
        {
            var retorno = await RequestToken(url, request);
            //var tokenResponse = retorno.Dados;
            //return new SecurityToken()
            //{
            //    Username = request.Username,
            //    SHArsaKey = GenerateSHArsKey(tokenResponse.Mapdata, tokenResponse.KeyData)
            //};

            return retorno;
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

        private async Task<object> RequestToken(string url, SecurityTokenRequest requestBody)
        {
            //SSL Certification Invalid Bypass
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            //REQUEST
            var client = new HttpClient(handler);
            var json = JsonConvert.SerializeObject(requestBody);
            var response = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
            var responseData = response.Content.ReadAsStringAsync();

            var a = JsonConvert.DeserializeObject(responseData.Result);
            var c = ((Newtonsoft.Json.Linq.JToken)a).Root;
            //var b = JsonConvert.DeserializeObject((Newtonsoft.Json.Linq.JToken)a).Root);

            var l = JsonConvert.DeserializeObject<ProdutosPrevidenciaCompletoResponse>(responseData.Result);


            //return JsonConvert.DeserializeObject<SecurityTokenResponse>(responseData.Result);

            return responseData.Result;
        }
    }
}
