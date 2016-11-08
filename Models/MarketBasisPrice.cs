using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class MarketBasisPrice
    {
        public Guid Oid { get; set; }
        public decimal? Basis { get; set; }
        public int? RiskCurveId { get; set; }
        public int? ProductLocaleId { get; set; }
        public string Product { get; set; }
        public Guid? Location { get; set; }
        public Guid? Commodity { get; set; }
        public string OptionMonth { get; set; }
        public Guid? Exchange { get; set; }
        public Guid? MarketZone { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Protien { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
