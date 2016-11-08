using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class JobHistory
    {
        public int JobHistoryId { get; set; }
        public Guid? ReportExtract { get; set; }
        public DateTime Timestamp { get; set; }
        public short? JobAreaId { get; set; }
        public string StatusMsg { get; set; }
        public string ErrMsg { get; set; }
    }
}
