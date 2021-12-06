using Caixa.OpenInsurence.Data.Api;
using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Data.Token;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Data.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly ITokenService _tokenService;

        public DatabaseService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public async Task<ProdutosPrevidenciaCompletoResponse> GetProdutosPrevidenciaCompleto()
        {
            var token = await _tokenService.GenerateToken(TokenFunctionEnum.OPIN_ConsultaProdutosPrevidenciaCompleto);
            var url = "https://appprevhm.caixavidaeprevidencia.com.br/webapi/api/OpenInsurance/OPIN_ConsultaProdutosPrevidenciaCompleto";


            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            //REQUEST
            var client = new HttpClient(handler);

            var json = JsonConvert.SerializeObject(token);

            var response = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));

            var responseData = response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ProdutosPrevidenciaCompletoResponse>(responseData.Result);
        }

        public async Task<ProdutosVidaPfCompletoResponse> GetProdutosVidaPfCompleto()
        {
            throw new NotImplementedException();
        }
    }
}
