using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DailyPositionTotal
    {
        public Guid Oid { get; set; }
        public Guid? LocationCommodity { get; set; }
        public string Variety { get; set; }
        public string Class { get; set; }
        public DateTime? PositionDate { get; set; }
        public decimal? InTransitInboundIncrease { get; set; }
        public decimal? InTransitOutboundIncrease { get; set; }
        public decimal? TerminalStorageIncrease { get; set; }
        public decimal? StockIncrease { get; set; }
        public decimal? HoldIncrease { get; set; }
        public decimal? GrainBankIncrease { get; set; }
        public decimal? OpenStorageIncrease { get; set; }
        public decimal? CustomerWarehouseReceiptIncrease { get; set; }
        public decimal? CompanyWarehouseReceiptIncrease { get; set; }
        public decimal? CompanyOwnedPaidIncrease { get; set; }
        public decimal? CompanyOwnedUnPaidIncrease { get; set; }
        public decimal? DelayedPriceIncrease { get; set; }
        public decimal? CashPositionIncrease { get; set; }
        public decimal? BasisPositionIncrease { get; set; }
        public decimal? InTransitInboundTotal { get; set; }
        public decimal? InTransitOutboundTotal { get; set; }
        public decimal? TerminalStorageTotal { get; set; }
        public decimal? StockAdjustment { get; set; }
        public decimal? HoldTotal { get; set; }
        public decimal? GrainBankTotal { get; set; }
        public decimal? OpenStorageTotal { get; set; }
        public decimal? CustomerWarehouseReceiptTotal { get; set; }
        public decimal? CompanyWarehouseReceiptTotal { get; set; }
        public decimal? CompanyOwnedPaidTotal { get; set; }
        public decimal? CompanyOwnedUnPaidTotal { get; set; }
        public decimal? DelayedPriceTotal { get; set; }
        public decimal? CashPositionTotal { get; set; }
        public decimal? BasisPositionTotal { get; set; }
        public Guid? DataSet { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
        public virtual LocationCommodity LocationCommodityNavigation { get; set; }
    }
}
