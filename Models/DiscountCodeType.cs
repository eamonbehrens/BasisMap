using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DiscountCodeType
    {
        public DiscountCodeType()
        {
            DiscountCode = new HashSet<DiscountCode>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public bool? IsFreightCode { get; set; }

        public virtual ICollection<DiscountCode> DiscountCode { get; set; }
    }
}
