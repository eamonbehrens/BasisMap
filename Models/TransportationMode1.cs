using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TransportationMode1
    {
        public TransportationMode1()
        {
            Contract = new HashSet<Contract>();
            Ticket = new HashSet<Ticket>();
        }

        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public string Description { get; set; }
        public string InboundFreightStatus { get; set; }
        public string OutboundWeightCertificate { get; set; }
        public string InboundGradeCertificate { get; set; }
        public string OutboundFreightStatus { get; set; }
        public string OutboundGradeCertificate { get; set; }
        public string Mode { get; set; }
        public string UniqueNumberIndicator { get; set; }
        public string InboundWeightCertificate { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
