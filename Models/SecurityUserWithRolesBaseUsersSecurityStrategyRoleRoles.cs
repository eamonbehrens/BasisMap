using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles
    {
        public Guid? Roles { get; set; }
        public Guid? Users { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual SecurityStrategyRole RolesNavigation { get; set; }
        public virtual SecurityUserWithRolesBase UsersNavigation { get; set; }
    }
}
