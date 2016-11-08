using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class NameAddress
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public int? Baid { get; set; }
        public string Banme { get; set; }
        public string Batpe { get; set; }
        public int? OffceLcleId { get; set; }
        public string AddrssLne1 { get; set; }
        public string AddrssLne2 { get; set; }
        public string AddrssCty { get; set; }
        public string AddrssStte { get; set; }
        public string AddrssCntry { get; set; }
        public string AddrssPstlCde { get; set; }
        public string OffceVcePhne { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
