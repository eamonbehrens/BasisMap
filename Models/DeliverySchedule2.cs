using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DeliverySchedule2
    {
        public Guid Oid { get; set; }
        public Guid? DataSet { get; set; }
        public int? DlHdrId { get; set; }
        public string DlHdrIntrnlNbr { get; set; }
        public int? DlHdrTyp { get; set; }
        public short? DlDtlId { get; set; }
        public int? DlDtlLcleId { get; set; }
        public int? OriginLcleId { get; set; }
        public int? DestinationLcleId { get; set; }
        public int? DlDtlTmplteId { get; set; }
        public string DlDtlSpplyDmnd { get; set; }
        public string DlDtlTpe { get; set; }
        public short? ObId { get; set; }
        public DateTime? ObFrmDte { get; set; }
        public DateTime? ObToDte { get; set; }
        public double? ObQty { get; set; }
        public string ObStts { get; set; }
        public int? RphdrId { get; set; }
        public int? RwPrceLcleId { get; set; }
        public string CurveName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string ContractType { get; set; }
        public int? PrvsnId { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
    }
}
