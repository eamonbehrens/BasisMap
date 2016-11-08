using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DataSourceSystemGroup
    {
        public DataSourceSystemGroup()
        {
            DataSource = new HashSet<DataSource>();
            LocationCommodity = new HashSet<LocationCommodity>();
            StateRegion = new HashSet<StateRegion>();
        }

        public Guid Oid { get; set; }
        public Guid DataSourceSystem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<DataSource> DataSource { get; set; }
        public virtual ICollection<LocationCommodity> LocationCommodity { get; set; }
        public virtual ICollection<StateRegion> StateRegion { get; set; }
        public virtual DataSourceSystem DataSourceSystemNavigation { get; set; }
    }
}
