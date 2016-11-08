using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AccountPayable2
    {
        public AccountPayable2()
        {
            AccountPayableDetail = new HashSet<AccountPayableDetail>();
            Ticket = new HashSet<Ticket>();
        }

        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSet { get; set; }
        public Guid? Location { get; set; }
        public Guid? NameAddress { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string DocumentType { get; set; }
        public DateTime? VoucherDate { get; set; }
        public DateTime? DueDate { get; set; }
        public double? VoucherAmount { get; set; }
        public double? AmountApplied { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Status { get; set; }
        public string VoucherStatus { get; set; }
        public string TransactionStatus { get; set; }
        public string VoucherType { get; set; }
        public string UserOrderField1 { get; set; }
        public string UserOrderField2 { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<AccountPayableDetail> AccountPayableDetail { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual DataSet DataSetNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual NameAddress1 NameAddressNavigation { get; set; }
    }
}
