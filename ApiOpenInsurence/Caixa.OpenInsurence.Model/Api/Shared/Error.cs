using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class Error
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string RequestDateTime { get; set; }

    }
}
