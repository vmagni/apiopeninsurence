using Caixa.OpenInsurence.Model.Api.PensionPlan;
using Caixa.OpenInsurence.Model.Api.Shared;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IPensionPlansService
    {
        public Task<ValidaResponseDTO> GetPensionPlan(ApiRequest request);
    }
}
