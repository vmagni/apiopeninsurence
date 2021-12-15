using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Data.Models.Data
{
    public class CanaisDigitais
    {
        public string nomeCanal { get; set; }
        public string telCanal { get; set; }
        public object siteCanal { get; set; }
        public string HoraCanal { get; set; }
        public List<DiasSemanaCanal> DiasSemanaCanal { get; set; }
    }

    public class DiasSemanaCanal
    {
        public string DiaSemana { get; set; }
    }
}
