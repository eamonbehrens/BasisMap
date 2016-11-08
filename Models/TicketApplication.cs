using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TicketApplication
    {
        public TicketApplication()
        {
            TicketApplicationHistoryTicketApplicationCurrentNavigation = new HashSet<TicketApplicationHistory>();
            TicketApplicationHistoryTicketApplicationPriorNavigation = new HashSet<TicketApplicationHistory>();
            TicketApplicationRelationshipInboundTicketApplicationNavigation = new HashSet<TicketApplicationRelationship>();
            TicketApplicationRelationshipOutboundTicketApplicationNavigation = new HashSet<TicketApplicationRelationship>();
            TicketApplicationTranRelationshipInboundTicketApplicationNavigation = new HashSet<TicketApplicationTranRelationship>();
            TicketApplicationTranRelationshipOutboundTicketApplicationNavigation = new HashSet<TicketApplicationTranRelationship>();
            TicketDiscount = new HashSet<TicketDiscount>();
            TicketDiscountDetail = new HashSet<TicketDiscountDetail>();
        }

        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? Ticket { get; set; }
        public Guid? DeliverySchedule { get; set; }
        public string AdditionalDescription { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public Guid? Name { get; set; }
        public string Number { get; set; }
        public string ApplicationType { get; set; }
        public double? CalculationRate1 { get; set; }
        public double? CalculationRate2 { get; set; }
        public double? CalculationRate3 { get; set; }
        public double? CalculationRate4 { get; set; }
        public string CalculationTypes { get; set; }
        public string ContractLocationCode { get; set; }
        public string ContractPricingNumber { get; set; }
        public double? CustomerNetUnits { get; set; }
        public string DiscountCodes { get; set; }
        public string DiscountHtnumber { get; set; }
        public string DiscountPremiumTable { get; set; }
        public string ExpectedApplicationType { get; set; }
        public double? GrossUnits { get; set; }
        public string HeldIndicator { get; set; }
        public string InOutCode { get; set; }
        public Guid? Location { get; set; }
        public double? PosNetUnits { get; set; }
        public string PurchaseSalesCode { get; set; }
        public Guid? DataSet { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsInTransit { get; set; }
        public double? Fdisc { get; set; }
        public double? Ddisc { get; set; }

        public virtual ICollection<TicketApplicationHistory> TicketApplicationHistoryTicketApplicationCurrentNavigation { get; set; }
        public virtual ICollection<TicketApplicationHistory> TicketApplicationHistoryTicketApplicationPriorNavigation { get; set; }
        public virtual ICollection<TicketApplicationRelationship> TicketApplicationRelationshipInboundTicketApplicationNavigation { get; set; }
        public virtual ICollection<TicketApplicationRelationship> TicketApplicationRelationshipOutboundTicketApplicationNavigation { get; set; }
        public virtual ICollection<TicketApplicationTranRelationship> TicketApplicationTranRelationshipInboundTicketApplicationNavigation { get; set; }
        public virtual ICollection<TicketApplicationTranRelationship> TicketApplicationTranRelationshipOutboundTicketApplicationNavigation { get; set; }
        public virtual ICollection<TicketDiscount> TicketDiscount { get; set; }
        public virtual ICollection<TicketDiscountDetail> TicketDiscountDetail { get; set; }
        public virtual DataSet DataSetNavigation { get; set; }
        public virtual DeliverySchedule1 DeliveryScheduleNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual NameAddress1 NameNavigation { get; set; }
        public virtual Ticket TicketNavigation { get; set; }
    }
}
