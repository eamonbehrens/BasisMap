using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DiscountCode
    {
        public DiscountCode()
        {
            DiscountPremium = new HashSet<DiscountPremium>();
        }

        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public Guid? DiscountCodeType { get; set; }
        public string IsByCommodity { get; set; }
        public string IsTaxable { get; set; }
        public string SettlementSequence { get; set; }
        public string IsRecalculatedFromStart { get; set; }
        public string TaxableField4 { get; set; }
        public string AdvanceOnSettlement { get; set; }
        public string TaxableField3 { get; set; }
        public string IsByState { get; set; }
        public string TaxableField1 { get; set; }
        public string SettlementPriorityGroup { get; set; }
        public string IsByLocation { get; set; }
        public string IsIncludedInValue { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string RecordType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<DiscountPremium> DiscountPremium { get; set; }
        public virtual DataSource DataSourceNavigation { get; set; }
        public virtual DiscountCodeType DiscountCodeTypeNavigation { get; set; }
    }
}
