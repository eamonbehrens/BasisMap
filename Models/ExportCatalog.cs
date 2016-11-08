using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ExportCatalog
    {
        public Guid Oid { get; set; }
        public Guid DataSet { get; set; }
        public string ExportPath { get; set; }
        public string ExportFile { get; set; }
        public DateTime ExtractDate { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
    }
}
