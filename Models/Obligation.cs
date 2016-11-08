using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Obligation
    {
        public Guid Oid { get; set; }
        public Guid? DataSet { get; set; }
        public int? ObDlDtlDlHdrId { get; set; }
        public short? ObDlDtlId { get; set; }
        public short? ObId { get; set; }
        public DateTime? ObFrmDte { get; set; }
        public DateTime? ObToDte { get; set; }
        public double? ObQty { get; set; }
        public string ObStts { get; set; }
        public double? AppliedQuantity { get; set; }
        public double? RemainingQuantity { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public decimal? PerUnitValue { get; set; }
        public decimal? MarketPerUnitValue { get; set; }
        public double? RawAppliedQuantity { get; set; }
        public double? RawRemainingQuantity { get; set; }
        public double? Price { get; set; }
        public double? Freight { get; set; }
        public double? Basis { get; set; }
        public string DlDtlSpplyDmnd { get; set; }
        public string LcleAbbrvtn { get; set; }
        public string PricedBasis { get; set; }
        public string HasPrimaryInterimProvision { get; set; }
        public double? MarketZoneBasis { get; set; }
        public decimal? WorkBenchMarketPerUnitValue { get; set; }
        public int? RwPrceLcleId { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
    }
}
