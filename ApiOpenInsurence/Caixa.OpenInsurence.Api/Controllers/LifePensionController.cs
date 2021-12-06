using Caixa.OpenInsurence.Model.Api.LifePension;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LifePensionController : ControllerBase
    {
        private readonly ILifePensionService _lifePensionService;
        public LifePensionController(ILifePensionService lifePensionService)
        {
            _lifePensionService = lifePensionService;
        }

        [HttpPost]
        public async Task<IActionResult> LifePension([FromBody] ApiRequest request)
        {
            var retorno = await _lifePensionService.GetLifePension(request);
            return Ok(new LifePensionResponse());
        }
    }
}
