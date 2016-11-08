using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ReportExtractType
    {
        public ReportExtractType()
        {
            ReportExtract = new HashSet<ReportExtract>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<ReportExtract> ReportExtract { get; set; }
    }
}
