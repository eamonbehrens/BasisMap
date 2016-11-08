using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Product
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string FutureMonths { get; set; }
        public string Status { get; set; }
        public DateTime? LoadDate { get; set; }
        public int? PrdctId { get; set; }
        public int? PrdctDensityPerUom { get; set; }
        public string Uomabbv { get; set; }
        public double? ConversionFactor { get; set; }
    }
}
