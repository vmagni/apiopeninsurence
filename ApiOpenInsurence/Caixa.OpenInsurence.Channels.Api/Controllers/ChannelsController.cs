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
        public ActionResult<BranchesResponse> Branches([FromBody] ChannelsRequest request)
        {
            return Ok(new BranchesResponse());
        }

        [HttpPost]
        [Route("eletronic")]
        public ActionResult<BranchesResponse> EletronicChannels([FromBody] ChannelsRequest request)
        {
            return Ok(new BranchesResponse());
        }

        [HttpPost]
        [Route("phone")]
        public ActionResult<BranchesResponse> PhoneChannels([FromBody] ChannelsRequest request)
        {
            return Ok(new BranchesResponse());
        }
    }
}
