using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AccountReceivable1
    {
        public AccountReceivable1()
        {
            AccountReceivableDetail = new HashSet<AccountReceivableDetail>();
        }

        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSet { get; set; }
        public Guid? Location { get; set; }
        public Guid? NameAddress { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
        public string Status { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public double? AmountApplied { get; set; }
        public string Number { get; set; }
        public string DocumentType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? AccountReceivablePaymentTerm { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<AccountReceivableDetail> AccountReceivableDetail { get; set; }
        public virtual AccountReceivablePaymentTerm AccountReceivablePaymentTermNavigation { get; set; }
        public virtual DataSet DataSetNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual NameAddress1 NameAddressNavigation { get; set; }
    }
}
