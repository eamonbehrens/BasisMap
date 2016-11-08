using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Dtnfeed
    {
        public Dtnfeed()
        {
            CommodityBoardOfTrade = new HashSet<CommodityBoardOfTrade>();
            Dtnhistory = new HashSet<Dtnhistory>();
        }

        public Guid Oid { get; set; }
        public string WebServiceUrl { get; set; }
        public string FeedName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Market { get; set; }
        public string FuturesMonths { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public decimal? TickerMultiplier { get; set; }
        public bool? IsHedgeable { get; set; }
        public decimal? PricingConversionFactor { get; set; }
        public decimal? TradePoundsPerUnit { get; set; }

        public virtual ICollection<CommodityBoardOfTrade> CommodityBoardOfTrade { get; set; }
        public virtual ICollection<Dtnhistory> Dtnhistory { get; set; }
    }
}
