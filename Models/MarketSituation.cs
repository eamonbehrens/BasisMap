using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class MarketSituation
    {
        public MarketSituation()
        {
            BuildBasis = new HashSet<BuildBasis>();
        }

        public Guid Oid { get; set; }
        public Guid Location { get; set; }
        public Guid Commodity { get; set; }
        public Guid? StateRegion { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public Guid? BoardOfTrade { get; set; }
        public Guid? OptionMonth { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? LocationCommodity { get; set; }
        public bool? IsFromLtas { get; set; }

        public virtual ICollection<BuildBasis> BuildBasis { get; set; }
        public virtual BoardOfTrade1 BoardOfTradeNavigation { get; set; }
        public virtual Commodity CommodityNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual LocationCommodity LocationCommodityNavigation { get; set; }
        public virtual OptionMonth OptionMonthNavigation { get; set; }
        public virtual StateRegion StateRegionNavigation { get; set; }
    }
}
