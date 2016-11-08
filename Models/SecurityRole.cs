using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class SecurityRole
    {
        public Guid Oid { get; set; }

        public virtual SecurityStrategyRole O { get; set; }
    }
}
