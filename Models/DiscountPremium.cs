using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DiscountPremium
    {
        public Guid Oid { get; set; }
        public Guid? DataSet { get; set; }
        public Guid? LocationCommodity { get; set; }
        public Guid? DiscountCode { get; set; }
        public Guid? DiscountEvent { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
        public virtual DiscountCode DiscountCodeNavigation { get; set; }
        public virtual DiscountEvent DiscountEventNavigation { get; set; }
        public virtual LocationCommodity LocationCommodityNavigation { get; set; }
    }
}
