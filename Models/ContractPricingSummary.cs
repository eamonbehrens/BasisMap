using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ContractPricingSummary
    {
        public decimal SequenceNbr { get; set; }
        public DateTime ExtractionDatetime { get; set; }
        public Guid? ContractType { get; set; }
        public string ContractType1 { get; set; }
        public string PlcId { get; set; }
        public Guid? Commodity { get; set; }
        public string CommodityId { get; set; }
        public string CurrencyCode { get; set; }
        public string BuyingSellingUomCode { get; set; }
        public string PricingUomCode { get; set; }
        public Guid? Contract { get; set; }
        public int ContractNbr { get; set; }
        public short DeliveryYear { get; set; }
        public short DeliveryMonth { get; set; }
        public string MarketMonth { get; set; }
        public decimal PricedQuantity { get; set; }
        public decimal? AveragePrice { get; set; }
        public decimal BasisQuantity { get; set; }
        public decimal? AverageBasis { get; set; }
        public decimal FuturesOnlyQuantity { get; set; }
        public decimal? AverageFuture { get; set; }
        public decimal TbdQuantity { get; set; }
        public string DeliveryMonthName { get; set; }
        public DateTime? Deliverystart { get; set; }
        public DateTime? Deliveryend { get; set; }
        public string Optionmonth { get; set; }
        public string Reportoptionmonth { get; set; }
        public DateTime? Reportdeliverydate { get; set; }
        public Guid? Location { get; set; }
    }
}
