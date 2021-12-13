using Caixa.OpenInsurence.Model.Api.Shared;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IChannelsService
    {
        
        public Task<ValidaResponseDTO> GetBranches(ApiRequest request);
        public Task<ValidaResponseDTO> GetEletronicChannels(ApiRequest request);
        public Task<ValidaResponseDTO> GetPhoneChannels(ApiRequest request);

    }
}
