using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class LinksPaginated
    {
        public string Self { get; set; }
        public string First { get; set; }
        public string Prev { get; set; }
        public string Next { get; set; }
        public string Las { get; set; }

    }
}
