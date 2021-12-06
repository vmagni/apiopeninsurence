using Caixa.OpenInsurence.Model.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Data.Api
{
    public class ProdutosVidaPfCompletoResponse
    {
        public bool sucesso { get; set; }
        public string mensagem { get; set; }
        public List<ProdutosVidaPfCompleto> dados { get; set; }
    }
}
