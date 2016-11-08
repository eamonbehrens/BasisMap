using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ReportExtract
    {
        public ReportExtract()
        {
            DataSet = new HashSet<DataSet>();
        }

        public Guid Oid { get; set; }
        public DateTime ExtractDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public int ExtractNumber { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? ReportExtractType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? ReadyToDelete { get; set; }
        public Guid? ReportExtractMonth { get; set; }
        public Guid? ReportExtractPrevious { get; set; }

        public virtual ICollection<DataSet> DataSet { get; set; }
        public virtual ReportExtractMonth ReportExtractMonthNavigation { get; set; }
        public virtual ReportExtract ReportExtractPreviousNavigation { get; set; }
        public virtual ICollection<ReportExtract> InverseReportExtractPreviousNavigation { get; set; }
        public virtual ReportExtractType ReportExtractTypeNavigation { get; set; }
    }
}
