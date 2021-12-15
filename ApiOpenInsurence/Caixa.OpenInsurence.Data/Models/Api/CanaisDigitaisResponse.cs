using Caixa.OpenInsurence.Data.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Data.Models.Api
{
    public class CanaisDigitaisResponse
    {
        public bool sucesso { get; set; }
        public string mensagem { get; set; }
        public List<CanaisDigitais> dados { get; set; }
    }
}
