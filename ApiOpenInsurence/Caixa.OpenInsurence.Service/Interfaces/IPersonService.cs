using Caixa.OpenInsurence.Model.Api.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IPersonService
    {
        public Task<ValidaResponseDTO> GetPerson(ApiRequest request);
    }
}
