using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AccountPayableDetail
    {
        public Guid Oid { get; set; }
        public Guid? AccountPayable { get; set; }
        public Guid? LocationCommodity { get; set; }
        public Guid? ChartOfAccount { get; set; }
        public string GllocationCode { get; set; }
        public string GlaccountNumber { get; set; }
        public string DistributionNumber { get; set; }
        public double? DistributionAmount { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public DateTime? OriginationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public Guid? DataSet { get; set; }
        public string VoucherNumber { get; set; }

        public virtual AccountPayable2 AccountPayableNavigation { get; set; }
        public virtual ChartOfAccount ChartOfAccountNavigation { get; set; }
        public virtual DataSet DataSetNavigation { get; set; }
        public virtual LocationCommodity LocationCommodityNavigation { get; set; }
    }
}
