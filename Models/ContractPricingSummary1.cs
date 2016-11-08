using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ContractPricingSummary1
    {
        public Guid Oid { get; set; }
        public string PurchaseSalesCode { get; set; }
        public Guid? Location { get; set; }
        public Guid? Commodity { get; set; }
        public string CurrencyCode { get; set; }
        public string UnitCode { get; set; }
        public string PricingUnitCode { get; set; }
        public Guid? Contract { get; set; }
        public string Delivery { get; set; }
        public string Ticker { get; set; }
        public decimal PricedQuantity { get; set; }
        public decimal? Price { get; set; }
        public decimal BasisQuantity { get; set; }
        public decimal? Basis { get; set; }
        public decimal FuturesQuantity { get; set; }
        public decimal? FuturesPrice { get; set; }
        public decimal Tbdquantity { get; set; }
        public DateTime? DeliveryStart { get; set; }
        public DateTime? DeliveryEnd { get; set; }
        public DateTime? ReportDeliveryDate { get; set; }
        public string OptionMonth { get; set; }
        public string ReportOptionMonth { get; set; }
    }
}
