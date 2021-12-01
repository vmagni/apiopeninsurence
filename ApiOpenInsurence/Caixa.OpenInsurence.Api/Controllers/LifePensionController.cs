using Caixa.OpenInsurence.Model.Api.LifePension;
using Caixa.OpenInsurence.Model.Api.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LifePensionController : ControllerBase
    {
        [HttpPost]
        public ActionResult<LifePensionResponse> LifePension([FromBody] Request request)
        {
            return Ok(new LifePensionResponse());
        }
    }
}
