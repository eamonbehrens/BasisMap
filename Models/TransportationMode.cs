using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TransportationMode
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public int? DynLstBxId { get; set; }
        public string Description { get; set; }
        public string InboundFreightStatus { get; set; }
        public string OutboundFreightStatus { get; set; }
        public string InboundWeightCertificate { get; set; }
        public string OutboundWeightCertificate { get; set; }
        public string InboundGradeCertificate { get; set; }
        public string OutboundGradeCertificate { get; set; }
        public string Mode { get; set; }
        public string UniqueNumberIndicator { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
