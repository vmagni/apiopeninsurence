using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class BranchPostalAddress
    {
        public string Address { get; set; }
        public string AdditionalInfo { get; set; }
        public string DistrictName { get; set; }
        public string TownName { get; set; }
        public string IbgeCode { get; set; }
        public string CountrySubDivision { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public BranchCoordinates GeographicCoordinates { get; set; }
    }


    public class BranchCoordinates
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
