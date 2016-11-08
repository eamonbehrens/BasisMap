using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ContractType
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public string PriorityLevel { get; set; }
        public int? DlTypId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
