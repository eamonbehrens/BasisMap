using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DataSourceSystem
    {
        public DataSourceSystem()
        {
            DataSource = new HashSet<DataSource>();
            DataSourceSystemGroup = new HashSet<DataSourceSystemGroup>();
        }

        public Guid Oid { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<DataSource> DataSource { get; set; }
        public virtual ICollection<DataSourceSystemGroup> DataSourceSystemGroup { get; set; }
    }
}
