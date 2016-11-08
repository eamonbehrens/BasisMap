using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TicketDiscount
    {
        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string ApplicationNumber { get; set; }
        public double? CalculationRate1 { get; set; }
        public double? CalculationRate2 { get; set; }
        public double? CalculationRate3 { get; set; }
        public double? CalculationRate4 { get; set; }
        public double? CalculationRate5 { get; set; }
        public double? CalculationRate6 { get; set; }
        public double? CalculationRate7 { get; set; }
        public double? CalculationRate8 { get; set; }
        public string CalculationTypes { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountTable { get; set; }
        public string InOutCode { get; set; }
        public Guid? TicketApplication { get; set; }
        public Guid? DataSet { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
        public virtual TicketApplication TicketApplicationNavigation { get; set; }
    }
}
