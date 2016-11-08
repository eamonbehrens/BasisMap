using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class BoardOfTrade1
    {
        public BoardOfTrade1()
        {
            CommodityBoardOfTrade = new HashSet<CommodityBoardOfTrade>();
            MarketSituation = new HashSet<MarketSituation>();
        }

        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSource { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? ParentBoardOfTrade { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<CommodityBoardOfTrade> CommodityBoardOfTrade { get; set; }
        public virtual ICollection<MarketSituation> MarketSituation { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
        public virtual BoardOfTrade1 ParentBoardOfTradeNavigation { get; set; }
        public virtual ICollection<BoardOfTrade1> InverseParentBoardOfTradeNavigation { get; set; }
    }
}
