using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Locale
    {
        public Guid Oid { get; set; }
        public int LcleId { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public DateTime? LoadDate { get; set; }
        public Guid? DataSource { get; set; }
        public string LcleTpeDscrptn { get; set; }

        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
