using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Contact
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public string NameDescription { get; set; }
        public int? NameId { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
