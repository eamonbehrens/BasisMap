using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class PermissionsContainer
    {
        public PermissionsContainer()
        {
            PermissionData = new HashSet<PermissionData>();
        }

        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual ICollection<PermissionData> PermissionData { get; set; }
        public virtual SecurityStrategyRole SecurityStrategyRole { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
    }
}
