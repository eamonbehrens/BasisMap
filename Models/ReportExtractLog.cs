using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ReportExtractLog
    {
        public Guid Oid { get; set; }
        public Guid? ReportExtract { get; set; }
        public string Activity { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
