using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class SecurityUser
    {
        public Guid Oid { get; set; }

        public virtual SecurityUserWithRolesBase O { get; set; }
    }
}
