using Caixa.OpenInsurence.Model.Api;
using Caixa.OpenInsurence.Model.Api.Shared;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IChannelsService
    {
        
        public Task<BranchChannelResponse> GetBranches(ApiRequest request);
        public Task<ElectronicChannelResponse> GetEletronicChannels(ApiRequest request);
        public Task<PhoneChannelResponse> GetPhoneChannels(ApiRequest request);

    }
}
