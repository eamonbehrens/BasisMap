using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class RawPriceLocale
    {
        public Guid Oid { get; set; }
        public int? RwPrceLcleId { get; set; }
        public int? RplcleRphdrId { get; set; }
        public int? RplcleLcleId { get; set; }
        public string CurveName { get; set; }
        public string LcleAbbrvtn { get; set; }
        public string LcleNme { get; set; }
        public Guid? DataSource { get; set; }

        public virtual DataSource DataSourceNavigation { get; set; }
    }
}
