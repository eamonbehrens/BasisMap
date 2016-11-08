using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class OptionMonth
    {
        public OptionMonth()
        {
            CommodityBoardOfTradeFromOptionMonthNavigation = new HashSet<CommodityBoardOfTrade>();
            CommodityBoardOfTradeToOptionMonthNavigation = new HashSet<CommodityBoardOfTrade>();
            DeliverySchedule1 = new HashSet<DeliverySchedule1>();
            MarketSituation = new HashSet<MarketSituation>();
        }

        public Guid Oid { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string Sort { get; set; }
        public string Display { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<CommodityBoardOfTrade> CommodityBoardOfTradeFromOptionMonthNavigation { get; set; }
        public virtual ICollection<CommodityBoardOfTrade> CommodityBoardOfTradeToOptionMonthNavigation { get; set; }
        public virtual ICollection<DeliverySchedule1> DeliverySchedule1 { get; set; }
        public virtual ICollection<MarketSituation> MarketSituation { get; set; }
    }
}
