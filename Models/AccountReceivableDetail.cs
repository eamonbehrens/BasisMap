using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AccountReceivableDetail
    {
        public Guid Oid { get; set; }
        public Guid? AccountReceivable { get; set; }
        public Guid? ChartOfAccount { get; set; }
        public Guid? LocationCommodity { get; set; }
        public string DistributionNumber { get; set; }
        public double? DistrubutionAmount { get; set; }
        public DateTime? OriginationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public byte[] GllocationCode { get; set; }
        public Guid? DataSet { get; set; }

        public virtual AccountReceivable1 AccountReceivableNavigation { get; set; }
        public virtual ChartOfAccount ChartOfAccountNavigation { get; set; }
        public virtual DataSet DataSetNavigation { get; set; }
        public virtual LocationCommodity LocationCommodityNavigation { get; set; }
    }
}
