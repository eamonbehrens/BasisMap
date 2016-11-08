using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Contract3
    {
        public Guid Oid { get; set; }
        public Guid? DataSet { get; set; }
        public int? DlHdrId { get; set; }
        public string DlHdrIntrnlNbr { get; set; }
        public string DlHdrExtrnlNbr { get; set; }
        public int? DlHdrTyp { get; set; }
        public int? DlHdrExtrnlBaid { get; set; }
        public int? DlHdrExtrnlCntctId { get; set; }
        public int? DlHdrIntrnlBaid { get; set; }
        public int? DlHdrIntrnlUserId { get; set; }
        public string DlHdrStat { get; set; }
        public DateTime? DlHdrCrtnDte { get; set; }
        public int? DealDetailId { get; set; }
        public short? DlDtlId { get; set; }
        public double? DlDtlQntty { get; set; }
        public int? DlDtlPrdctId { get; set; }
        public string DlDtlMthdTrnsprttn { get; set; }
        public string Uomabbv { get; set; }
        public string DeliveryTerm { get; set; }
        public int? RwPrceLcleId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DlDtlSpplyDmnd { get; set; }
        public Guid? Location { get; set; }
        public Guid? DataSource { get; set; }
        public Guid? Commodity { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
    }
}
