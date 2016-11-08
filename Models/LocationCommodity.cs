using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class LocationCommodity
    {
        public LocationCommodity()
        {
            AccountPayableDetail = new HashSet<AccountPayableDetail>();
            AccountReceivableDetail = new HashSet<AccountReceivableDetail>();
            Contract = new HashSet<Contract>();
            DailyPositionTotal = new HashSet<DailyPositionTotal>();
            DiscountPremium = new HashSet<DiscountPremium>();
            MarketSituation = new HashSet<MarketSituation>();
            Ticket = new HashSet<Ticket>();
        }

        public Guid Oid { get; set; }
        public Guid? Location { get; set; }
        public Guid? Commodity { get; set; }
        public string DefaultBoard { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public double? TradePoundsPerUnit { get; set; }
        public string TradeUnitOfMeasure { get; set; }
        public double? PositionPoundsPerUnit { get; set; }
        public string PositionUnitOfMeasure { get; set; }
        public double? LedgerPoundsPerUnit { get; set; }
        public string LedgerUnitOfMeasure { get; set; }
        public decimal? FuturesConversionFactor { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<AccountPayableDetail> AccountPayableDetail { get; set; }
        public virtual ICollection<AccountReceivableDetail> AccountReceivableDetail { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<DailyPositionTotal> DailyPositionTotal { get; set; }
        public virtual ICollection<DiscountPremium> DiscountPremium { get; set; }
        public virtual ICollection<MarketSituation> MarketSituation { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual Commodity CommodityNavigation { get; set; }
        public virtual DataSourceSystemGroup DataSourceSystemGroupNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
    }
}
