using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class ResponseError
    {
        public Error Errors { get; set; }
        public MetaPaginated Meta { get; set; }

    }
}
