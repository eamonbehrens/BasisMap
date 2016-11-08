using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Contract
    {
        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSet { get; set; }
        public Guid? Location { get; set; }
        public string SourceKey { get; set; }
        public string ContractNumber { get; set; }
        public Guid? LocationCommodity { get; set; }
        public Guid? Customer { get; set; }
        public Guid? Commodity { get; set; }
        public string ContractStatus { get; set; }
        public double? Quantity { get; set; }
        public Guid? ContractType { get; set; }
        public DateTime? DateWritten { get; set; }
        public string DeliveryTerms { get; set; }
        public string PurchaseSalesCode { get; set; }
        public string QuantityBase { get; set; }
        public string ShipToName { get; set; }
        public string CustomerContractNumber { get; set; }
        public Guid? TransportationMode { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string CommodityCode { get; set; }
        public Guid? MarketZone { get; set; }
        public Guid? Trader { get; set; }
        public decimal? AppliedCancelledUnits { get; set; }
        public decimal? BuyConversionRate { get; set; }
        public decimal? SellConversionRate { get; set; }
        public string Currency { get; set; }
        public decimal? Price { get; set; }
        public decimal? BasisPrice { get; set; }
        public decimal? FuturesPrice { get; set; }
        public decimal? ReleasePriceBasis { get; set; }
        public int? ContractLoads { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ContractType1 ContractTypeNavigation { get; set; }
        public virtual NameAddress1 CustomerNavigation { get; set; }
        public virtual DataSet DataSetNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual LocationCommodity LocationCommodityNavigation { get; set; }
        public virtual StateRegion MarketZoneNavigation { get; set; }
        public virtual TransportationMode1 TransportationModeNavigation { get; set; }
    }
}
