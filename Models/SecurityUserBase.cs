using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class SecurityUserBase
    {
        public Guid Oid { get; set; }
        public string StoredPassword { get; set; }
        public bool? ChangePasswordOnFirstLogon { get; set; }
        public string UserName { get; set; }
        public bool? IsActive { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual SecurityUserWithRolesBase SecurityUserWithRolesBase { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
    }
}
