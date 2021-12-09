using Caixa.OpenInsurence.Data.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Data.Models.Api
{
    public  class AgenciasCaixaResponse
    {
        public bool sucesso { get; set; }
        public string mensagem { get; set; }
        public List<AgenciasCaixa> dados { get; set; }
    }
}
