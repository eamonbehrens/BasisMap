using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class MarketZone
    {
        public Guid Oid { get; set; }
        public Guid? DataSet { get; set; }
        public string RecordType { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public bool? IsBasisZone { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual DataSource DataSetNavigation { get; set; }
    }
}
