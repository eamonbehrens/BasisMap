using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TicketApplicationTranRelationship
    {
        public Guid Oid { get; set; }
        public Guid? InboundTicketApplication { get; set; }
        public Guid? OutboundTicketApplication { get; set; }
        public Guid? DataSet { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
        public virtual TicketApplication InboundTicketApplicationNavigation { get; set; }
        public virtual TicketApplication OutboundTicketApplicationNavigation { get; set; }
    }
}
