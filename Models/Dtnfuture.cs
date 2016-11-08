using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Dtnfuture
    {
        public Dtnfuture()
        {
            CommodityBoardOfTradeFromDtnfutureNavigation = new HashSet<CommodityBoardOfTrade>();
            CommodityBoardOfTradeToDtnfutureNavigation = new HashSet<CommodityBoardOfTrade>();
        }

        public Guid Oid { get; set; }
        public string Ticker { get; set; }
        public string Vendor { get; set; }
        public string Market { get; set; }
        public string Status { get; set; }
        public string Fraction { get; set; }
        public string Description { get; set; }
        public decimal? Close { get; set; }
        public decimal? Open { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Volume { get; set; }
        public string Oi { get; set; }
        public Guid? Dtnhistory { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<CommodityBoardOfTrade> CommodityBoardOfTradeFromDtnfutureNavigation { get; set; }
        public virtual ICollection<CommodityBoardOfTrade> CommodityBoardOfTradeToDtnfutureNavigation { get; set; }
        public virtual Dtnhistory DtnhistoryNavigation { get; set; }
    }
}
