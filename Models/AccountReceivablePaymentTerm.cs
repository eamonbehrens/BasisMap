using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AccountReceivablePaymentTerm
    {
        public AccountReceivablePaymentTerm()
        {
            AccountReceivable1 = new HashSet<AccountReceivable1>();
        }

        public Guid Oid { get; set; }
        public string SourceKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccountReceivable1> AccountReceivable1 { get; set; }
    }
}
