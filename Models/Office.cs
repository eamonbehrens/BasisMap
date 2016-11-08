using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Office
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public int? OffceLcleId { get; set; }
        public int? OffceBaid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
