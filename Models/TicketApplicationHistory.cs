using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TicketApplicationHistory
    {
        public Guid Oid { get; set; }
        public Guid? TicketApplicationPrior { get; set; }
        public Guid? TicketApplicationCurrent { get; set; }
        public Guid? DataSetPrior { get; set; }
        public Guid? DataSetCurrent { get; set; }

        public virtual DataSet DataSetCurrentNavigation { get; set; }
        public virtual DataSet DataSetPriorNavigation { get; set; }
        public virtual TicketApplication TicketApplicationCurrentNavigation { get; set; }
        public virtual TicketApplication TicketApplicationPriorNavigation { get; set; }
    }
}
