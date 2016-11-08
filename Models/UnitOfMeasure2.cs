using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class UnitOfMeasure2
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public int? Uom { get; set; }
        public string Uomdesc { get; set; }
        public string Uomabbv { get; set; }
        public string Uomtpe { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
