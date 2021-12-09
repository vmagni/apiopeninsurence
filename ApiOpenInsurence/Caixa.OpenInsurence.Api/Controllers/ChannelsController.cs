using Caixa.OpenInsurence.Model.Api;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelsController : ControllerBase
    {
        private readonly IChannelsService _channelsService;
        private readonly IPensionPlansService _pensionPlansService;

        public ChannelsController(IChannelsService channelsService, IPensionPlansService pensionPlansService)
        {
            _channelsService = channelsService;
            _pensionPlansService = pensionPlansService;
        }

        [HttpPost]
        [Route("Branches")]
        public async Task<BranchChannelResponse> Branches(ApiRequest request)
        {
            var retorno = await _channelsService.GetBranches(request);

            return retorno;
        }

        [HttpPost]
        [Route("Eletronic")]
        public ActionResult<ElectronicChannelResponse> EletronicChannels([FromBody] ApiRequest request)
        {
            return Ok(new ElectronicChannelResponse());
        }

        [HttpPost]
        [Route("Phone")]
        public ActionResult<PhoneChannelResponse> PhoneChannels([FromBody] ApiRequest request)
        {
            return Ok(new PhoneChannelResponse());
        }
    }
}
