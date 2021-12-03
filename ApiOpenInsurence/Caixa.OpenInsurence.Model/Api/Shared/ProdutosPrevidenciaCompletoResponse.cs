﻿using Caixa.OpenInsurence.Model.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class ProdutosPrevidenciaCompletoResponse
    {
        public bool sucesso { get; set; }
        public string mensagem { get; set;}
        public List<ProdutosPrevidenciaCompletos> dados { get; set; }
    }
}
