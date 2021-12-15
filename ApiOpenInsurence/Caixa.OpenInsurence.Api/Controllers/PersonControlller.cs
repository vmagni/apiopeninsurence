using Caixa.OpenInsurence.Model.Api.Person;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("products-services/v1")]
    public class PersonControlller : ControllerBase
    {

        private readonly IPersonService _personService;

        public PersonControlller(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        [Route("person")]
        [ProducesResponseType(typeof(PersonResponse), 200)] //OK
        [ProducesResponseType(typeof(ResponseError), 400)] //OK
        [ProducesResponseType(typeof(ResponseError), 401)]
        [ProducesResponseType(typeof(ResponseError), 403)]
        [ProducesResponseType(typeof(ResponseError), 404)] //OK
        [ProducesResponseType(typeof(ResponseError), 405)]
        [ProducesResponseType(typeof(ResponseError), 406)]
        [ProducesResponseType(typeof(ResponseError), 429)]
        [ProducesResponseType(typeof(ResponseError), 500)] //OK
        public async Task<IActionResult> person([FromBody] ApiRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return BadRequest(new ResponseError()
                    {
                        Errors = new Error()
                        {
                            Code = "400",
                            Detail = "Erro ao realizar validações de parametros",
                            RequestDateTime = new DateTime(),
                            Title = "GetPensionPlan"
                        },
                        Meta =new MetaPaginated()
                        {
                            TotalPages = request.Page,
                            TotalRecords = request.PageSize
                        }
                    });
                }

                var response = await _personService.GetPerson(request);


                if (response == null)
                {
                    return StatusCode(404, new ResponseError()
                    {
                        Errors = new Error()
                        {
                            Code = "404",
                            Detail = "",
                            RequestDateTime = new DateTime(),
                            Title = "GetPensionPlan"
                        },
                        Meta =new MetaPaginated()
                        {
                            TotalPages = request.Page,
                            TotalRecords = request.PageSize
                        }

                    });
                }

                if (response.ResponseCode == 200)
                {
                    var personDTO = response as PersonDTO;

                    return this.Ok(new PersonResponse(personDTO.Person));
                }
                else
                {
                    return StatusCode(response.ResponseCode, new ResponseError()
                    {
                        Errors = new Error()
                        {
                            Code = response.ResponseCode.ToString(),
                            Detail = response.ResponseMessage,
                            RequestDateTime = new DateTime(),
                            Title = "GetPensionPlan"
                        },
                        Meta =new MetaPaginated()
                        {
                            TotalPages = request.Page,
                            TotalRecords = request.PageSize
                        }

                    });
                }

            }
            catch (Exception ex)
            {

                return StatusCode(500, new ResponseError()
                {
                    Errors = new Error()
                    {
                        Code = "500",
                        Detail = "Ocorreu um Erro inesperado e não tratado",
                        RequestDateTime = new DateTime(),
                        Title = "GetPensionPlan"
                    },
                    Meta = new MetaPaginated()
                    {
                        TotalPages = request.Page,
                        TotalRecords = request.PageSize
                    }

                });

            }
        }
    }
}
