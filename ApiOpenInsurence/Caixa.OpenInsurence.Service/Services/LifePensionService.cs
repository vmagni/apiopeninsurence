using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Api.LifePension;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.Token;
using Caixa.OpenInsurence.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Services
{
    public class LifePensionService : ILifePensionService
    {
        private readonly IDatabaseService _databaseService;

        public LifePensionService (IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<LifePensionResponse> GetLifePension(ApiRequest request)
        {
            try
            {
                var dados = await _databaseService.GetProdutosVidaPfCompleto();
                LifePensionResponse response = new LifePensionResponse();

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
