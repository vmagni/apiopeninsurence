using Caixa.OpenInsurence.Model.Api.Channel;
using Caixa.OpenInsurence.Model.Api.PensionPlan;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IPensionPlansService
    {
        public Task<PensionPlanResponse> GetPensionPlan(ChannelsRequest request);
    }
}
