using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class BusinessAssociateExternal
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public string BarelationshipType { get; set; }
        public int? Baid { get; set; }
        public string Batpe { get; set; }
        public string Banme { get; set; }
        public string Baabbrvtn { get; set; }
        public int? BaprntBaid { get; set; }
        public int? BacrtnUserId { get; set; }
    }
}
