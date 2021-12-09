using Caixa.OpenInsurence.Model.Api.Channel;
using Microsoft.AspNetCore.Mvc;
using Caixa.OpenInsurence.Model.Api.PensionPlan;
using Caixa.OpenInsurence.Service.Interfaces;
using System.Threading.Tasks;
using Caixa.OpenInsurence.Model.Api.Shared;
using System;

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
        [ProducesResponseType(typeof(PensionPlanResponse), 200)] //OK
        [ProducesResponseType(typeof(ResponseError), 400)] //OK
        [ProducesResponseType(typeof(ResponseError), 401)]
        [ProducesResponseType(typeof(ResponseError), 403)]
        [ProducesResponseType(typeof(ResponseError), 404)] //OK
        [ProducesResponseType(typeof(ResponseError), 405)]
        [ProducesResponseType(typeof(ResponseError), 406)]
        [ProducesResponseType(typeof(ResponseError), 429)]
        [ProducesResponseType(typeof(ResponseError), 500)] //OK
        public async Task<IActionResult> GetPensionPlan([FromBody]ChannelsRequest request)
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

                var response = await _pensionPlansService.GetPensionPlan(request);


                if (response == null)
                {
                    return StatusCode(404,new ResponseError()
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
                    var pensionPlanDTO = response as PensionPlanDTO;

                    return this.Ok(new PensionPlanResponse(pensionPlanDTO.PensionPlan));
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
                    Errors = new Error(){
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
