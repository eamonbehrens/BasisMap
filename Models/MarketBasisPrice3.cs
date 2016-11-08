using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class MarketBasisPrice3
    {
        public Guid Oid { get; set; }
        public decimal? Basis { get; set; }
        public Guid? Location { get; set; }
        public Guid? Commodity { get; set; }
        public string OptionMonth { get; set; }
        public Guid? OptionMonthId { get; set; }
        public Guid? Exchange { get; set; }
        public Guid? MarketZone { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Protein { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsCurrent { get; set; }
        public string ContractNumber { get; set; }
        public string UnitOfMeasureCode { get; set; }
    }
}
