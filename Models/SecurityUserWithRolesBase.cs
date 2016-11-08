using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class SecurityUserWithRolesBase
    {
        public SecurityUserWithRolesBase()
        {
            SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles = new HashSet<SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles>();
        }

        public Guid Oid { get; set; }

        public virtual SecurityUser SecurityUser { get; set; }
        public virtual ICollection<SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles> SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles { get; set; }
        public virtual SecurityUserBase O { get; set; }
    }
}
