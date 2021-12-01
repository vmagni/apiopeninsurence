using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class ResponseError
    {
        public Error Error { get; set; }
        public MetaPaginated Meta { get; set; }

    }
}
