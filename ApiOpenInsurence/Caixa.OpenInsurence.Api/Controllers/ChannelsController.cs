using Caixa.OpenInsurence.Model.Api;
using Caixa.OpenInsurence.Model.Api.Channel;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelsController : ControllerBase
    {
        private readonly IChannelsService _channelsService;
        private readonly IPensionPlansService _pensionPlansService;

        public ChannelsController(IChannelsService channelsService, IPensionPlansService pensionPlansService)
        {
            _channelsService = channelsService;
            _pensionPlansService = pensionPlansService;
        }

        /// <summary>
        /// Retorna as agências.
        /// </summary>
        [HttpPost]
        [Route("Branches")]
        [ProducesResponseType(typeof(BranchChannelResponse), 200)] //OK
        [ProducesResponseType(typeof(ResponseError), 400)] //OK
        [ProducesResponseType(typeof(ResponseError), 401)]
        [ProducesResponseType(typeof(ResponseError), 403)]
        [ProducesResponseType(typeof(ResponseError), 404)] //OK
        [ProducesResponseType(typeof(ResponseError), 405)]
        [ProducesResponseType(typeof(ResponseError), 406)]
        [ProducesResponseType(typeof(ResponseError), 429)]
        [ProducesResponseType(typeof(ResponseError), 500)] //OK
        public async Task<IActionResult> Branches(ApiRequest request)
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
                            Title = "BranchChannels"
                        },
                        Meta = new MetaPaginated()
                        {
                            TotalPages = request.Page,
                            TotalRecords = request.PageSize
                        }
                    });
                }

                var response = await _channelsService.GetBranches(request);


                if (response == null)
                {
                    return StatusCode(404, new ResponseError()
                    {
                        Errors = new Error()
                        {
                            Code = "404",
                            Detail = "",
                            RequestDateTime = new DateTime(),
                            Title = "BranchChannels"
                        },
                        Meta = new MetaPaginated()
                        {
                            TotalPages = request.Page,
                            TotalRecords = request.PageSize
                        }

                    });
                }

                if (response.ResponseCode == 200)
                {
                    var channelsDTO = response as BranchChannelsDTO;

                    return this.Ok(new BranchChannelResponse(channelsDTO.BranchChannelsResponse));
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
                            Title = "BranchChannels"
                        },
                        Meta = new MetaPaginated()
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

        /// <summary>
        /// Retorna os canais de atendimento eletrônico.
        /// </summary>
        [HttpPost]
        [Route("Eletronic")]
        public async Task<IActionResult> EletronicChannels([FromBody] ApiRequest request)
        {
            return Ok(new ElectronicChannelResponse());
        }

        /// <summary>
        /// Retorna os canais de atendimento telefônico.
        /// </summary>
        [HttpPost]
        [Route("Phone")]
        [ProducesResponseType(typeof(BranchChannelResponse), 200)] //OK
        [ProducesResponseType(typeof(ResponseError), 400)] //OK
        [ProducesResponseType(typeof(ResponseError), 401)]
        [ProducesResponseType(typeof(ResponseError), 403)]
        [ProducesResponseType(typeof(ResponseError), 404)] //OK
        [ProducesResponseType(typeof(ResponseError), 405)]
        [ProducesResponseType(typeof(ResponseError), 406)]
        [ProducesResponseType(typeof(ResponseError), 429)]
        [ProducesResponseType(typeof(ResponseError), 500)] //OK
        public async Task<IActionResult> PhoneChannels([FromBody] ApiRequest request)
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
                            Title = "Branches"
                        },
                        Meta = new MetaPaginated()
                        {
                            TotalPages = request.Page,
                            TotalRecords = request.PageSize
                        }
                    });
                }

                var response = await _channelsService.GetPhoneChannels(request);


                if (response == null)
                {
                    return StatusCode(404, new ResponseError()
                    {
                        Errors = new Error()
                        {
                            Code = "404",
                            Detail = "",
                            RequestDateTime = new DateTime(),
                            Title = "PhoneChannels"
                        },
                        Meta = new MetaPaginated()
                        {
                            TotalPages = request.Page,
                            TotalRecords = request.PageSize
                        }

                    });
                }

                if (response.ResponseCode == 200)
                {
                    var channelsDTO = response as PhoneChannelsDTO;

                    return this.Ok(new PhoneChannelResponse(channelsDTO.PhoneChannelResponse));
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
                            Title = "PhoneChannels"
                        },
                        Meta = new MetaPaginated()
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
                        Title = "PhoneChannels"
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
