using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class SecurityStrategyRole
    {
        public SecurityStrategyRole()
        {
            SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles = new HashSet<SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }

        public virtual SecurityRole SecurityRole { get; set; }
        public virtual ICollection<SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles> SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles { get; set; }
        public virtual PermissionsContainer O { get; set; }
    }
}
