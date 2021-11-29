using Caixa.OpenInsurence.Model.Api;
using Caixa.OpenInsurence.Model.Api.Channel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Channels.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelsController : ControllerBase
    {

        private readonly ILogger<ChannelsController> _logger;

        public ChannelsController(ILogger<ChannelsController> logger)
        {
            _logger = logger;
        }

        

        [HttpPost]
        [Route("branches")]
        public ActionResult<BranchChannelResponse> Branches([FromBody] ChannelsRequest request)
        {
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
