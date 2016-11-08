using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AccountPrepaymentDetail1
    {
        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSet { get; set; }
        public Guid? NameAddress { get; set; }
        public Guid? Location { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceDescription { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public double? InvoiceAmount { get; set; }
        public string CashSourceCode { get; set; }
        public string IvcLocation { get; set; }
        public string IvcNumber { get; set; }
        public string VoidPaymentCode { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual NameAddress1 NameAddressNavigation { get; set; }
    }
}
