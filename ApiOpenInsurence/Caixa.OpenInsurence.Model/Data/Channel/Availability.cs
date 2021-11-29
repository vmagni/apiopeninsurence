﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class Availability
    {
        public List<AvailabilityStandards> Standards { get; set; }
        public bool IsPublicAccessAllowed { get; set; }

    }

    public class AvailabilityStandards
    {
        public string WeekDay { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
    }
}