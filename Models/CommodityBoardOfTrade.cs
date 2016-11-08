using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class CommodityBoardOfTrade
    {
        public Guid Oid { get; set; }
        public Guid? Commodity { get; set; }
        public Guid? BoardOfTrade { get; set; }
        public Guid? Dtnfeed { get; set; }
        public Guid? FromOptionMonth { get; set; }
        public Guid? ToOptionMonth { get; set; }
        public Guid? FromDtnfuture { get; set; }
        public Guid? ToDtnfuture { get; set; }
        public decimal? RollValue { get; set; }
        public decimal? TickerPriceConversionFactor { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual BoardOfTrade1 BoardOfTradeNavigation { get; set; }
        public virtual Commodity CommodityNavigation { get; set; }
        public virtual Dtnfeed DtnfeedNavigation { get; set; }
        public virtual Dtnfuture FromDtnfutureNavigation { get; set; }
        public virtual OptionMonth FromOptionMonthNavigation { get; set; }
        public virtual Dtnfuture ToDtnfutureNavigation { get; set; }
        public virtual OptionMonth ToOptionMonthNavigation { get; set; }
    }
}
