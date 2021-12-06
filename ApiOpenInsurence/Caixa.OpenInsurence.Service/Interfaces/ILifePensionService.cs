using Caixa.OpenInsurence.Model.Api.LifePension;
using Caixa.OpenInsurence.Model.Api.Shared;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface ILifePensionService
    {
        public Task<LifePensionResponse> GetLifePension(ApiRequest request);
    }
}
