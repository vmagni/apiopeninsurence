using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Person
{
    public class PersonReclaimTable
    {
        public int InitialMonthRange { get; set; }
        public int FinalMonthRange { get; set; }
        public long Percentage { get; set; }

    }
}
