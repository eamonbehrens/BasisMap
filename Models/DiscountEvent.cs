using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DiscountEvent
    {
        public DiscountEvent()
        {
            DiscountPremium = new HashSet<DiscountPremium>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<DiscountPremium> DiscountPremium { get; set; }
    }
}
