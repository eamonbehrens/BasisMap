using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DeliverySchedule1
    {
        public DeliverySchedule1()
        {
            Ticket = new HashSet<Ticket>();
            TicketApplication = new HashSet<TicketApplication>();
        }

        public Guid Oid { get; set; }
        public Guid? DataSet { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? Contract { get; set; }
        public string ScheduleNumber { get; set; }
        public Guid? Location { get; set; }
        public string AppliedStatus { get; set; }
        public DateTime? DeliveryStart { get; set; }
        public DateTime? DeliveryEnd { get; set; }
        public DateTime? OriginalDeliveryEnd { get; set; }
        public DateTime? OptionMonthDate { get; set; }
        public Guid? OptionMonth { get; set; }
        public Guid? OriginalOptionMonth { get; set; }
        public string OptionMonthCode { get; set; }
        public Guid? BoardOfTrade { get; set; }
        public string PriorityLevel { get; set; }
        public double? BasisPrice { get; set; }
        public double? OriginalBasisPrice { get; set; }
        public decimal? MarketSpread { get; set; }
        public double? SchedulePrice { get; set; }
        public double? OriginalSchedulePrice { get; set; }
        public string DestinationLocation { get; set; }
        public Guid? MarketRegion { get; set; }
        public double? SettledUnits { get; set; }
        public double? AppliedUnits { get; set; }
        public double? RemainingUnits { get; set; }
        public string PricingStatus { get; set; }
        public Guid? StateRegion { get; set; }
        public string StateCode { get; set; }
        public double? FuturesPrice { get; set; }
        public double? OriginalFuturesPrice { get; set; }
        public double? FreightPrice { get; set; }
        public double? OriginalFreightPrice { get; set; }
        public string ShipperId { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string PurchaseSalesCode { get; set; }
        public int? ScheduledLoads { get; set; }
        public string Territory { get; set; }
        public double? ScheduledUnits { get; set; }
        public int? AppliedLoads { get; set; }
        public string SalesPerson { get; set; }
        public DateTime? PricingDate { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string ReportOptionMonth { get; set; }
        public DateTime? ReportOptionMonthDate { get; set; }
        public DateTime? ReportDeliveryDate { get; set; }
        public string ContractNumber { get; set; }
        public string Exchange { get; set; }
        public string Country { get; set; }
        public string Ticker { get; set; }
        public DateTime? HistoryDate { get; set; }
        public decimal? ScheduledPounds { get; set; }
        public decimal? SettledPounds { get; set; }
        public decimal? AppliedPounds { get; set; }
        public decimal? RemainingPounds { get; set; }
        public decimal? ScheduledBushels { get; set; }
        public decimal? SettledBushels { get; set; }
        public decimal? AppliedBushels { get; set; }
        public decimal? RemainingBushels { get; set; }
        public Guid? MarketSituation { get; set; }
        public Guid? Dtnfuture { get; set; }
        public DateTime? PriorDeliveryEnd { get; set; }
        public Guid? PriorOptionMonth { get; set; }
        public Guid? PriorMarketSituation { get; set; }
        public DateTime? CurrentDeliveryEnd { get; set; }
        public Guid? CurrentOptionMonth { get; set; }
        public Guid? CurrentMarketSituation { get; set; }
        public Guid? BasisZone { get; set; }
        public bool? IsFlatPriced { get; set; }
        public DateTime? RolledDeliveryEnd { get; set; }
        public Guid? RolledOptionMonth { get; set; }
        public Guid? RolledMarketSituation { get; set; }
        public Guid? RolledBuildBasis { get; set; }
        public double? RolledBasisPrice { get; set; }
        public double? RolledFuturesPrice { get; set; }
        public string BrokerReferenceNumber { get; set; }
        public decimal? ReleasePriceBasis { get; set; }
        public string VehicleType { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual ICollection<TicketApplication> TicketApplication { get; set; }
        public virtual StateRegion BasisZoneNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual OptionMonth OptionMonthNavigation { get; set; }
    }
}
