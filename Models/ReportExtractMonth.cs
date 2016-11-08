using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ReportExtractMonth
    {
        public ReportExtractMonth()
        {
            ReportExtract = new HashSet<ReportExtract>();
        }

        public Guid Oid { get; set; }
        public DateTime? ExtractMonth { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<ReportExtract> ReportExtract { get; set; }
    }
}
