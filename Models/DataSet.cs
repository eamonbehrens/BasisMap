using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DataSet
    {
        public DataSet()
        {
            AccountPayable2 = new HashSet<AccountPayable2>();
            AccountPayableDetail = new HashSet<AccountPayableDetail>();
            AccountPrepayment1 = new HashSet<AccountPrepayment1>();
            AccountPrepaymentDetail1 = new HashSet<AccountPrepaymentDetail1>();
            AccountReceivable1 = new HashSet<AccountReceivable1>();
            AccountReceivableDetail = new HashSet<AccountReceivableDetail>();
            BuildBasis = new HashSet<BuildBasis>();
            Contract = new HashSet<Contract>();
            Contract3 = new HashSet<Contract3>();
            DailyPositionTotal = new HashSet<DailyPositionTotal>();
            DeliverySchedule2 = new HashSet<DeliverySchedule2>();
            DiscountPremium = new HashSet<DiscountPremium>();
            ExportCatalog = new HashSet<ExportCatalog>();
            Obligation = new HashSet<Obligation>();
            OptionType = new HashSet<OptionType>();
            OrderType = new HashSet<OrderType>();
            PositionType = new HashSet<PositionType>();
            Ticket = new HashSet<Ticket>();
            TicketApplication = new HashSet<TicketApplication>();
            TicketApplicationHistoryDataSetCurrentNavigation = new HashSet<TicketApplicationHistory>();
            TicketApplicationHistoryDataSetPriorNavigation = new HashSet<TicketApplicationHistory>();
            TicketApplicationRelationship = new HashSet<TicketApplicationRelationship>();
            TicketApplicationTranRelationship = new HashSet<TicketApplicationTranRelationship>();
            TicketDiscount = new HashSet<TicketDiscount>();
            TicketDiscountDetail = new HashSet<TicketDiscountDetail>();
        }

        public Guid Oid { get; set; }
        public Guid DataSource { get; set; }
        public Guid ReportExtract { get; set; }
        public bool IsActive { get; set; }
        public DateTime? PeriodReportingStart { get; set; }
        public DateTime? PeriodReportingEnd { get; set; }
        public DateTime? SourceReportingStart { get; set; }
        public DateTime? SourceReportingEnd { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<AccountPayable2> AccountPayable2 { get; set; }
        public virtual ICollection<AccountPayableDetail> AccountPayableDetail { get; set; }
        public virtual ICollection<AccountPrepayment1> AccountPrepayment1 { get; set; }
        public virtual ICollection<AccountPrepaymentDetail1> AccountPrepaymentDetail1 { get; set; }
        public virtual ICollection<AccountReceivable1> AccountReceivable1 { get; set; }
        public virtual ICollection<AccountReceivableDetail> AccountReceivableDetail { get; set; }
        public virtual ICollection<BuildBasis> BuildBasis { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<Contract3> Contract3 { get; set; }
        public virtual ICollection<DailyPositionTotal> DailyPositionTotal { get; set; }
        public virtual ICollection<DeliverySchedule2> DeliverySchedule2 { get; set; }
        public virtual ICollection<DiscountPremium> DiscountPremium { get; set; }
        public virtual ICollection<ExportCatalog> ExportCatalog { get; set; }
        public virtual ICollection<Obligation> Obligation { get; set; }
        public virtual ICollection<OptionType> OptionType { get; set; }
        public virtual ICollection<OrderType> OrderType { get; set; }
        public virtual ICollection<PositionType> PositionType { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual ICollection<TicketApplication> TicketApplication { get; set; }
        public virtual ICollection<TicketApplicationHistory> TicketApplicationHistoryDataSetCurrentNavigation { get; set; }
        public virtual ICollection<TicketApplicationHistory> TicketApplicationHistoryDataSetPriorNavigation { get; set; }
        public virtual ICollection<TicketApplicationRelationship> TicketApplicationRelationship { get; set; }
        public virtual ICollection<TicketApplicationTranRelationship> TicketApplicationTranRelationship { get; set; }
        public virtual ICollection<TicketDiscount> TicketDiscount { get; set; }
        public virtual ICollection<TicketDiscountDetail> TicketDiscountDetail { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
        public virtual ReportExtract ReportExtractNavigation { get; set; }
    }
}
