using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            TicketApplication = new HashSet<TicketApplication>();
            TicketDiscountDetail = new HashSet<TicketDiscountDetail>();
        }

        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public double? AdditionalFreightAmount { get; set; }
        public Guid? Commodity { get; set; }
        public string DestinationLocationCode { get; set; }
        public DateTime? EntryDate { get; set; }
        public double? FreightRate { get; set; }
        public string FreightStatus { get; set; }
        public string VoucherNumber { get; set; }
        public string InOutCode { get; set; }
        public Guid? Location { get; set; }
        public string SampleNumber { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public Guid? ShipperName { get; set; }
        public string ShipToFreightId { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public string TicketType { get; set; }
        public double? TotalNetUnits { get; set; }
        public Guid? TransportationMode { get; set; }
        public string VehicleId { get; set; }
        public Guid? DataSet { get; set; }
        public Guid? DeliverySchedule { get; set; }
        public double? Fdisc { get; set; }
        public double? Ddisc { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsFreightReady { get; set; }
        public Guid? StockStorageStateRegion { get; set; }
        public Guid? CrossStockStorageStateRegion { get; set; }
        public Guid? AccountPayable { get; set; }
        public Guid? LocationCommodity { get; set; }
        public string StockStorageCode { get; set; }
        public string CrossStockCode { get; set; }
        public double? FreightWeight { get; set; }
        public string OtherReferenceNumber { get; set; }
        public string PrimaryTicketNumber { get; set; }

        public virtual ICollection<TicketApplication> TicketApplication { get; set; }
        public virtual ICollection<TicketDiscountDetail> TicketDiscountDetail { get; set; }
        public virtual AccountPayable2 AccountPayableNavigation { get; set; }
        public virtual Commodity CommodityNavigation { get; set; }
        public virtual StateRegion CrossStockStorageStateRegionNavigation { get; set; }
        public virtual DataSet DataSetNavigation { get; set; }
        public virtual DeliverySchedule1 DeliveryScheduleNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual LocationCommodity LocationCommodityNavigation { get; set; }
        public virtual NameAddress1 ShipperNameNavigation { get; set; }
        public virtual StateRegion StockStorageStateRegionNavigation { get; set; }
        public virtual TransportationMode1 TransportationModeNavigation { get; set; }
    }
}
