using Caixa.OpenInsurence.Model.Api.Channel;
using Microsoft.AspNetCore.Mvc;
using Caixa.OpenInsurence.Model.Api.PensionPlan;
using Caixa.OpenInsurence.Service.Interfaces;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PensionPlansController : ControllerBase
    {
        private readonly IPensionPlansService _pensionPlansService;

        public PensionPlansController(IPensionPlansService pensionPlansService)
        {
            _pensionPlansService = pensionPlansService;
        }

        [HttpPost]
        [Route("GetPensionPlan")]
        public async Task<PensionPlanResponse> GetPensionPlan(ChannelsRequest request)
        {
            var response = await _pensionPlansService.GetPensionPlan(request);

            return response;
        }

    }
}
