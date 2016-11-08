using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class NameAddress1
    {
        public NameAddress1()
        {
            AccountPayable2 = new HashSet<AccountPayable2>();
            AccountPrepayment1 = new HashSet<AccountPrepayment1>();
            AccountPrepaymentDetail1 = new HashSet<AccountPrepaymentDetail1>();
            AccountReceivable1 = new HashSet<AccountReceivable1>();
            Contract = new HashSet<Contract>();
            GeneralLedgerDetail = new HashSet<GeneralLedgerDetail>();
            Ticket = new HashSet<Ticket>();
            TicketApplication = new HashSet<TicketApplication>();
        }

        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public string Address1 { get; set; }
        public string Description { get; set; }
        public string Remarks1 { get; set; }
        public string NameIdtype { get; set; }
        public string AccountTemp { get; set; }
        public string OtherNameReference { get; set; }
        public string Country { get; set; }
        public double? SalesCreditLimit { get; set; }
        public string Address2 { get; set; }
        public double? PurchaseCreditLimit { get; set; }
        public string NameDescription { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string Remarks2 { get; set; }
        public string NameId { get; set; }
        public byte? VoucherTermCode { get; set; }
        public string State { get; set; }
        public string StateLongCode { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public decimal? AcreageOwned { get; set; }
        public decimal? AcreageLeased { get; set; }
        public decimal? Storage { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<AccountPayable2> AccountPayable2 { get; set; }
        public virtual ICollection<AccountPrepayment1> AccountPrepayment1 { get; set; }
        public virtual ICollection<AccountPrepaymentDetail1> AccountPrepaymentDetail1 { get; set; }
        public virtual ICollection<AccountReceivable1> AccountReceivable1 { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<GeneralLedgerDetail> GeneralLedgerDetail { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual ICollection<TicketApplication> TicketApplication { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
