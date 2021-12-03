using Caixa.OpenInsurence.Model.Api;
using Caixa.OpenInsurence.Model.Api.Channel;
using Caixa.OpenInsurence.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelsController : ControllerBase
    {

        private readonly ILogger<ChannelsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IChannelsService _channelsService;

        private string username;
        private string url;

        public ChannelsController(ILogger<ChannelsController> logger, 
                                  IConfiguration configuration
                                  ,IChannelsService channelsService)
        {
            _logger = logger;
            _configuration = configuration;
            _channelsService = channelsService;

            username = configuration.GetSection("TokenUsername").Value;
            url = configuration.GetSection("Urls:Token").Value;
        }

        

        

        [HttpPost]
        [Route("branches")]
        public async Task<IActionResult> Branches([FromBody] ChannelsRequest request)
        {
            var retorno = await _channelsService.GetBranches(url, username);
            return Ok(new BranchChannelResponse());
        }

        [HttpPost]
        [Route("eletronic")]
        public ActionResult<ElectronicChannelResponse> EletronicChannels([FromBody] ChannelsRequest request)
        {
            return Ok(new ElectronicChannelResponse());
        }

        [HttpPost]
        [Route("phone")]
        public ActionResult<PhoneChannelResponse> PhoneChannels([FromBody] ChannelsRequest request)
        {
            return Ok(new PhoneChannelResponse());
        }
    }
}
