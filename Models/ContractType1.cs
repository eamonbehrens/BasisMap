using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ContractType1
    {
        public ContractType1()
        {
            Contract = new HashSet<Contract>();
        }

        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public string PriorityLevel { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
