using Caixa.OpenInsurence.Model.Enums.LifePension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionProduct
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public SegmentEnum Segment { get; set; }
        public ModalityEnum Modality { get; set; }
        public string OptionalCoverage { get; set; }
        public LifePensionProductDetails productDetails { get; set; }
        public LifePensionMinimumRequirements MinimumRequirements { get; set; }
        public TargetAudienceEnum targetAudience { get; set; }
        
    }
}
