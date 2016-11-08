using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Hcategory
    {
        public Guid Oid { get; set; }
        public Guid? Parent { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual Hcategory ParentNavigation { get; set; }
        public virtual ICollection<Hcategory> InverseParentNavigation { get; set; }
    }
}
