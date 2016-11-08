using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Country
    {
        public Country()
        {
            Address1 = new HashSet<Address1>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string PhoneCode { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Address1> Address1 { get; set; }
    }
}
