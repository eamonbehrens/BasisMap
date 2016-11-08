using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TicketHistory
    {
        public Guid Oid { get; set; }
        public Guid TicketPrior { get; set; }
        public Guid TicketCurrent { get; set; }
        public Guid? DataSetPrior { get; set; }
        public Guid? DataSetCurrent { get; set; }
        public Guid? ReportExtract { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
