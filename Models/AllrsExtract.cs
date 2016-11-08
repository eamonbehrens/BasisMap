using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AllrsExtract
    {
        public int LineSequence { get; set; }
        public string RawData { get; set; }
        public string RecordType { get; set; }
        public string FolderName { get; set; }
        public string Location { get; set; }
        public string Commodity { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public bool IsSummary { get; set; }
        public bool IsSkipped { get; set; }
        public Guid? DataSet { get; set; }
    }
}
