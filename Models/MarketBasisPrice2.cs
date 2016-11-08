using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class MarketBasisPrice2
    {
        public Guid Oid { get; set; }
        public decimal? Basis { get; set; }
        public string LocationCode { get; set; }
        public Guid? Location { get; set; }
        public string CommodityCode { get; set; }
        public Guid? Commodity { get; set; }
        public string OptionMonthSort { get; set; }
        public Guid? OptionMonth { get; set; }
        public string TradingBoard { get; set; }
        public Guid? Exchange { get; set; }
        public string MarketZoneCode { get; set; }
        public Guid? MarketZone { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Protein { get; set; }
        public bool? IsCurrent { get; set; }
    }
}
