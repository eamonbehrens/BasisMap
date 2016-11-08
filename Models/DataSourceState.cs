using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DataSourceState
    {
        public DataSourceState()
        {
            DataSource = new HashSet<DataSource>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<DataSource> DataSource { get; set; }
    }
}
