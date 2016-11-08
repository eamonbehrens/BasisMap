﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Location
    {
        public Location()
        {
            AccountPayable2 = new HashSet<AccountPayable2>();
            AccountPrepayment1 = new HashSet<AccountPrepayment1>();
            AccountPrepaymentDetail1 = new HashSet<AccountPrepaymentDetail1>();
            AccountReceivable1 = new HashSet<AccountReceivable1>();
            Contract = new HashSet<Contract>();
            DeliverySchedule1 = new HashSet<DeliverySchedule1>();
            GeneralLedgerDetail = new HashSet<GeneralLedgerDetail>();
            LocationCommodity = new HashSet<LocationCommodity>();
            MarketSituation = new HashSet<MarketSituation>();
            Ticket = new HashSet<Ticket>();
            TicketApplication = new HashSet<TicketApplication>();
        }

        public Guid Oid { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Fax { get; set; }
        public string PhoneNumber { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string State { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSource { get; set; }
        public Guid? ReportingLocation { get; set; }
        public string LookupCode { get; set; }
        public string OverrideInventoryCode { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<AccountPayable2> AccountPayable2 { get; set; }
        public virtual ICollection<AccountPrepayment1> AccountPrepayment1 { get; set; }
        public virtual ICollection<AccountPrepaymentDetail1> AccountPrepaymentDetail1 { get; set; }
        public virtual ICollection<AccountReceivable1> AccountReceivable1 { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<DeliverySchedule1> DeliverySchedule1 { get; set; }
        public virtual ICollection<GeneralLedgerDetail> GeneralLedgerDetail { get; set; }
        public virtual ICollection<LocationCommodity> LocationCommodity { get; set; }
        public virtual ICollection<MarketSituation> MarketSituation { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual ICollection<TicketApplication> TicketApplication { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
        public virtual Location ReportingLocationNavigation { get; set; }
        public virtual ICollection<Location> InverseReportingLocationNavigation { get; set; }
    }
}