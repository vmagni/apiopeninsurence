using Caixa.OpenInsurence.Model.Api.Person;
using Caixa.OpenInsurence.Model.Api.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonControlller : ControllerBase
    {
        [HttpPost]
        public ActionResult<PersonResponse> Person([FromBody] Request request)
        {
            return Ok(new PersonResponse());
        }
    }
}
