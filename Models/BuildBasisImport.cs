using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class BuildBasisImport
    {
        public Guid Oid { get; set; }
        public Guid? Dataset { get; set; }
        public Guid? Location { get; set; }
        public Guid? Commodity { get; set; }
        public Guid? LocationCommodity { get; set; }
        public Guid? OptionMonth { get; set; }
        public Guid? MarketZone { get; set; }
        public Guid? TransportationMode { get; set; }
        public Guid? BoardOfTrade { get; set; }
        public Guid? MarketSituation { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double? Basis { get; set; }
        public Guid? TargetOptionMonth { get; set; }
        public DateTime? TargetDeliveryDate { get; set; }
        public Guid? TargetMarketSituation { get; set; }
        public DateTime? TrueMonthEnd { get; set; }
    }
}
