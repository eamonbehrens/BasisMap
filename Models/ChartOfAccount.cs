using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ChartOfAccount
    {
        public ChartOfAccount()
        {
            AccountPayableDetail = new HashSet<AccountPayableDetail>();
            AccountReceivableDetail = new HashSet<AccountReceivableDetail>();
        }

        public Guid Oid { get; set; }
        public string SourceKey { get; set; }
        public string AccountCode { get; set; }
        public string DetailCode { get; set; }
        public string ProfitCenter { get; set; }
        public string Description { get; set; }
        public Guid? DataSource { get; set; }

        public virtual ICollection<AccountPayableDetail> AccountPayableDetail { get; set; }
        public virtual ICollection<AccountReceivableDetail> AccountReceivableDetail { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
