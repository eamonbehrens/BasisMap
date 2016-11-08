using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Dtnhistory
    {
        public Dtnhistory()
        {
            Dtnfuture = new HashSet<Dtnfuture>();
        }

        public Guid Oid { get; set; }
        public DateTime? HistoryDate { get; set; }
        public Guid? Dtnfeed { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Dtnfuture> Dtnfuture { get; set; }
        public virtual Dtnfeed DtnfeedNavigation { get; set; }
    }
}
