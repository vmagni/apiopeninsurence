using Caixa.OpenInsurence.Model.Api;
using Caixa.OpenInsurence.Model.Api.Channel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caixa.OpenInsurence.Model.Api.PensionPlan;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PensionPlansController : ControllerBase
    {
        [HttpPost]
        public ActionResult<PensionPlanResponse> PensionPlan([FromBody] ChannelsRequest request)
        {
            return Ok(new PensionPlanResponse());
        }

    }
}
